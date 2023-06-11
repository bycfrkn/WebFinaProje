using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sevice.@class;
using services.ModelsS;
using Microsoft.Build.Evaluation;
using Services.@class;

namespace FinalProjesiWeb.Controllers
{
    public class TblDbCorbasController : Controller
    {
        Corbaservice ktgrcrb = new Corbaservice();
       static int idbulma;

        public IActionResult Index()
        {
          

            var vm = ktgrcrb.GetTblkategorilers();
            return View(vm);
        }
        public IActionResult Index2()
        {


            var vm = ktgrcrb.GetTblkategorilers();
            return View(vm);
        }



        public IActionResult Olustur()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult kayital(TblDbCorba tblDbCorba, IFormFile file)
        {

            var imagePath = "../Content/Resimler/" + Resim.UploadImage(file);
            ktgrcrb.olustur(tblDbCorba,imagePath);
            return RedirectToAction("Index2");
        }

        public IActionResult Sil(int id)
        {

            ktgrcrb.Sil(id);


            return RedirectToAction("Index2");
        }
        public IActionResult Guncelle(int id)
        {
            idbulma = id;
            var crb=ktgrcrb.Guncelle(id);

           
            return View("Guncelle",crb);
        }
      
        [HttpPost]
        public IActionResult GuncelleYap(TblDbCorba tblDbCorba, IFormFile file)
        {
            var imagePath =tblDbCorba.CorbaResim; 

            if (file != null) 
            {
                imagePath = "../Content/Resimler/" + Resim.UploadImage(file); 
            }

            ktgrcrb.GuncelleYap(tblDbCorba, idbulma, imagePath);

            return RedirectToAction("Index2");
        }




    }

}
