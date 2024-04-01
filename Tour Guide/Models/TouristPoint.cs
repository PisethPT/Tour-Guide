using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Guide.Models
{
    public class TouristPoint
    {
        public int selectedTouristPoint { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Photo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string InterestingFacts { get; set; } = string.Empty;
        public string LocalCuisine { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string TimeZone { get; set; }
        public string Weather { get; set; } = string.Empty;
        public string PlacesOfInterest { get; set; } = string.Empty;
        public string Dangers { get; set; } = string.Empty;
        public string PricesForAccommodationAndMeals { get; set; } = string.Empty;
        public List<string> Videos { get; set;} = new List<string>();
        public List<string> images { get; set; } = new List<string>();

        public TouristPoint()
        {
        }

        public TouristPoint(string name, string photo, string description, string interestingFacts, string localCuisine, string currency, string timeZone, string weather, string placesOfInterest, string dangers, string pricesForAccommodationAndMeals, List<string> videos, List<string> images)
        {
            Name = name;
            Photo = photo;
            Description = description;
            InterestingFacts = interestingFacts;
            LocalCuisine = localCuisine;
            Currency = currency;
            TimeZone = timeZone;
            Weather = weather;
            PlacesOfInterest = placesOfInterest;
            Dangers = dangers;
            PricesForAccommodationAndMeals = pricesForAccommodationAndMeals;
            Videos = videos;
            this.images = images;
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is TouristPoint touristPoint && Name == touristPoint.Name && Photo == touristPoint.Photo && Videos == touristPoint.Videos && Description == touristPoint.Description && 
        //        InterestingFacts == touristPoint.InterestingFacts &&LocalCuisine == touristPoint.LocalCuisine && Currency == touristPoint.Currency && TimeZone == touristPoint.TimeZone && 
        //        Weather == touristPoint.Weather && PlacesOfInterest == touristPoint.PlacesOfInterest && Dangers == touristPoint.Dangers && PricesForAccommodationAndMeals == touristPoint.PricesForAccommodationAndMeals;
        //}

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() ^ Photo.GetHashCode() ^ Videos.GetHashCode() ^ Description.GetHashCode() ^ InterestingFacts.GetHashCode() ^ LocalCuisine.GetHashCode() ^ Currency.GetHashCode() ^
        //           TimeZone.GetHashCode() ^ Weather.GetHashCode() ^ PlacesOfInterest.GetHashCode() ^ Dangers.GetHashCode() ^ PricesForAccommodationAndMeals.GetHashCode();
        //}

        //public override string ToString()
        //{
        //    return $"{Name}, {Photo}, {Videos}, {Description}, {InterestingFacts}, {LocalCuisine}, {Currency}, {TimeZone}, {Weather}, {PlacesOfInterest}, {Dangers}, {PricesForAccommodationAndMeals}";
        //}
    }
}
