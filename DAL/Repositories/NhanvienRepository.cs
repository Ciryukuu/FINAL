using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanvienRepository
    {
        ConchosuameomeoContext _contextnv;
        public NhanvienRepository()
        {
            _contextnv = new ConchosuameomeoContext();
        }
        public List<Nhanvien> GetAllNhanVien()
        {
            return _contextnv .Nhanviens.ToList();
        }

        public bool AddNhanVien(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            _contextnv.Nhanviens.Add(nv);
            _contextnv.SaveChanges();
            return true;
        }

        public bool UpdateNhanVien(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            _contextnv.Nhanviens.Update(nv);
            _contextnv.SaveChanges();
            return true;
        }

        // Additional methods for role management
        public Nhanvien GetNhanVienById(int id)
        {
            return _contextnv.Nhanviens.FirstOrDefault(n => n.Manv == id);
        }

        public bool DeleteNhanVien(int id)
        {
            var nv = GetNhanVienById(id);
            if (nv == null)
            {
                return false;
            }
            _contextnv.Nhanviens.Remove(nv);
            _contextnv.SaveChanges();
            return true;
        }

        public List<Nhanvien> GetNhanViensByRole(string role)
        {
            return _contextnv.Nhanviens.Where(n => n.Vaitro == role).ToList();
        }

        public bool AssignRole(int id, string role)
        {
            var nv = GetNhanVienById(id);
            if (nv == null)
            {
                return false;
            }
            nv.Vaitro = role;
            _contextnv.Nhanviens.Update(nv);
            _contextnv.SaveChanges();
            return true;
        }

        public bool IsAdmin(int id)
        {
            var nv = GetNhanVienById(id);
            return nv != null && nv.Vaitro == "Admin";
        }

        public bool IsEmployee(int id)
        {
            var nv = GetNhanVienById(id);
            return nv != null && nv.Vaitro == "Nhân viên";
        }
    }
}
