using Microsoft.EntityFrameworkCore;
using services.ModelsS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevice.@class
{
    public class Kayitservices
{
        MvcDbYemekSitesiContext _context=new MvcDbYemekSitesiContext();

       public void olustur(TblDbKullanici tblDbKullanici)
        {
            TblDbKullanici tbl = new TblDbKullanici();
             tbl.KullaniciAd = tblDbKullanici.KullaniciAd;
            tbl.KullaniciSoyad = tblDbKullanici.KullaniciSoyad;
            tbl.KullaniciEmail = tblDbKullanici.KullaniciEmail;
            tbl.KullaniciSifre = tblDbKullanici.KullaniciSifre;
            _context.TblDbKullanicis.Add(tbl);
            _context.SaveChanges();



            }


        public object? kontrol(TblDbKullanici tblDbKullanicii)
        {
            var f = _context.TblDbKullanicis;
            foreach (var dnm in f)
            {
                if (dnm.KullaniciEmail == tblDbKullanicii.KullaniciEmail && dnm.KullaniciAd == tblDbKullanicii.KullaniciAd && dnm.KullaniciSifre == tblDbKullanicii.KullaniciSifre)
                {
                    tblDbKullanicii.KullaniciId = dnm.KullaniciId;
                    tblDbKullanicii.KullaniciSoyad = dnm.KullaniciSoyad;
                    tblDbKullanicii.KullaniciEmail = dnm.KullaniciEmail;
                    tblDbKullanicii.KullaniciAd = dnm.KullaniciAd;
                    tblDbKullanicii.KullaniciSifre = dnm.KullaniciSifre;
                    break;
                }

               
            }

            return tblDbKullanicii;

        }

        public bool giris(TblDbKullanici tblDbKullanicii)
        {
            

        var gtr=_context.TblDbKullanicis.Find(tblDbKullanicii.KullaniciId);

            if (gtr != null)
            {
              
                    return true;
                }
                else
                {
                    return false;
                }
       

           

        }


    }




}
