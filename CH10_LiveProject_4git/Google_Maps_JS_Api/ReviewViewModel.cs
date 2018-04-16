        // Code Snippet From ReviewViewModel.cs

     public class ReviewViewModel
    {
        public ReviewViewModel(Place place)
        {
            PlaceID = place.PlaceID;
            PlaceName = place.Name;
            StreetNumber = null;        // Does not exist in 'Place'
            Route = null;               // Does not exist in 'Place'
            PostalCode = null;          // Does not exist in 'Place'
            Country = place.CountryName;
            State = place.StateName;
            City = place.CityName;
            Lat = place.Lat;
            Lng = place.Lng;
            Website = null;             // Does not exist in 'Place'
        }
    }
    