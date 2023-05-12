using System;
using System.Collections.Generic;

namespace DAL;

public partial class ActiveSubstance
{
    public int SubstanceId { get; set; }

    public string SubstanceName { get; set; } = null!;

    public string RouteIntoBloodstream { get; set; } = null!;

    public int SubstInDrugId { get; set; }

    public int DrugsId { get; set; }

    public virtual ActiveSubstInDrug ActiveSubstInDrug { get; set; } = null!;
}
