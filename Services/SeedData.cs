using System;
using System.Collections.Generic;
using System.Linq;
using AProjekt_Supermarked.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AProjekt_Supermarked.Services
{
    public class SeedData
    {
        public static void InitDb(IServiceProvider serviceProvider){
            var context = serviceProvider.GetRequiredService<ShoppingContext>();
            context.Database.EnsureCreated();
            //seed varekategorier
            if (!context.dbsKategorier.Any())
            {
                List<VareKatModel> katliste = new List<VareKatModel>(){
                    new VareKatModel(){Kategori="Frugt"},
                    new VareKatModel(){Kategori="Grønsager"},
                    new VareKatModel(){Kategori="Kød"},
                    new VareKatModel(){Kategori="Pasta"},
                    new VareKatModel(){Kategori="Vin"},
                    new VareKatModel(){Kategori="Snack"}
                };

                context.AddRange(katliste);
                context.SaveChanges();
            }

            if (!context.dbsVare.Any())
            {
                List<VareModel> vareliste = new List<VareModel>(){
                    new VareModel(){Navn="Banan", Pris=5, Beskrivelse="Dette er en gul frugt", VareKatID=1},
                    new VareModel(){Navn="Æble", Pris=6, Beskrivelse="Dette er en rund frugt", VareKatID=1},
                    new VareModel(){Navn="Pære", Pris=7, Beskrivelse="Dette er en grøn frugt", VareKatID=1},

                    new VareModel(){Navn="Tomat", Pris=4, Beskrivelse="dette er en grønsag", VareKatID=2},
                    new VareModel(){Navn="Pore", Pris=2, Beskrivelse="dette er en grønsag", VareKatID=2},
                    new VareModel(){Navn="Blomkål", Pris=12, Beskrivelse="dette er en grønsag", VareKatID=2}
                };

                context.AddRange(vareliste);
                context.SaveChanges();

            }



        }
    }
}