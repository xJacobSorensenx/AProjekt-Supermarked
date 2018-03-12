using Microsoft.AspNetCore.Mvc;

namespace AProjekt_Supermarked.Controllers
{
    public class ShopController : Controller
    {

        public IActionResult Index(){
            return View();
        }        

        public IActionResult SpecifikVare(int id){
            return View();
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