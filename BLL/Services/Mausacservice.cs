using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Mausacservice
    {
        Mausacrepostory msrepos;
        public Mausacservice()
        {
            msrepos = new Mausacrepostory();
        }
        public List<Mausac>GetMausacs()
        {
            return msrepos.getallms();
        }
        public string addms(Mausac ms)
        {
            if (msrepos.themms(ms))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatems(Mausac ms)
        {
            if (msrepos.suams(ms))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
