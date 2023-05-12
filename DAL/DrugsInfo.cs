using System;
using System.Collections.Generic;

namespace DAL;

public partial class DrugsInfo
{
    public int DrugId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string DrugsClassification { get; set; } = null!;

    public double Dosage { get; set; }

    public string SubstanceName { get; set; } = null!;

    public string RouteIntoBloodstream { get; set; } = null!;
}
