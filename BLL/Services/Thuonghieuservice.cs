using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Thuonghieuservice
    {
        Thuonghieurepository threpos;
        public Thuonghieuservice()
        {
            threpos = new Thuonghieurepository();
        }
        public List<Thuonghieu>GetThuonghieus()
        {
            return threpos.getallth();
        }
        public string addth(Thuonghieu th)
        {
            if (threpos.themth(th))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updateth(Thuonghieu th)
        {
            if (threpos.suath(th))
            {
                return "Sửa  thành công";
            }
            return "Sửa thất bại";
        }
    }
}
