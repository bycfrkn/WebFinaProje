using services.ModelsS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
   public class Tatliservices
{

        MvcDbYemekSitesiContext _context = new MvcDbYemekSitesiContext();
        public List<TblDbTatli> GetTblkategorilers()
        {
            var list = _context.TblDbTatlis.ToList();
            var result = new List<TblDbTatli>();
            foreach (var item in list)
            {
                var vm = new TblDbTatli();
               vm.TatliAd=item.TatliAd;
                vm.TatliId=item.TatliId;
                vm.TatliFiyat=item.TatliFiyat;
                vm.TatliResim=item.TatliResim;
                result.Add(vm);

            }
            return result;
        }
        public void olustur(TblDbTatli dbtatli, string imagepath)
        {

            TblDbTatli tblDbTatli = new TblDbTatli();
           
            tblDbTatli.TatliId=dbtatli.TatliId;
            tblDbTatli.TatliAd=dbtatli.TatliAd;
            tblDbTatli.TatliResim = imagepath;
            tblDbTatli.TatliFiyat = dbtatli.TatliFiyat;
            _context.TblDbTatlis.Add(tblDbTatli);
            _context.SaveChanges();



        }

        public void Sil(int id)
        {
            var vm = _context.TblDbTatlis.Find(id);
            _context.TblDbTatlis.Remove(vm);
            _context.SaveChanges();

        }

        public object? Guncelle(int id)
        {
            var vm = _context.TblDbTatlis.Find(id);
            TblDbTatli db = new TblDbTatli();
            db.TatliId = vm.TatliId;
            db.TatliAd = vm.TatliAd;
            db.TatliFiyat = vm.TatliFiyat;
            db.TatliResim = vm.TatliResim;
            

            return db;

        }

        public void GuncelleYap(TblDbTatli db, int id, string imahepath)
        {

            var vm = _context.TblDbTatlis.Find(id);
            vm.TatliId = id;
            vm.TatliAd = db.TatliAd;
            vm.TatliFiyat = db.TatliFiyat;
            vm.TatliResim = imahepath;

            _context.SaveChanges();



        }


    }
}

