using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CTSPrepository
    {
        ConchosuameomeoContext context;
        public CTSPrepository()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Ctsp>getallctsp()
        {
            return context.Ctsps.ToList();
        }
        public bool themct(Ctsp ct)
        {
            if (ct != null)
            {
                context.Ctsps.Add(ct);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapct(Ctsp ct)
        {
            if (ct != null)
            {
                context.Ctsps.Update(ct);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
