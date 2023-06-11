using services.ModelsS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
    public class Iceceksevices
{
        MvcDbYemekSitesiContext _context = new MvcDbYemekSitesiContext();
        public List<TblDbIcecekler> GetTblkategorilers()
        {
            var list = _context.TblDbIceceklers.ToList();
            var result = new List<TblDbIcecekler>();
            foreach (var item in list)
            {
                var vm = new TblDbIcecekler();
                vm.IcecekId = item.IcecekId;
                vm.IcecekAd= item.IcecekAd;
                vm.IcecekFiyat = item.IcecekFiyat;
                vm.IcecekResim = item.IcecekResim;
                result.Add(vm);

            }
            return result;
        }
        public void olustur(TblDbIcecekler dbIcecekler,string imagepath)
        {

            TblDbIcecekler tblDbIcecekler = new TblDbIcecekler();
            tblDbIcecekler.IcecekId = dbIcecekler.IcecekId;
            tblDbIcecekler.IcecekAd = dbIcecekler.IcecekAd;
            tblDbIcecekler.IcecekFiyat = dbIcecekler.IcecekFiyat;
            tblDbIcecekler.IcecekResim = imagepath;
            _context.TblDbIceceklers.Add(tblDbIcecekler);
            _context.SaveChanges();



        }

        public void Sil(int id)
        {
            var vm = _context.TblDbIceceklers.Find(id);
            _context.TblDbIceceklers.Remove(vm);
            _context.SaveChanges();

        }

        public object? Guncelle(int id)
        {
            var vm = _context.TblDbIceceklers.Find(id);
            TblDbIcecekler db = new TblDbIcecekler();
            db.IcecekId = vm.IcecekId;
            db.IcecekAd = vm.IcecekAd;
            db.IcecekResim = vm.IcecekResim;
            db.IcecekFiyat = vm.IcecekFiyat;

            return db;

        }

        public void GuncelleYap(TblDbIcecekler db, int id, string imahepath)
        {

            var vm = _context.TblDbIceceklers.Find(id);
            vm.IcecekId = id;
            vm.IcecekAd = db.IcecekAd;
            vm.IcecekResim = imahepath;
            vm.IcecekFiyat = db.IcecekFiyat;

            _context.SaveChanges();



        }
    }
}
