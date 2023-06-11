using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbCorba
{
    public int CorbaId { get; set; }

    public string? CorbaAd { get; set; }

    public int? CorbaFiyat { get; set; }

    public string? CorbaResim { get; set; }
}
