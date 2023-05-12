using System;
using System.Collections.Generic;

namespace DAL;

public partial class DrugsAssortimentView
{
    public int Amount { get; set; }

    public int AssortimentId { get; set; }

    public int Ogrn { get; set; }

    public double Cost { get; set; }

    public int DrugId { get; set; }

    public string Manufacturer { get; set; } = null!;
}
