using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Giohang
{
    public int Magiohang { get; set; }

    public string Tensp { get; set; } = null!;

    public double Kichco { get; set; }

    public string Mausac { get; set; } = null!;

    public int Soluong { get; set; }

    public decimal Gia { get; set; }
}
