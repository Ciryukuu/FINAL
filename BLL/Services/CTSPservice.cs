using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CTSPservice
    {
        CTSPrepository ctrepos;
        public CTSPservice()
        {
            ctrepos = new CTSPrepository();
        }
        public List<Ctsp> GetCtsps()
        {
            return ctrepos.getallctsp();
        }
        public string addct(Ctsp ct)
        {
            if (ctrepos.themct(ct))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatect(Ctsp ct)
        {
            if (ctrepos.capnhapct(ct))
            {
                return "Sửa  thành công";
            }
            return "Sửa thất bại";
        }
    }
}
