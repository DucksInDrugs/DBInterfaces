using System;
using System.Collections.Generic;

namespace DAL;

public partial class PurchaseInfo
{
    public int PurchaseId { get; set; }

    public int Amount { get; set; }

    public int? GoodId { get; set; }

    public double Cost { get; set; }

    public int BuysId { get; set; }

    public DateTime PurchaseTime { get; set; }

    public double? Discount { get; set; }

    public double TotalCost { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;
}
