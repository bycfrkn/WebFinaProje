using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbIcecekler
{
    public int IcecekId { get; set; }

    public string? IcecekAd { get; set; }

    public int? IcecekFiyat { get; set; }

    public string? IcecekResim { get; set; }
}
