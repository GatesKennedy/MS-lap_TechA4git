 // Code Snippet from Reviews Controller
 // GET: Reviews/Create
        [Authorize]
        public ActionResult Create(string placeID)
        {
            var placeReviewModel = new ReviewViewModel();
            // Check if a Place Object has been passed to this method
            if (db.Places.Find(placeID) != null)
            {
                // Find Place, Instantiate Model and Pass to View
                Place placeForReview = db.Places.Find(placeID);
                placeReviewModel = new ReviewViewModel(placeForReview);
                return View(placeReviewModel);
            }
            else if (placeID != null && db.Places.Find(placeID) == null)
            {
                // If a passed-in 'Place' doesnt exist in the database, assign ID for Google Places-Services
                placeReviewModel.PlaceID = placeID;
                return View(placeReviewModel);
            }
            
            // Pass 'ReviewViewModel' Instance to 'View()'
            return View(placeReviewModel);
        }