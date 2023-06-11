using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbSalatum
{
    public int SalataId { get; set; }

    public string? SalataAd { get; set; }

    public int? SalataFiyat { get; set; }

    public string? SalataResim { get; set; }
}
