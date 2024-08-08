using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonReponsitory
    {
        ConchosuameomeoContext context;
        public HoaDonReponsitory()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Hoadon> GetallHoadons()
        {
            return context.Hoadons.ToList();
        }
        public bool Themhd(Hoadon hd)
        {
            if (hd != null)
            {
                context.Hoadons.Add(hd);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Suahd(Hoadon hd)
        {
            if (hd != null)
            {
                context.Hoadons.Update(hd);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Xoahd(Hoadon hd)
        {
            if (hd != null)
            {
                context.Hoadons.Remove(hd);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
