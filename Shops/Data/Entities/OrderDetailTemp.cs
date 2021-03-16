using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Data.Entities
{
    public class OrderDetailTemp
    {
		public int Id { get; set; }

		[Required]
		public User User { get; set; }

		[Required]
		[Display(Name = "Producto")]
		public Product Product { get; set; }

		[DisplayFormat(DataFormatString = "{0:C2}")]
		[Display(Name = "Precio")]
		public decimal Price { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}")]
		[Display(Name = "Cantidad")]
		public double Quantity { get; set; }

		[DisplayFormat(DataFormatString = "{0:C2}")]
		[Display(Name = "Valor")]
		public decimal Value { get { return this.Price * (decimal)this.Quantity; } }
	}
}
