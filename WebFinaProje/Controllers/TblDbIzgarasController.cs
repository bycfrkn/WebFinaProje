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
    public class TblDbIzgarasController : Controller
    {
        Izgaraservices srvcizgr = new Izgaraservices();
        static int idbulma;
        public IActionResult Index()
        { 
            

            var vm = srvcizgr.GetTblkategorilers();
            return View(vm);
        }
        public IActionResult Index2()
        {


            var vm = srvcizgr.GetTblkategorilers();
            return View(vm);
        }



        public IActionResult Olustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult kayital(TblDbIzgara tblDbIzgara,IFormFile file)
        {
            var imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            srvcizgr.olustur(tblDbIzgara,imagePath);

            return RedirectToAction("Index2");
        }
        public IActionResult Sil(int id)
        {

            srvcizgr.Sil(id);


            return RedirectToAction("Index2");
        }
        public IActionResult Guncelle(int id)
        {
            idbulma = id;
            var crb = srvcizgr.Guncelle(id);


            return View("Guncelle", crb);
        }
        [HttpPost]
        public IActionResult GuncelleYap(TblDbIzgara tblDbIzgara, IFormFile file)
        {
            var imagePath = tblDbIzgara.IzgaraResim;

            if (file != null)
            {
                imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            }

            srvcizgr.GuncelleYap(tblDbIzgara, idbulma,imagePath);
           

            return RedirectToAction("Index2");
        }
    }
}
