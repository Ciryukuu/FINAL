using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HDCTservice
    {
        HDCTreponsitory cthdrepos;
        public HDCTservice()
        {
            cthdrepos = new HDCTreponsitory();
        }
        public List<Cthd> GetCthds()
        {
            return cthdrepos.GetallCthds();
        }
        public void Add(Cthd cthd)
        {
            if (GetCthds().Any(x => x.MaCthd == cthd.MaCthd && x.MaHd == cthd.MaHd))
            {
                var updateCTHD = cthdrepos.GetallCthds().First(x => x.MaCthd == cthd.MaCthd && x.MaHd == cthd.MaHd); //3-8-2024
                updateCTHD.Soluong++;
                cthdrepos.SuaCTHD(updateCTHD);
            }
            else
            {
                cthd.Soluong = 1;
                cthdrepos.Themcthd(cthd);
            }

        }
        public void Remove(Cthd cthd)
        {
            if (cthd != null)
            {
                cthdrepos.XoaCTHD(cthd);
            }
        }
    }
}
