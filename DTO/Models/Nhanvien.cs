using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Nhanvien
{
    public int Manv { get; set; }

    public string Tennv { get; set; } = null!;

    public bool? Gioitinh { get; set; }

    public DateTime Ngaysinh { get; set; }

    public string Quoctich { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string Vaitro { get; set; } = null!;

    public int Matk { get; set; }

    public string Createby { get; set; } = null!;

    public string Updateby { get; set; } = null!;

    public DateTime? Createat { get; set; }

    public DateTime? Updateat { get; set; }

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Taikhoan MatkNavigation { get; set; } = null!;
}
