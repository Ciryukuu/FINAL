using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NhanvienService
    {
        NhanvienRepository _reposnv;
        public NhanvienService()
        {
            _reposnv = new NhanvienRepository();
        }
        public List<Nhanvien> GetAllNhanviens()
        {
            return _reposnv.GetAllNhanVien();
        }

        public string AddNhanVien(Nhanvien nhanvien)
        {
            if (_reposnv.AddNhanVien(nhanvien))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string UpdateNhanVien(Nhanvien nhanvien)
        {
            if (_reposnv.UpdateNhanVien(nhanvien))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        // Additional methods
        public Nhanvien GetNhanVienById(int id)
        {
            return _reposnv.GetNhanVienById(id);
        }

        public string DeleteNhanVien(int id)
        {
            if (_reposnv.DeleteNhanVien(id))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public List<Nhanvien> GetNhanViensByRole(string role)
        {
            return _reposnv.GetNhanViensByRole(role);
        }

        public string AssignRole(int id, string role)
        {
            if (_reposnv.AssignRole(id, role))
            {
                return "Gán quyền thành công";
            }
            else
            {
                return "Gán quyền thất bại";
            }
        }

        public bool IsAdmin(int id)
        {
            return _reposnv.IsAdmin(id);
        }

        public bool IsEmployee(int id)
        {
            return _reposnv.IsEmployee(id);
        }
    }
}
