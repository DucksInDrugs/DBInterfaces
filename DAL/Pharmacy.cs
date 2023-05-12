using System;
using System.Collections.Generic;

namespace DAL;

public partial class Pharmacy
{
    public int Ogrn { get; set; }

    public string Direction { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();

    public virtual ICollection<Pharmacist> Pharmacists { get; set; } = new List<Pharmacist>();
}
