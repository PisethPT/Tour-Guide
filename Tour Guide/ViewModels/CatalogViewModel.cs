using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Tour_Guide.Models;

namespace Tour_Guide.ViewModels
{
    public class CatalogViewModel : ViewModelBase
    {
        private readonly TouristPoint _touristPoint;

        public string Name => _touristPoint.Name;
        public string Photo => _touristPoint.Photo;
        public string Description => _touristPoint.Description;
        public string InterestingFacts => _touristPoint.InterestingFacts;
        public string LocalCuisine => _touristPoint.LocalCuisine;
        public string Currency => _touristPoint.Currency;
        public string TimeZone => _touristPoint.TimeZone;
        public string Weather => _touristPoint.Weather;
        public string PlacesOfInterest => _touristPoint.PlacesOfInterest;
        public string Dangers => _touristPoint.Dangers;
        public string PricesForAccommodationAndMeals => _touristPoint.PricesForAccommodationAndMeals;
        public List<string> Videos => _touristPoint.Videos;
        public List<string> strings => _touristPoint.images.ToList();

        public CatalogViewModel(TouristPoint touristPoint)
        {
            _touristPoint = touristPoint;
        }
    }
}
