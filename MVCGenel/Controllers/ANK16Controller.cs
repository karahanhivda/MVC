using Microsoft.AspNetCore.Mvc;
using MVCGenel.Data;

namespace MVCGenelControllers
{
    public class ANK16Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sinif()
        {
            return View();
        }
        public IActionResult Rastgele()
        {
            int sayi = new Random().Next(1, 101);
            //ViewBag.Sayi = sayi;
            ViewData["Sayi"] = sayi;
            TempData["Sayi"] = sayi;
            return View();
        }
        public IActionResult Sayilar()
        {
            return View();
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult Form(Kullanici kullanici)
        {
            if (kullanici.Yas < 18)
            {
                TempData["Hata"] = "Yaşınız uygun değil!";
                return View("Form");
            }
            else
            {
                TempData["Kisi"] = kullanici;
                return RedirectToAction("Anasayfa");
            }
            
        }
    }
}
