using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Ctsp
{
    public int Mactsp { get; set; }

    public int Math { get; set; }

    public int Mams { get; set; }

    public int Masp { get; set; }

    public int Maxx { get; set; }

    public int Makc { get; set; }

    public int Soluong { get; set; }

    public bool? Trangthai { get; set; }

    public virtual Kichco MakcNavigation { get; set; } = null!;

    public virtual Mausac MamsNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;

    public virtual Thuonghieu MathNavigation { get; set; } = null!;
}
