using System;
using System.Collections.Generic;

namespace services.ModelsS;

public partial class TblDbIzgara
{
    public int IzgaraId { get; set; }

    public string? IzgaraAd { get; set; }

    public int? IzgaraFiyat { get; set; }

    public string? IzgaraResim { get; set; }
}
