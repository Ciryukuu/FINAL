using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class sanphamrepository
    {
        ConchosuameomeoContext context;
        public sanphamrepository()
        {
            context = new ConchosuameomeoContext();
        }
        public List<Sanpham>getallsp()
        {
            return context.Sanphams.ToList();
        }
        public bool themsp(Sanpham sp)
        {
            if(sp!= null)
            {
                context.Sanphams.Add(sp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapsp(Sanpham sp)
        {
            if (sp != null)
            {
                context.Sanphams.Update(sp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
