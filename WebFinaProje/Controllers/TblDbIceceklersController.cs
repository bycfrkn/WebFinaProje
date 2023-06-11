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
    public class TblDbIceceklersController : Controller
    {
        Iceceksevices srvicik = new Iceceksevices();
        static int idbulma;
        public IActionResult Index()
        { 
            
            var vm = srvicik.GetTblkategorilers();
            return View(vm);
        }
        public IActionResult Index2()
        {


            var vm = srvicik.GetTblkategorilers();
            return View(vm);
        }



        public IActionResult Olustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult kayital(TblDbIcecekler tblDbIcecekler, IFormFile file)
        {
            var imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            srvicik.olustur(tblDbIcecekler,imagePath);

            return RedirectToAction("Index2");
        }
        public IActionResult Sil(int id)
        {

            srvicik.Sil(id);


            return RedirectToAction("Index2");
        }
        public IActionResult Guncelle(int id)
        {
            idbulma = id;
            var crb = srvicik.Guncelle(id);


            return View("Guncelle", crb);
        }
        [HttpPost]
        public IActionResult GuncelleYap(TblDbIcecekler tblDbIcecekler, IFormFile file)
        {
            var imagePath =  tblDbIcecekler.IcecekResim;

            if (file != null)
            {
                imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            }
            srvicik.GuncelleYap(tblDbIcecekler, idbulma, imagePath);



            return RedirectToAction("Index2");
        }
    }
}
