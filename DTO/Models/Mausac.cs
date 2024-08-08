using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Mausac
{
    public int Mams { get; set; }

    public string Tenms { get; set; } = null!;

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
