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

namespace FinalProjesiWeb.Controllers
{
    public class TblDbTatlisController : Controller
    {
        static int idbulma;
        Tatliservices srvcttl = new Tatliservices();
        public IActionResult Index()
        {   
          
            var vm = srvcttl.GetTblkategorilers();
            return View(vm);
        }
        public IActionResult Index2()
        {


            var vm = srvcttl.GetTblkategorilers();
            return View(vm);
        }



        public IActionResult Olustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult kayital(TblDbTatli tblDbTatli, IFormFile file)
        {
            var imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            srvcttl.olustur(tblDbTatli,imagePath);

            return RedirectToAction("Index2");
        }
        public IActionResult Sil(int id)
        {

            srvcttl.Sil(id);


            return RedirectToAction("Index2");
        }
        public IActionResult Guncelle(int id)
        {
            idbulma = id;
            var crb = srvcttl.Guncelle(id);


            return View("Guncelle", crb);
        }
        [HttpPost]
        public IActionResult GuncelleYap(TblDbTatli tblDbTatli, IFormFile file)
        {
            var imagePath =tblDbTatli.TatliResim;

            if (file != null)
            {
                imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            }
            srvcttl.GuncelleYap(tblDbTatli, idbulma, imagePath);


            return RedirectToAction("Index2");
        }
    }
}
