using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Cthd
{
    public int MaCthd { get; set; }

    public int MaHd { get; set; }

    public int Masp { get; set; }

    public int Manv { get; set; }

    public int Soluong { get; set; }

    public bool? Trangthai { get; set; }

    public string Createby { get; set; } = null!;

    public string Updateby { get; set; } = null!;

    public DateTime? Createat { get; set; }

    public DateTime? Updateat { get; set; }

    public virtual Hoadon MaHdNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
