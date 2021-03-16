using Microsoft.AspNetCore.Http;
using Shops.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Shops.Models
{
    public class CategoryViewModel : Category
    {

        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }

    }
}

