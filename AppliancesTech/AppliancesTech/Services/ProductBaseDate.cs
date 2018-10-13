using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppliancesTech.Data;
using AppliancesTech.Models.ShopModel;
using Microsoft.EntityFrameworkCore;

namespace AppliancesTech.Services
{

    public class ProductBaseDate : ICategoryDetails
    {
        private ApplicationDbContext _applicationDbContext;

        public ProductBaseDate(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _applicationDbContext.Products.OrderBy(p => p.Name);
        }

        public Product GetProductId(int id)
        {
            return _applicationDbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
            _applicationDbContext.Products.Add(product);
            _applicationDbContext.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            _applicationDbContext.Attach(product).State = EntityState.Modified;
            _applicationDbContext.SaveChanges();
            return product; 
        }
    }
}
