using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Sanphamservice
    {
        sanphamrepository sprepos;
        public Sanphamservice()
        {
            sprepos = new sanphamrepository();
        }
        public List<Sanpham>GetSanphams()
        {
            return sprepos.getallsp();
        }
        public string addsp(Sanpham sp)
        {
            if (sprepos.themsp(sp))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatesp(Sanpham sp)
        {
            if (sprepos.capnhapsp(sp))
            {
                return "Sửa  thành công";
            }
            return "Sửa thất bại";
        }
    }
}
