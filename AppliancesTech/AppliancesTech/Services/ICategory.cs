using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppliancesTech.Services
{
    public interface ICategory
    {
        object GetAllProduct(Func<object, bool> p);
    }
}