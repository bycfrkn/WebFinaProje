using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbKullanici
{
    public int KullaniciId { get; set; }

    public string? KullaniciAd { get; set; }

    public string? KullaniciSoyad { get; set; }

    public string? KullaniciEmail { get; set; }

    public string? KullaniciSifre { get; set; }
}
