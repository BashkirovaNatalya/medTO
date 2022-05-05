using medTO_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace medTO_MVC.Data;

public class ApplicationDbContext : DbContext  
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}