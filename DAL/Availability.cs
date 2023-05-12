using System;
using System.Collections.Generic;

namespace DAL;

public partial class Availability
{
    public int Amount { get; set; }

    public int AssortimentId { get; set; }

    public int Ogrn { get; set; }

    public virtual Good Assortiment { get; set; } = null!;

    public virtual Pharmacy OgrnNavigation { get; set; } = null!;
}
