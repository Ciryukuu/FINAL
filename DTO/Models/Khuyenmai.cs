using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Khuyenmai
{
    public int Makm { get; set; }

    public string Tenkm { get; set; } = null!;

    public DateTime Ngaytao { get; set; }

    public DateTime Ngaydung { get; set; }

    public string Phantramgiam { get; set; } = null!;

    public DateTime Ngaykt { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
