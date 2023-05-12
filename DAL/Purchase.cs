using System;
using System.Collections.Generic;

namespace DAL;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public int? GoodId { get; set; }

    public int Amount { get; set; }

    public int? BuyId { get; set; }

    public virtual Purchase1? Buy { get; set; }

    public virtual Good? Good { get; set; }
}
