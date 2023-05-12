using System;
using System.Collections.Generic;

namespace DAL;

public partial class Pharmacist
{
    public int PharmacistId { get; set; }

    public string Diploma { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public double Salary { get; set; }

    public string Passport { get; set; } = null!;

    public int Tin { get; set; }

    public string Telephone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Insurance { get; set; } = null!;

    public int? Ogrn { get; set; }

    public int? BuysId { get; set; }

    public virtual Purchase1? Buys { get; set; }

    public virtual Pharmacy? OgrnNavigation { get; set; }
}
