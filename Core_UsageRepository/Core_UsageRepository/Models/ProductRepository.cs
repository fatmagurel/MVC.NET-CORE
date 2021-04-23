using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models
{
    public class ProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product(){ID=1, ProductName="Vişne", Price=19, Category="Meyveler"},
            new Product(){ID=2, ProductName="Kiraz", Price=12, Category="Meyveler"},
            new Product(){ID=3, ProductName="Ispanak", Price=5, Category="Sebzeler"},
            new Product(){ID=4, ProductName="Havuç", Price=3, Category="Sebzeler"},
            new Product(){ID=5, ProductName="Leblebi", Price=16, Category="Kuruyemişler"},
            new Product(){ID=6, ProductName="Fındık", Price=76, Category="Kuruyemişler"}
        }.AsQueryable();

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }


        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
