using System;
using System.Collections.Generic;

namespace DAL;

public partial class MedicalDevice
{
    public int DeviceId { get; set; }

    public string DeviceType { get; set; } = null!;

    public string DeviceName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int AssortimentId { get; set; }

    public virtual Good Assortiment { get; set; } = null!;
}
