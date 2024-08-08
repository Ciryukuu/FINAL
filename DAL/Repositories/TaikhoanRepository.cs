using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TaikhoanRepository
    {
        ConchosuameomeoContext _contexttk;
        public TaikhoanRepository()
        {
            _contexttk = new ConchosuameomeoContext();
        }
        public List<Taikhoan> GetAllTaiKhoan()
        {
            return _contexttk.Taikhoans.ToList();
        }

        public Taikhoan GetTaikhoan(string username, string password)
        {
            return _contexttk.Taikhoans.FirstOrDefault(p => p.Username == username && p.Passwords == password);
        }

        public Taikhoan GetTaikhoanByUsername(string username)
        {
            return _contexttk.Taikhoans.FirstOrDefault(p => p.Username == username);
        }

        public bool IsUserFound(string username, string password)
        {
            return _contexttk.Taikhoans.Any(x => x.Username == username && x.Passwords == password);
        }

        public bool UpdateTaikhoan(string username)
        {
            var taikhoan = GetTaikhoanByUsername(username);
            if (taikhoan == null)
            {
                return false;
            }

            // Tạo mật khẩu mới có 6 kí tự
            const string chars = "ABCDEFGH";
            var random = new Random();
            string newPassword = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            taikhoan.Passwords = newPassword;
            _contexttk.Taikhoans.Update(taikhoan);
            _contexttk.SaveChanges(); // Lưu lại những thay đổi
            return true;
        }

        public bool AddToTK(Taikhoan tk)
        {
            if (tk != null)
            {
                _contexttk.Taikhoans.Add(tk);
                _contexttk.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateToTK(Taikhoan tk)
        {
            if (tk != null)
            {
                _contexttk.Taikhoans.Update(tk);
                _contexttk.SaveChanges();
                return true;
            }
            return false;
        }

        public int GetTaiKID(string matk)
        {
            return _contexttk.Taikhoans.FirstOrDefault(x => x.MaTk.Equals(matk)).MaTk;
        }
    }
}
