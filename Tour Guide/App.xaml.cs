using System.Configuration;
using System.Data;
using System.Windows;
using Tour_Guide.Exceptions;
using Tour_Guide.Models;
using Tour_Guide.ViewModels;

namespace Tour_Guide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            //MakeCatalog catalog1 = new MakeCatalog();
            //try
            //{
            //    catalog1.AddCatalogs
            //        (
            //            new Catalog(
            //                "Angkor Wat",
            //                new TouristPoint("Angkor Toum", "images/photo1", "videos/video1", "somthing description", "somthing interestingFacts", "localCuisine", 4150, DateTime.Now, "normal", "temple", "no have", "1.5$")
            //                )
            //         );
            //    catalog1.AddCatalogs
            //        (
            //            new Catalog(
            //                "Angkor Wat",
            //                new TouristPoint("Angkor Toch", "images/photo1", "videos/video1", "somthing description", "somthing interestingFacts", "localCuisine", 4150, DateTime.Now, "normal", "temple", "no have", "1.5$")
            //                )
            //         );

            //}
            //catch (CatalogConfictException ex)
            //{

            //}

            //IEnumerable<Catalog> catalogs = catalog1.GetCatalogs("Angkor Wat");

            MainWindow main = new MainWindow()
            {
                DataContext = new TourGuideMain()
            };
            
            main.Show();
            base.OnStartup(e);
        }

    }

}
