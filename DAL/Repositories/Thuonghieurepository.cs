using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public  class Thuonghieurepository
    {
        ConchosuameomeoContext context;
        public Thuonghieurepository()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Thuonghieu> getallth()
        {
            return context.Thuonghieus.ToList();
        }
        public bool themth(Thuonghieu th)
        {
            if (th == null)
            {
              return false;
            }
            context.Thuonghieus.Add(th);
            context.SaveChanges();
            return true;
        }
        public bool suath(Thuonghieu th)
        {
            if (th != null)
            {
                context.Thuonghieus.Update(th);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
