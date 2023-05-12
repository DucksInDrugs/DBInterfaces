using System;
using System.Collections.Generic;

namespace DAL;

public partial class CategoriesOfDrug
{
    public int CategoryId { get; set; }

    public string DrugsClassification { get; set; } = null!;

    public int? DrugId { get; set; }

    public virtual Drug? Drug { get; set; }
}
