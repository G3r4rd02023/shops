using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Data.Entities
{
    public class Order : IEntity
    {
		public int Id { get; set; }

		[Required]
		[Display(Name = "Fecha")]
		[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
		public DateTime OrderDate { get; set; }

		[Display(Name = "Fecha de Entrega")]
		[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
		public DateTime? DeliveryDate { get; set; }

		[Required]
		public User User { get; set; }

		public IEnumerable<OrderDetail> Items { get; set; }

		[DisplayFormat(DataFormatString = "{0:N0}")]
		[Display(Name = "Lineas")]
		public int Lines { get { return this.Items == null ? 0 : this.Items.Count(); } }

		[DisplayFormat(DataFormatString = "{0:N2}")]
		[Display(Name = "Cantidad")]
		public double Quantity { get { return this.Items == null ? 0 : this.Items.Sum(i => i.Quantity); } }

		[DisplayFormat(DataFormatString = "{0:C2}")]
		[Display(Name = "Valor")]
		public decimal Value { get { return this.Items == null ? 0 : this.Items.Sum(i => i.Value); } }
	}
}
