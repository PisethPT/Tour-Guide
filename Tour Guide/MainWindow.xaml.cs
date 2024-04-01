using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tour_Guide.ViewModels;

namespace Tour_Guide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clossingLoad(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CatalogListViewModel catalogListViewModel = new CatalogListViewModel();
            catalogListViewModel.SaveData();
           // MessageBox.Show("Saved Date","Succes", MessageBoxButton.OK);
        }
    }
}