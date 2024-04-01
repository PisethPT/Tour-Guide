using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Guide.Models
{
    public class Catalog
    {
        public string catalogName { get;} = string.Empty;
        public TouristPoint touristPoints { get;}

        public Catalog(string catalogName, TouristPoint touristPoints)
        {
            this.catalogName = catalogName;
            this.touristPoints = touristPoints;
        }

        internal bool Conficts(Catalog catalog)
        {
            if (catalog.catalogName == null) return false;
            return !(catalog.catalogName == catalogName);
        }

    }

}
