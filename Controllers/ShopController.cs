using AProjekt_Supermarked.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AProjekt_Supermarked.Controllers
{
    public class ShopController : Controller
    {
        List<string> kurv;
        private ShoppingContext dbctx;
        public ShopController(ShoppingContext _ctx)
        {
            dbctx=_ctx;
            kurv= new List<string>();
        }

        public IActionResult Index(){
            return View();
        }        


        public IActionResult SpecifikVare(int id){
            
            var Kategori = dbctx.dbsKategorier.FirstOrDefault(x=>x.VareKatID==id);

            ViewData["VareKategori"]=Kategori.Kategori;


            var model = dbctx.dbsVare.Where(x=>x.VareKatID==id).ToList();

            return View(model);
        }

        public IActionResult Betaling(){
            return View();
        }

        public IActionResult Opsumering(){
            return View();
        }

        public IActionResult TrackDrone(int id){
            return View();
        }
    }
}