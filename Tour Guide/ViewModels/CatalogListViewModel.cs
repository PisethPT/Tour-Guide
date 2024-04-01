using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Tour_Guide.Models;

namespace Tour_Guide.ViewModels
{
    public class CatalogListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TouristPoint> catalogs;
        private TouristPoint? selectedTouristPoint;
        public int catalogIndex { get; set; }

        public IEnumerable<TouristPoint> Catalogs => catalogs;
        public TouristPoint ?SelectedTouristPoint
        {
            get => selectedTouristPoint;
            set
            {
                selectedTouristPoint = value;
                OnPropertyChanded(nameof(SelectedTouristPoint));
            }
        }

        public CatalogListViewModel()
        {
            catalogs = new ObservableCollection<TouristPoint>();
            if (File.Exists("MyData.json"))
            {
                catalogs.Clear();
                List<TouristPoint>? catalogViewModels = JsonConvert.DeserializeObject<List<TouristPoint>>(File.ReadAllText("MyData.json"));
                if (catalogViewModels != null)
                {
                    foreach (TouristPoint catalogViewModel in catalogViewModels)
                    {
                        catalogs.Add(catalogViewModel);
                    }
                }
            }
        }

        public void SaveData()
        {
            File.WriteAllText("MyData.json", JsonConvert.SerializeObject(catalogs, Formatting.Indented));
        }
    }
}
