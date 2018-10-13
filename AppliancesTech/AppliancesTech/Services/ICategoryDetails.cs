using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppliancesTech.Models.ShopModel;

namespace AppliancesTech.Services
{
    public interface ICategoryDetails
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductId(int id);
        Product Add(Product product);
        Product Update(Product product);
    }
}