using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookly.Data;
using Bookly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookly.Pages
{
    public class ListBooksModel : PageModel
    {
		private readonly BooklyDbContex _context;

		public ListBooksModel(BooklyDbContex context)
		{
			_context = context;
		}
		public List<Book> Books { get; set; }
        public void OnGet()
        {
			Books = _context.Books.ToList();
        }
    }
}