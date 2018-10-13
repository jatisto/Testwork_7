using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppliancesTech.Models.ShopModel
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
    }
}
