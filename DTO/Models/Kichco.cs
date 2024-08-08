using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Kichco
{
    public int Makc { get; set; }

    public double Kichco1 { get; set; }

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
