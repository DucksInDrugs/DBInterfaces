using System;
using System.Collections.Generic;

namespace DAL;

public partial class Purchase1
{
    public int BuysId { get; set; }

    public double TotalCost { get; set; }

    public DateTime PurchaseTime { get; set; }

    public double? Discount { get; set; }

    public int? HavingAmount { get; set; }

    public virtual ICollection<Pharmacist> Pharmacists { get; set; } = new List<Pharmacist>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
