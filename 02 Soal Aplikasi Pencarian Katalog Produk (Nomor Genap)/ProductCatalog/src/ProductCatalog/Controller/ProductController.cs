using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductCatalog.Model.Entity;
using ProductCatalog.Model.Repository;

namespace ProductCatalog.Controller
{
    public class ProductController
    {
        private ProductRestApiRepository _repository;

        public ProductController()
        {
            _repository = new ProductRestApiRepository();
        }

        public List<Product> ReadByProductName(string productName)
        {
            return _repository.ReadByProductName(productName);
        }

        public List<Product> ReadByCategory(string category)
        {
            return _repository.ReadByCategory(category);
        }

        public List<Product> ReadBySupplier(string supplierName)
        {
            return _repository.ReadBySupplier(supplierName);
        }
    }
}
