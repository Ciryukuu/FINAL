using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public  class Xuatxuservice
    {
        Xuatxurepository xxrepos;
        public Xuatxuservice()
        {
            xxrepos = new Xuatxurepository();
        }
        public List<Xuatxu> GetXuatxus()
        {
            return xxrepos.getallxx();
        }
        public string addxx(Xuatxu xx)
        {
            if (xxrepos.themxx(xx))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatexx(Xuatxu xx)
        {
            if (xxrepos.suaxx(xx))
            {
                return "Sửa  thành công";
            }
            return "Sửa thất bại";
        }
    }
}
