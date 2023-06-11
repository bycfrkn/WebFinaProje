using services.ModelsS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
   public class Izgaraservices
{



        MvcDbYemekSitesiContext _context = new MvcDbYemekSitesiContext();
        public List<TblDbIzgara> GetTblkategorilers()
        {
            var list = _context.TblDbIzgaras.ToList();
            var result = new List<TblDbIzgara>();
            foreach (var item in list)
            {
                var vm = new TblDbIzgara();
                vm.IzgaraId = item.IzgaraId;
                vm.IzgaraAd= item.IzgaraAd;
                vm.IzgaraFiyat = item.IzgaraFiyat;
                vm.IzgaraResim = item.IzgaraResim;
                result.Add(vm);

            }
            return result;
        }
        public void olustur(TblDbIzgara dbIzgara, string imagepath)
        {

            TblDbIzgara tblDbIzgara = new TblDbIzgara();
            tblDbIzgara.IzgaraId = dbIzgara.IzgaraId;
            tblDbIzgara.IzgaraAd = dbIzgara.IzgaraAd;
            tblDbIzgara.IzgaraFiyat = dbIzgara.IzgaraFiyat;
            tblDbIzgara.IzgaraResim = imagepath;
            _context.TblDbIzgaras.Add(tblDbIzgara);
            _context.SaveChanges();



        }

        public void Sil(int id)
        {
            var vm = _context.TblDbIzgaras.Find(id);
            _context.TblDbIzgaras.Remove(vm);
            _context.SaveChanges();

        }

        public object? Guncelle(int id)
        {
            var vm = _context.TblDbIzgaras.Find(id);
            TblDbIzgara db = new TblDbIzgara();
            db.IzgaraId = vm.IzgaraId;
            db.IzgaraAd = vm.IzgaraAd;
            db.IzgaraFiyat = vm.IzgaraFiyat;
            db.IzgaraResim = vm.IzgaraResim;

            return db;

        }

        public void GuncelleYap(TblDbIzgara db, int id, string imahepath)
        {

            var vm = _context.TblDbIzgaras.Find(id);
            vm.IzgaraId= id;
            vm.IzgaraAd = db.IzgaraAd;
            vm.IzgaraFiyat = db.IzgaraFiyat;
            vm.IzgaraResim = imahepath;

            _context.SaveChanges();



        }
    }
}
