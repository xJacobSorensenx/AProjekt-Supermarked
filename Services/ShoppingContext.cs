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
        public DbSet<KundeModel> dbsKunde { get; set; }
        public DbSet<HandelsHistorikModel> dbsHH { get; set; }
        public DbSet<VareKatModel> dbsKategorier { get; set; }

    }
    
}