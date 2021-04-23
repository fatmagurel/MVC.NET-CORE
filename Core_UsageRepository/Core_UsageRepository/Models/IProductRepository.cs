using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models
{
    public interface IProductRepository
    {
        //Property,koleksiyon olması için ıqueryable verilir ve generic olarak product olduğu belirtilir.sadece get readonly metodu çalışıyor.

        IQueryable<Product> Products { get; }
        bool InsertProduct(Product product);

        Product GetById(int id);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);


    }
}
