using Microsoft.AspNetCore.Http;
using services.ModelsS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
    public class Corbaservice
    {
        MvcDbYemekSitesiContext _context = new MvcDbYemekSitesiContext();
        public List<TblDbCorba> GetTblkategorilers()
        {
            var list = _context.TblDbCorbas.ToList();
            var result = new List<TblDbCorba>();
            foreach (var item in list)
            {
                var vm = new TblDbCorba();
                vm.CorbaAd = item.CorbaAd;
                vm.CorbaId = item.CorbaId;
                vm.CorbaFiyat = item.CorbaFiyat;
                vm.CorbaResim = item.CorbaResim;
                result.Add(vm);

            }
            return result;
        }

    
        public void olustur(TblDbCorba dbCorba,string imahepath)
        {
        

            TblDbCorba tblDbCorba=new TblDbCorba();
            tblDbCorba.CorbaId=dbCorba.CorbaId;
            tblDbCorba.CorbaAd=dbCorba.CorbaAd;
            tblDbCorba.CorbaFiyat=dbCorba.CorbaFiyat;
            tblDbCorba.CorbaResim=imahepath.Trim();
            _context.TblDbCorbas.Add(tblDbCorba);
            _context.SaveChanges();



        }

        public void Sil(int id)
        {
           var vm=_context.TblDbCorbas.Find(id);
            _context.TblDbCorbas.Remove(vm);
            _context.SaveChanges();
 
        }

        public object? Guncelle(int id)
        {
            var vm = _context.TblDbCorbas.Find(id);
            TblDbCorba db = new TblDbCorba();
            db.CorbaId = vm.CorbaId;
            db.CorbaAd = vm.CorbaAd;
            db.CorbaFiyat= vm.CorbaFiyat;
            db.CorbaResim = vm.CorbaResim;

            return db;
           
        }

        public void GuncelleYap(TblDbCorba db,int id, string imahepath)
        {

            var vm = _context.TblDbCorbas.Find(id);
            vm.CorbaId = id;
            vm.CorbaAd= db.CorbaAd;
            vm.CorbaFiyat= db.CorbaFiyat;
            vm.CorbaResim = imahepath;
           
            _context.SaveChanges();

            

        }
        




    }
}
