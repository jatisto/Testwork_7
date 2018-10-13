using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppliancesTech.Models.ShopModel
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Имя"), Required] public string Name { get; set; }
        [Display(Name = "Производитель"), Required] public string Manufacturer { get; set; }
        [Display(Name = "Категория"), Required] public CategoryViewModel CategoryViewModel { get; set; }
        [Display(Name = "Описание"), Required] public string Description { get; set; }
        [Display(Name = "Цена"), Required] public double Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsInStock { get; set; }
       

        //производитель, наименование, категория, цена, дата поступления в магазин, описание.
    }
}