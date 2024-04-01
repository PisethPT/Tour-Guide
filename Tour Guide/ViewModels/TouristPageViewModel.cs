using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Guide.ViewModels
{
    public class TouristPageViewModel : ViewModelBase
    {
		private string? _name;

		public string? Name
		{
			get { return _name; }
			set 
			{ 
				_name = value;
				OnPropertyChanded(nameof(Name));
			}
		}

		private string? _photo;

        public string? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanded(nameof(_photo));
            }
        }

        private string? _video;

        public string? Video
        {
            get { return _video; }
            set
            {
                _video = value; OnPropertyChanded(nameof(Video));
            }
        }

        private string? _description;

        public string? Description
        {
            get { return _description; }
            set 
            { 
                _description = value; 
                OnPropertyChanded(nameof(Description));
            }
        }

        private string? _interestingFacts;

        public string? InterestingFacts
        {
            get { return _interestingFacts; }
            set 
            { 
                _interestingFacts = value; 
                OnPropertyChanded(nameof(InterestingFacts));
            }
        }

        private string? _localCuisine;

        public string? LocalCuisine
        {
            get { return _localCuisine; }
            set 
            { 
                _localCuisine = value; 
                OnPropertyChanded(nameof(LocalCuisine));
            }
        }

        private double _currency;

        public double Currency
        {
            get { return _currency; }
            set 
            { 
                _currency = value;
                OnPropertyChanded(nameof(Currency));
            }
        }

        private DateTime _timeZone;

        public DateTime TimeZone
        {
            get { return _timeZone; }
            set 
            {
                _timeZone = value;
                OnPropertyChanded(nameof(TimeZone));
            }
        }

        private string? _weather;

        public string? Weather
        {
            get { return _weather; }
            set 
            {
                _weather = value;
                OnPropertyChanded(nameof(Weather));
            }
        }

        private string? _placesOfInterest;

        public string? PlacesOfInterest
        {
            get { return _placesOfInterest; }
            set 
            { 
                _placesOfInterest = value;
                OnPropertyChanded(nameof(PlacesOfInterest));
            }
        }

        private string? _danger;

        public string? Dangers
        {
            get { return _danger; }
            set 
            { 
                _danger = value;
                OnPropertyChanded(nameof(Dangers));
            }
        }

        private string? _pricesForAccommodationAndMeals;

        public string? PricesForAccommodationAndMeals
        {
            get { return _pricesForAccommodationAndMeals; }
            set 
            { 
                _pricesForAccommodationAndMeals = value; 
                OnPropertyChanded(nameof(PricesForAccommodationAndMeals));
            }
        }





    }
}
