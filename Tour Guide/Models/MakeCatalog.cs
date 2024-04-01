using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour_Guide.Exceptions;

namespace Tour_Guide.Models
{
    public class MakeCatalog
    {
        private readonly List<Catalog> catalogs;
        public MakeCatalog()
        {
            catalogs = new List<Catalog>();
        }

        public IEnumerable<Catalog> GetCatalogs(string catalogName)
        {
            return catalogs.Where(c => c.catalogName == catalogName).ToList();
        }

        public void AddCatalogs(Catalog catalog)
        {
            foreach(Catalog existCatalog in catalogs)
            {
                if(existCatalog.Conficts(catalog))
                {
                    throw new CatalogConfictException(existCatalog, catalog);
                }
            }
            catalogs.Add(catalog);
        }
    }
}
