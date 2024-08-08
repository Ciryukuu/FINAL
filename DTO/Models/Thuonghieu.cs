using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Thuonghieu
{
    public int Math { get; set; }

    public string Tenth { get; set; } = null!;

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
