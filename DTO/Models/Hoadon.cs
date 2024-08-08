using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Hoadon
{
    public int MaHd { get; set; }

    public int Manv { get; set; }

    public DateTime Ngaymua { get; set; }

    public double Gia { get; set; }

    public int MaKm { get; set; }

    public double Thanhtien { get; set; }

    public string Createby { get; set; } = null!;

    public string Updateby { get; set; } = null!;

    public DateTime? Createat { get; set; }

    public DateTime? Updateat { get; set; }

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual Khuyenmai MaKmNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
