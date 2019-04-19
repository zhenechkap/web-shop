using Bookly.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bookly.ViewModels;

namespace Bookly.Data
{
    public class BooklyDbContex:IdentityDbContext<SiteUser>
    {
		public BooklyDbContex(DbContextOptions options):base(options)
		{
		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Carousel> Carousels { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
