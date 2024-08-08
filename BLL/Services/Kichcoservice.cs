using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Kichcoservice
    {
        Kichthuocrepository kcrepos;
        public Kichcoservice()
        {
            kcrepos = new Kichthuocrepository();
        }
        public List<Kichco> GetKichcos()
        {
            return kcrepos.getallkc();
        }
        public string addkc(Kichco kc)
        {
            if (kcrepos.themkc(kc))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatekc(Kichco kc)
        {
            if (kcrepos.suakc(kc))
            {
                return "Sửa  thành công";
            }
            return "Sửa thất bại";
        }
    }
}   
