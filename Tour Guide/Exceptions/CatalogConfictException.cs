using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tour_Guide.Models;

namespace Tour_Guide.Exceptions
{
    public class CatalogConfictException : Exception
    {
        public Catalog existCatalog { get; }
        public Catalog incomCatalog { get; }

        public CatalogConfictException(Catalog existCatalog, Catalog incomCatalog)
        {
            this.existCatalog = existCatalog;
            this.incomCatalog = incomCatalog;
        }
        public CatalogConfictException(string? message, Catalog existCatalog, Catalog incomCatalog) : base(message)
        {
            this.existCatalog = existCatalog;
            this.incomCatalog = incomCatalog;
        } 
        public CatalogConfictException(string? message, Exception? innerException, Catalog existCatalog, Catalog incomCatalog) : base(message, innerException)
        {
            this.existCatalog = existCatalog;
            this.incomCatalog = incomCatalog;
        }
    }
}
