using AProjekt_Supermarked.Models;
using Microsoft.EntityFrameworkCore;

namespace AProjekt_Supermarked.Services
{
    public class ShoppingContext:DbContext
    {
        public ShoppingContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<IndkobModel> dbsIndkob { get; set; }
        public DbSet<VareModel> dbsVare { get; set; }


    }
    
}