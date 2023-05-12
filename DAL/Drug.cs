using System;
using System.Collections.Generic;

namespace DAL;

public partial class Drug
{
    public int DrugId { get; set; }

    public string StorageRules { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public int? AssortimentId { get; set; }

    public virtual ICollection<ActiveSubstInDrug> ActiveSubstInDrugs { get; set; } = new List<ActiveSubstInDrug>();

    public virtual Good? Assortiment { get; set; }

    public virtual ICollection<CategoriesOfDrug> CategoriesOfDrugs { get; set; } = new List<CategoriesOfDrug>();
}
