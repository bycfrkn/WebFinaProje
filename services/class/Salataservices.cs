using services.ModelsS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
    public class Salataservices
    {
       
            MvcDbYemekSitesiContext _context = new MvcDbYemekSitesiContext();
            public List<TblDbSalatum> GetTblkategorilers()
            {
                var list = _context.TblDbSalata.ToList();
                var result = new List<TblDbSalatum>();
                foreach (var item in list)
                {
                    var vm = new TblDbSalatum();
                vm.SalataId = item.SalataId;
                vm.SalataFiyat = item.SalataFiyat;
                 vm.SalataAd= item.SalataAd;    
                vm.SalataResim= item.SalataResim;
                    result.Add(vm);

                }
                return result;
            }
        public void olustur(TblDbSalatum tbldb, string imagepath)
        {

            TblDbSalatum tblDbSalatum = new TblDbSalatum();
            tblDbSalatum.SalataId = tbldb.SalataId;
            tblDbSalatum.SalataAd= tbldb.SalataAd;
            tblDbSalatum.SalataFiyat = tbldb.SalataFiyat;
            tblDbSalatum.SalataResim = imagepath;
            _context.TblDbSalata.Add(tblDbSalatum);
            _context.SaveChanges();



        }

        public void Sil(int id)
        {
            var vm = _context.TblDbSalata.Find(id);
            _context.TblDbSalata.Remove(vm);
            _context.SaveChanges();

        }

        public object? Guncelle(int id)
        {
            var vm = _context.TblDbSalata.Find(id);
           TblDbSalatum db = new TblDbSalatum();
            db.SalataId = vm.SalataId;
            db.SalataAd = vm.SalataAd;
            db.SalataResim = vm.SalataResim;
            db.SalataFiyat = vm.SalataFiyat;

            return db;

        }

        public void GuncelleYap(TblDbSalatum db, int id, string imahepath)
        {

            var vm = _context.TblDbSalata.Find(id);
            vm.SalataId = id;
            vm.SalataAd= db.SalataAd;
            vm.SalataFiyat = db.SalataFiyat;
            vm.SalataResim = imahepath;

            _context.SaveChanges();



        }

    }
    }
