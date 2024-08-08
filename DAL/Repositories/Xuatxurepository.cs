using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public  class Xuatxurepository
    {
        ConchosuameomeoContext context;
        public Xuatxurepository()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Xuatxu> getallxx()
        {
            return context.Xuatxus.ToList();
        }
        public bool themxx(Xuatxu xx)
        {
            if (xx != null)
            {
                context.Xuatxus.Add(xx);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool suaxx(Xuatxu xx)
        {
            if (xx != null)
            {
                context.Xuatxus.Update(xx);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
