using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Kichthuocrepository
    {
        ConchosuameomeoContext context;
        public Kichthuocrepository()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Kichco> getallkc()
        {
            return context.Kichcos.ToList();
        }
        public bool themkc(Kichco kc)
        {
            if (kc != null)
            {
                context.Kichcos.Add(kc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool suakc(Kichco kc)
        {
            if (kc != null)
            {
                context.Kichcos.Update(kc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
