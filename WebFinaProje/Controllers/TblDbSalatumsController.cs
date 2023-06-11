using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sevice.@class;
using services.ModelsS;
using Services.@class;
using System.Configuration.Internal;

namespace FinalProjesiWeb.Controllers
{
    public class TblDbSalatumsController : Controller
    {
        Salataservices srvcslt = new Salataservices();
        static int idbulma;
        public IActionResult Index()
        { 
         

            var vm = srvcslt.GetTblkategorilers();
            return View(vm);
        }
        public IActionResult Index2()
        {


            var vm = srvcslt.GetTblkategorilers();
            return View(vm);
        }



        public IActionResult Olustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult kayital(TblDbSalatum tblDbSalatum, IFormFile file)
        {
            var imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            srvcslt.olustur(tblDbSalatum,imagePath);

            return RedirectToAction("Index2");
        }
        public IActionResult Sil(int id)
        {

            srvcslt.Sil(id);


            return RedirectToAction("Index2");
        }
        public IActionResult Guncelle(int id)
        {
            idbulma = id;
            var crb = srvcslt.Guncelle(id);


            return View("Guncelle", crb);
        }
        [HttpPost]
        public IActionResult GuncelleYap(TblDbSalatum tblDbSalatum, IFormFile file)
        {
            var imagePath =  tblDbSalatum.SalataResim;

            if (file != null)
            {
                imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            }
            srvcslt.GuncelleYap(tblDbSalatum, idbulma,imagePath);


            return RedirectToAction("Index2");
        }
    }
}
