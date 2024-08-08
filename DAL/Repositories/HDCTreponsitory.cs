using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HDCTreponsitory
    {
        ConchosuameomeoContext context;
        public HDCTreponsitory()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Cthd> GetallCthds()
        {
            return context.Cthds.ToList();
        }
        public bool Themcthd(Cthd cthd)
        {
            if (cthd != null)
            {
                context.Cthds.Add(cthd);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SuaCTHD(Cthd cthd)
        {
            if (cthd != null)
            {
                context.Cthds.Update(cthd);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaCTHD(Cthd cthd)
        {
            if (cthd != null)
            {
                context.Cthds.Remove(cthd);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
