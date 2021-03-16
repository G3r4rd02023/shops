using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres")]
        [Required]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

        [DisplayName("No Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
