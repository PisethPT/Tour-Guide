using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tour_Guide.Models;
using Tour_Guide.ViewModels;

namespace Tour_Guide.Views
{
    /// <summary>
    /// Interaction logic for TouristPage.xaml
    /// </summary>
    public partial class TouristPage : UserControl
    {
        public TouristPage()
        {
            InitializeComponent();
        }

        private void MoreDetailClick(object sender, RoutedEventArgs e)
        {
            string catalogName = TextCatalogName.Text;

            CatalogListViewModel catalogListViewModel = new CatalogListViewModel();
            List<TouristPoint> touristPoints = catalogListViewModel.Catalogs.ToList();

            if (touristPoints != null)
            {
                for (int i = 0; i < touristPoints.Count; i++)
                {
                    if (catalogName == touristPoints[i].Name)
                    {
                        catalogListViewModel.catalogIndex = i;
                        //MessageBox.Show($"{catalogListViewModel.catalogIndex}", "Index", MessageBoxButton.OK);
                        CatalogListView catalogListView = new CatalogListView();
                        catalogListView.DataContext = catalogListViewModel;

                        MainWindow mainWindow = new MainWindow
                        {
                            Content = catalogListView
                        };
                        mainWindow.Show();
                        break;
                    }
                }
            }
        }
    }
}
