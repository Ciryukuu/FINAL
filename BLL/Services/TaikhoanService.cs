using DAL.Repositories;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TaikhoanService
    {
        TaikhoanRepository _repostk;
        public TaikhoanService()
        {
            _repostk = new TaikhoanRepository();
        }
        public List<Taikhoan> GetTaikhoans()
        {
            return _repostk.GetAllTaiKhoan();
        }

        public bool Login(string username, string password)
        {
            var taikhoan = _repostk.GetTaikhoan(username, password);
            return taikhoan != null;
        }

        public string CheckLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username và mật khẩu không được để trống.";
            }

            var taikhoan = _repostk.GetTaikhoan(username, password);
            if (taikhoan != null)
            {
                return "Đăng nhập thành công";
            }
            return "Sai tài khoản hoặc mật khẩu";
        }

        public string QuenMk(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username không được để trống.";
            }

            if (_repostk.UpdateTaikhoan(username))
            {
                var taikhoan = _repostk.GetTaikhoanByUsername(username);
                if (taikhoan != null)
                {
                    return "Mật khẩu mới của bạn là: " + taikhoan.Passwords;
                }
            }
            return "Không tìm thấy tài khoản.";
        }

        public string ThemTK(Taikhoan tk)
        {
            if (_repostk.AddToTK(tk))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string SuaTK(Taikhoan tk)
        {
            if (_repostk.UpdateToTK(tk))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public int GetIDTaiKhoan(string matk)
        {
            return _repostk.GetTaiKID(matk);
        }
    }
}
