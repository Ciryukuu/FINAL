using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Mausacrepostory
    {
        ConchosuameomeoContext context;
        public Mausacrepostory()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Mausac> getallms()
        {
            return context.Mausacs.ToList();
        }
        public bool themms(Mausac ms)
        {
            if (ms != null)
            {
                context.Mausacs.Add(ms);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool suams(Mausac ms)
        {
            if (ms != null)
            {
                context.Mausacs.Update(ms);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
