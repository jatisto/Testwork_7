using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AppliancesTech.Models.ShopModel;

namespace AppliancesTech.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Имя"), Required] public string Name { get; set; }

        [Display(Name = "Производитель"), Required]
        public string Manufacturer { get; set; }

        [Display(Name = "Категория"), Required]
        public CategoryViewModel CategoryViewModel { get; set; }

        [Display(Name = "Описание"), Required] public string Description { get; set; }
        [Display(Name = "Цена"), Required] public double Price { get; set; }
        [Display(Name = "Есть в наличии")] public bool IsInStock { get; set; }
    }
}