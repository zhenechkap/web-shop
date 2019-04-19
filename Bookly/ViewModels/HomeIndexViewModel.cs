using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookly.Models;

namespace Bookly.ViewModels
{
    public class HomeIndexViewModel
    {
		public IEnumerable<Book> Books { get; set; }
		public IEnumerable<Carousel> Carousels { get; set; }
	}
}
