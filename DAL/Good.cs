using System;
using System.Collections.Generic;

namespace DAL;

public partial class Good
{
    public int AssortimentId { get; set; }

    public double Cost { get; set; }

    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();

    public virtual ICollection<Drug> Drugs { get; set; } = new List<Drug>();

    public virtual ICollection<MedicalDevice> MedicalDevices { get; set; } = new List<MedicalDevice>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
