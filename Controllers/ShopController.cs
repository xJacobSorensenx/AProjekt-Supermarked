using AProjekt_Supermarked.Services;
using AProjekt_Supermarked.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AProjekt_Supermarked.Controllers
{
    public class ShopController : Controller
    {
        private ShoppingContext dbctx;
        public ShopController(ShoppingContext _ctx)
        {
            dbctx=_ctx;
        }

        public IActionResult Index(){
            return View();
        }        


        public IActionResult SpecifikVare(int id){
            
            var Kategori = dbctx.dbsKategorier.FirstOrDefault(x=>x.VareKatID==id);
            var VM = new VMtest1();
            var strlist = new List<string>();

            strlist.Add("debug1");
            strlist.Add("debug2");
            strlist.Add("debug3");
            strlist.Add("debug4");

            ViewData["VareKategori"]=Kategori.Kategori;

            VM.Varer=dbctx.dbsVare.Where(x=>x.VareKatID==id).ToList();

            VM.Kurven=strlist;



            return View(VM);
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