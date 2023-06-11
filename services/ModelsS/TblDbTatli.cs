using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbTatli
{
    public int TatliId { get; set; }

    public string? TatliAd { get; set; }

    public int? TatliFiyat { get; set; }

    public string? TatliResim { get; set; }
}
