using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HoaDonservice
    {
        HoaDonReponsitory hdrepos;
        public HoaDonservice()
        {
            hdrepos = new HoaDonReponsitory();
        }

        public List<Hoadon> GetHoadons()
        {
            return hdrepos.GetallHoadons();
        }
        public string addhd(Hoadon hd)
        {
            if (hdrepos.Themhd(hd))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatehd(Hoadon hd)
        {
            if (hdrepos.Suahd(hd))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string removehd(Hoadon hd)
        {
            if (hdrepos.Xoahd(hd))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
