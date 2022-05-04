using medTO_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace medTO_MVC.Data;

public class ApplicationDbContext : DbContext  
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    private DbSet<Category> Categories { get; set; }
}