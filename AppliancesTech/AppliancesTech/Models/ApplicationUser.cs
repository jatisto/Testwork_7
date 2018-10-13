using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AppliancesTech.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string AvatarImage { get; set; }
        public string Name { get; set; }

        [Display(Name = "Категория"), Required]
        public CategoryViewModel CategoryViewModel { get; set; }
    }
}