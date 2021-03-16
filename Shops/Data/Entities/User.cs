using Microsoft.AspNetCore.Identity;
using Shops.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Data.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "No Identidad")]
        [MaxLength(20, ErrorMessage = "* Solo se permiten números.")]
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Foto")]
        public string Image { get; set; }

        [Display(Name = "Tipo de Usuario")]
        public UserType UserType { get; set; }

        public City City { get; set; }

        [Display(Name = "Usuario")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Usuario")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

    }
}
