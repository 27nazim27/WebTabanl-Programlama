using E_Ticaret.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E_Ticaret.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
