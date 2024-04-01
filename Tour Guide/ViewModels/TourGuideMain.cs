using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Guide.ViewModels
{
    public class TourGuideMain : ViewModelBase
    {
        public ViewModelBase currentViewModel { get; }
        public TourGuideMain()
        {
            currentViewModel = new CatalogListViewModel();
        }
    }
}
