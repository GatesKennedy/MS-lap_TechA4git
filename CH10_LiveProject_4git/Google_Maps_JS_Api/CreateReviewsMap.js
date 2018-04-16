function initMap() {

    console.log("Location Passed: " + LocationPassedIn.toString());
    console.log("ENTER Location NOT Passed In");

    //=======================
    //  Initialize Map
    //=======================
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -33.8688, lng: 151.2195 },
        zoom: 13,
        mapTypeControlOptions: {
            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
            position: google.maps.ControlPosition.LEFT_TOP
        },
        fullscreenControl: false
    });

    //=======================
    // Try HTML5 geolocation.
    ///======================
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var pos = {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };
            map.setCenter(pos);
        });

    } else {
        // Browser doesn't support Geolocation
        handleLocationError(false, infoWindow, map.getCenter());
    }

    //===================================================
    // Auto Complete for Google Map Places Search Bar
    var input = document.getElementById('pac-inputReview');
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);
    var autocomplete = new google.maps.places.Autocomplete(input);
    autocomplete.bindTo('bounds', map);

    //=====================
    // Info Window
    var infowindow = new google.maps.InfoWindow();
    var infowindowContent = document.getElementById('infowindow-content');
    infowindow.setContent(infowindowContent);

    var marker = new google.maps.Marker({
        map: map,
        //anchorPoint: new google.maps.Point(0,0)
    });


    //==============================
    // Pop-up window 'Selection-changed'
    marker.addListener('click', function () {
        infowindow.open(map, marker);
    });

    //================================
    //  Auto Complete Event Listeners
    //================================

    autocomplete.addListener('place_changed', function () {
        console.log("ENTER Autocomplete Listener");

        infowindow.close();
        var place = autocomplete.getPlace();
        map.setCenter

        console.log("autocomplete.getPlace() passed. (Inside NOT Passed Code Block)");
        console.log(".getPlace place Id: " + place.place_id);
        console.log(".getPlace place name: " + place.name);

        if (!place.geometry) {
            // User entered the name of a Place that was not suggested and
            // pressed the Enter key, or the Place Details request failed.
            console.log("ENTER 'if (!place.geometry)");
            window.alert("No details available for input: '" + place.name + "'");
            return;
        }

        // If the place has a geometry, then present it on a map.
        if (place.geometry.viewport) {
            console.log("ENTER 'if (place.geometry.viewport)");
            map.fitBounds(place.geometry.viewport);
            map.setCenter(place.geometry.location);
            map.setZoom(13);
            
        } else {
            console.log("ENTER 'else (if.place.geometry.viewport)");
            map.setCenter(place.geometry.location);
            map.setZoom(13);
        }

        var marker = new google.maps.Marker({
            map: map,
            position: { lat: place.lat, lng: place.lng }
        });

        marker.setVisible(true);

        // Set the position of the marker using the place ID and location.
    
        marker.setPlace({
            placeId: place.place_id,
            location: place.geometry.location
        });
        

        // Set Map Center to New Autocomplete LatLng
        map.setCenter(place.geometry.location);

        /*
        var infowindow = new google.maps.InfoWindow();
        var infowindowContent = document.getElementById('infowindow-content');
        infowindow.setContent(infowindowContent);
        */

        $('#infowindow-content').show();
        $('#review-location-icon').attr("src", place.icon);
        $('.hide-before-location-selection').show();
        $('.hide-after-location-selection').hide();
        $('#review-location-name').text(place.name);

        infowindowContent.children['place-icon'].src = place.icon;
        infowindowContent.children['place-name'].textContent = place.name;
        infowindowContent.children['place-address'].textContent = place.formatted_address;
        //infowindowContent.children['place-id'].textContent = place.place_id; // nobody wants to see this
        infowindow.open(map, marker);

        console.log(".getPlace Name: " + place.name,
            "\n .getPlace ID: " + place.place_id,
            "\n .getPlace Address: " + place.formatted_address
        );

     

    });

    //==========================================================================================
    //==========================================================================================
    //==========================================================================================

    if (LocationPassedIn == true) {

        console.log("'LocationPassedIn: " + LocationPassedIn.toString(),
            "\n ENTER Location IS Passed In"
        );

        // Check if Location Data has been passed in
        if (modelObjPlaceName != null) {
            console.log(
                "\n Model Place Name: " + modelObjPlaceName,
                "\n Model Place Lat: " + modelObjLat,
                "\n Model Place Lng: " + modelObjLng
            );
        }

        var map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: modelObjLat, lng: modelObjLng },
            zoom: 13,
            mapTypeControlOptions: {
                style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                position: google.maps.ControlPosition.LEFT_TOP
            },
            fullscreenControl: false
        });

        //========================================================
        // Use Google Places Services to Retrieve Location Details
        //========================================================
        var service = new google.maps.places.PlacesService(map);
        service.getDetails({
            placeId: modelObjPlaceId
        }, function (result, status) {
            if (status != google.maps.places.PlacesServiceStatus.OK) {
                alert(status);
                return;
            }
            var marker = new google.maps.Marker({
                map: map,
                position: result.geometry.location
            });

            console.log("Passed Places-Services .getDetails",
                "\n Result Place ID: " + result.place_id,
                "\n Result Place Name: " + result.name,
                "\n Result Place Address: " + result.formatted_address
            );

            var infowindow = new google.maps.InfoWindow();
            var infowindowContent = document.getElementById('infowindow-content');
            infowindow.setContent(infowindowContent);

            // Assign Information and Show Input Fields
            $('#infowindow-content').show();
            $('#review-location-icon').attr("src", result.icon);
            $('.hide-before-location-selection').show();
            $('.hide-after-location-selection').hide();
            $('#review-location-name').text(result.name);

            infowindowContent.children['place-icon'].src = result.icon;
            infowindowContent.children['place-name'].textContent = result.name;
            infowindowContent.children['place-address'].textContent = result.formatted_address;
            //infowindowContent.children['place-id'].textContent = result.place_id;  // nobody wants to see this
            infowindow.open(map, marker);

            LocationPassedIn = false;
            console.log("END .getDetails Block: LocationPassedIn = " + LocationPassedIn.toString());
        });

        LocationPassedIn = false;

        console.log("END of initMapLocation(): LocationPassedIn = " + LocationPassedIn.toString());
        return;
    }

}