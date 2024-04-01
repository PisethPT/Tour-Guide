using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Tour_Guide.Models;

namespace Tour_Guide.Converter
{
    public class SelectedTouristPointConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2 && values[0] is ObservableCollection<TouristPoint> catalogs && values[1] is int catalogIndex)
            {
                if (catalogIndex >= 0 && catalogIndex < catalogs.Count)
                {
                    return catalogs[catalogIndex];
                }
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
