using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

using services.ModelsS;
using sevice.@class;

namespace WebFinaProje.Controllers
{
    public class KayitOlmaController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult olustur(TblDbKullanici tblDbKullanici)
        {
            Kayitservices kayitservices = new Kayitservices();

            kayitservices.olustur(tblDbKullanici);
            return RedirectToAction("Index");
        }

       
        public IActionResult Index2()
        {

            return View();

        }

        [HttpPost]
        public IActionResult giris(TblDbKullanici tblDbKullanici)
        {

            Kayitservices kayitservices = new Kayitservices();
            kayitservices.kontrol(tblDbKullanici);
            bool srg = kayitservices.giris(tblDbKullanici);
            if(tblDbKullanici.KullaniciAd=="FRKN" && tblDbKullanici.KullaniciSifre=="1" &&tblDbKullanici.KullaniciEmail=="boyacifrkn@gmail.com") {

                return RedirectToAction("Index2", "Anasayfa");
            }
            else {
                if (srg)
                {
                    return RedirectToAction("Index", "Anasayfa");

                }
                else
                {
                    return RedirectToAction("Index2", "KayitOlma");
                }
            }



        }






    }

  




}
