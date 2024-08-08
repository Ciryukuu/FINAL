using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Sanpham
{
    public int Masp { get; set; }

    public string Tensp { get; set; } = null!;

    public decimal Gia { get; set; }

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
