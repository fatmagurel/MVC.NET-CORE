using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models
{
    //veritabanına bağlanmak için oluşturulmuş yapı
    public class EFProductRepository : IProductRepository
    {
        private ProjectContext _context;
        public EFProductRepository(ProjectContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;

        public Product GetById(int id)
        {
            //ID ye göre ürünü bulmak için find() metodunu kullanabiliriz.
            return _context.Products.Find(id);
        }

        public bool DeleteProduct(int id)
        {
            _context.Products.Remove(GetById(id));
            return _context.SaveChanges() > 0;

        }

        public bool UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            return _context.SaveChanges() > 0;

        }
        public bool InsertProduct(Product product)
        {
            //if(_context.Products.FirstOrDefault(x => x.ProductName == product.ProductName && x.Price == product.Price))
            //{

            //}
            _context.Products.Add(product);
            return _context.SaveChanges() > 0;

        }

    }
}
