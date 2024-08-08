using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Taikhoan
{
    public int MaTk { get; set; }

    public string Username { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public bool? Trangthai { get; set; }

    public string Createby { get; set; } = null!;

    public string Updateby { get; set; } = null!;

    public DateTime? Createat { get; set; }

    public DateTime? Updateat { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
