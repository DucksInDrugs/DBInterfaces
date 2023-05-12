using System;
using System.Collections.Generic;

namespace DAL;

public partial class ActiveSubstInDrug
{
    public int SubstInDrugId { get; set; }

    public int DrugId { get; set; }

    public double Dosage { get; set; }

    public virtual ICollection<ActiveSubstance> ActiveSubstances { get; set; } = new List<ActiveSubstance>();

    public virtual Drug Drug { get; set; } = null!;
}
