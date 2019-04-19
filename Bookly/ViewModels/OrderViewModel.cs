using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookly.Models;

namespace Bookly.ViewModels
{
    public class OrderViewModel
    {
		public Book BookToOrder { get; set; }
		public Order OrderDetails { get; set; }
	}
}
