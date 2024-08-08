using BLL.Services;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FINAL
{
    public partial class FormHoaDon : Form
    {
        Sanphamservice spservice = new Sanphamservice();
        Thuonghieuservice thservice;
        Mausacservice msservice;
        Kichcoservice kcservice;
        Xuatxuservice xxservice;
        HoaDonservice hdservice;
        HDCTservice hdctservice;
        CTSPservice ctspservice;
        TaikhoanService tkservice;
        int _IdHoaDonWhenClick;
        int _IdCTSPWhenClick;
        int _IdHDCTWhenClick;
        public FormHoaDon()
        {
            InitializeComponent();
            thservice = new Thuonghieuservice();
            msservice = new Mausacservice();
            kcservice = new Kichcoservice();
            xxservice = new Xuatxuservice();
            hdservice = new HoaDonservice();
            hdctservice = new HDCTservice();
            ctspservice = new CTSPservice();
            txtMaHD.Enabled = false;
            //LoadDataCTHD();
            LoadallHD();
        }
        public void LoadallHD()
        {
            int stt = 1;
            dataGridHD.ColumnCount = 7;
            dataGridHD.Columns[0].Name = "STT";
            dataGridHD.Columns[1].Name = "Mã Hóa đơn";
            dataGridHD.Columns[2].Name = "Mã NV";
            dataGridHD.Columns[3].Name = "Ngày mua";
            dataGridHD.Columns[4].Name = "Giá";
            dataGridHD.Columns[5].Name = "Mã KM";
            dataGridHD.Columns[6].Name = "Thành tiền";
            dataGridHD.Rows.Clear();
            foreach (var hd in hdservice.GetHoadons())
            {
                dataGridHD.Rows.Add(stt++, hd.MaHd, hd.Manv, hd.Ngaymua, hd.Gia, hd.MaKm, hd.Thanhtien == null ? 0.ToString() + " VND" : hd.Thanhtien + " VND");
            }
        }
        //public void LoadDataCTHD()
        //{
        //    int stt = 1;

        //    dataGrid_CTHD.ColumnCount = 11;
        //    dataGrid_CTHD.Columns[0].Name = "STT";
        //    dataGrid_CTHD.Columns[1].Name = "Mã hoá đơn";
        //    dataGrid_CTHD.Columns[2].Name = "Mã sản phẩm";
        //    dataGrid_CTHD.Columns[3].Name = "Tên sản phẩm ";
        //    dataGrid_CTHD.Columns[4].Name = "Số lượng ";
        //    dataGrid_CTHD.Columns[5].Name = "Giá";
        //    dataGrid_CTHD.Columns[6].Name = "Màu sắc";
        //    dataGrid_CTHD.Columns[7].Name = "Kích cỡ";
        //    dataGrid_CTHD.Columns[8].Name = "Thương hiệu";
        //    dataGrid_CTHD.Columns[9].Name = "Xuất xứ";
        //    dataGrid_CTHD.Columns[10].Name = "Thành Tiền";
        //    dataGrid_CTHD.Rows.Clear();

        //    var lstTH = thservice.GetThuonghieus();
        //    var lstMS = msservice.GetMausacs();
        //    var lstKT = kcservice.GetKichcos();
        //    var lstXX = xxservice.GetXuatxus();

        //    var lstCTSP = ctspservice.GetCtsps();
        //    var lstSP = spservice.GetSanphams();
        //    var lstHD = hdservice.GetHoadons();
        //    var lstHDCT = hdctservice.GetCthds();

        //    decimal? thanhtien = 0;
        //    var result = from hdct in lstHDCT
        //                 join hd in lstHD on hdct.MaHd equals hd.MaHd
        //                 join sp in lstSP on hdct.Masp equals sp.Masp
        //                 join ctsp in lstCTSP on sp.Masp equals ctsp.Masp
        //                 join kc in lstKT on ctsp.Makc equals kc.Makc
        //                 join ms in lstMS on ctsp.Mams equals ms.Mams
        //                 join th in lstTH on ctsp.Math equals th.Math
        //                 join xx in lstXX on ctsp.Maxx equals xx.Maxx
        //                 select new
        //                 {
        //                     MaHD = hd.MaHd,
        //                     Masp = sp.Masp,
        //                     Tensp = sp.Tensp,
        //                     Soluong = ctsp.Soluong,
        //                     Gia = sp.Gia,
        //                     Tenms = ms.Tenms,
        //                     Kichco1 = kc.Kichco1,
        //                     Tenth = th.Tenth,
        //                     Tenxx = xx.Tenxx,
        //                 };
        //    foreach (var x in result)
        //    {
        //        dataGrid_CTHD.Rows.Add(stt++, x.MaHD, x.Masp, x.Tensp, x.Soluong, x.Gia, x.Tenms, x.Kichco1, x.Tenth, x.Tenxx, x.Soluong * x.Gia);
        //        thanhtien = (decimal?)(x.Soluong * x.Gia);
        //    }
        //}
        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddtoHD_Click(object sender, EventArgs e)
        {
            //var ctsp = ctspservice.GetCtsps().FirstOrDefault(x => x.Mactsp == _IdCTSPWhenClick);
            //var hd = hdservice.GetHoadons().FirstOrDefault(x => x.MaHd == _IdHoaDonWhenClick);
            //Cthd cthd = new Cthd();
            //cthd.Masp = ctsp.Masp;
            //cthd.MaHd = hd.MaHd;
            //hdctservice.addct(cthd);
            //UpdateThanhTien();
            //LoadDataCTHD();
        }
        private void UpdateThanhTien()
        {
            //    var lstCTSP = ctspservice.GetCtsps();
            //    var lstSP = spservice.GetSanphams();
            //    var lstHD = hdservice.GetHoadons().Where(x => x.MaHd == _IdHoaDonWhenClick);
            //    var lstHDCT = hdctservice.GetCthds().Where(x => x.MaHd == _IdHoaDonWhenClick);
            //    var query1 = from hdct in lstHDCT
            //                 join hd in lstHD on hdct.MaHd equals hd.MaHd
            //                 select new
            //                 {
            //                     MaHDCT = hdct.MaCthd,
            //                     MaHD = hd.MaHd,
            //                     MaNV = hd.Manv,
            //                     Gia = hd.Gia,
            //                     MaKM = hd.MaKm,
            //                     ThanhTienHD = hd.Thanhtien,
            //                     MaSP = hdct.Masp,
            //                     Soluong = hdct.Soluong
            //                 };
            //    var query2 = from sp in lstSP
            //                 join ctsp in lstCTSP on sp.Masp equals ctsp.Masp
            //                 select new
            //                 {
            //                     MaSP = sp.Masp,
            //                     MaCTSP = ctsp.Mactsp,
            //                     DonGia = sp.Gia
            //                 };
            //    var data = from q1 in query1
            //               join q2 in query2 on q1.MaSP equals q2.MaSP
            //               select new
            //               {
            //                   IdHDCT = q1.MaHDCT,
            //                   maHD = q1.MaHDCT,
            //                   maNV = q1.MaHDCT,
            //                   ThanhTienHD = q1.MaHDCT,
            //                   IdCTSP = q1.MaHDCT,
            //                   Soluong = q1.Soluong,
            //                   DonGia = q2.DonGia
            //               };
            //    decimal? TienHD = 0;
            //    foreach (var item in data)
            //    {
            //        TienHD += item.Soluong * item.DonGia;

            //    }
            //    var UpdatedHD = hdservice.GetHoadons().First(x => x.MaHd == _IdHoaDonWhenClick);
            //    if (UpdatedHD != null)
            //    {
            //        UpdatedHD.Thanhtien = (double)TienHD;
            //        hdservice.updatehd(UpdatedHD);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy hóa đơn để cập nhật.");
            //    }
        }

        private void dataGrid_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRow = e.RowIndex;
            //if (selectedRow < 0 || selectedRow >= spservice.GetSanphams().Count)
            //{
            //    return;
            //}
            //_IdHDCTWhenClick = int.Parse(dataGrid_CTHD.Rows[selectedRow].Cells[0].Value.ToString());
        }

        private void dataGridHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= spservice.GetSanphams().Count)
            {
                return;
            }
            _IdHoaDonWhenClick = int.Parse(dataGridHD.Rows[selectedRow].Cells[1].Value.ToString());
            FillDataHD();
        }
        private void FillDataHD()
        {
            var clone = hdservice.GetHoadons().FirstOrDefault(x => x.Manv == _IdHoaDonWhenClick);
            if (clone != null)
            {
                txtMaHD.Text = clone.MaHd.ToString();
                txtMaNV.Text = clone.Manv.ToString();
                dpkngaymua.Value = clone.Ngaymua;
                txtMaKM.Text = clone.MaKm.ToString();
                txtThanhTien.Text = hdservice.GetHoadons().FirstOrDefault(x => x.MaHd == _IdHoaDonWhenClick).Thanhtien.ToString();
            }
        }
        public void GetThongTin()
        {
            Hoadon hd = new Hoadon();

            hd.Manv = Convert.ToInt32(txtMaNV.Text);
            hd.Ngaymua = DateTime.Now;
            MessageBox.Show(hdservice.addhd(hd));
            int idHD = hdservice.GetHoadons().First(x => x.Manv == hd.Manv && x.Ngaymua == hd.Ngaymua).MaHd;
            txtMaHD.Text = idHD.ToString();
        }

        private void btn_AddHD_Click(object sender, EventArgs e)
        {

            if (txtMaHD.Text != "" || txtMaNV.Text != "" || dpkngaymua.Text != "" || txtMaKM.Text != "" || txtThanhTien.Text != "" || txtKhachTra.Text != "" || txtTienThua.Text != "")
            {
                Hoadon hd = new Hoadon();
                hd.Manv = Convert.ToInt32(txtMaNV.Text);
                hd.Ngaymua = dpkngaymua.Value;
                hd.MaKm = Convert.ToInt32(txtMaKM.Text);
                hd.Thanhtien = Convert.ToInt32(txtThanhTien.Text);
                hd.Createby = "Admin";
                hd.Updateby = "Admin";
                MessageBox.Show(hdservice.addhd(hd));
                LoadallHD();
            }
            else
            {
                txtMaNV.Text = "";
            }
            txtMaNV.Clear();
            txt_Gia.Clear();
            txtMaKM.Clear();
            txtThanhTien.Clear();
            txtKhachTra.Clear();
            txtTienThua.Clear();
        }

        private void btn_UpdateHD_Click(object sender, EventArgs e)
        {
            var clone = hdservice.GetHoadons().FirstOrDefault(x => x.Manv == _IdHoaDonWhenClick);
            clone.Manv = Convert.ToInt32(txtMaNV.Text);
            clone.Ngaymua = dpkngaymua.Value;
            clone.MaKm = Convert.ToInt32(txtMaKM.Text);
            clone.Thanhtien = Convert.ToInt32(txtThanhTien.Text);
            clone.Createby = "Admin";
            clone.Updateby = "Admin";
            MessageBox.Show(hdservice.updatehd(clone));
            LoadallHD();

        }

        private void btn_RemoveHD_Click(object sender, EventArgs e)
        {

            var removedHD = hdservice.GetHoadons().FirstOrDefault(x => x.MaHd == _IdHoaDonWhenClick);
            if (removedHD != null)
            {
                var removeCTHD = hdctservice.GetCthds().Where(x => x.MaHd == _IdHoaDonWhenClick).ToList();
                foreach (var x in removeCTHD)
                {
                    hdctservice.Remove(x);
                }
                MessageBox.Show(hdservice.removehd(removedHD));
                LoadallHD();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn để xóa.");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txt_Gia.Clear();
            txtMaKM.Clear();
            txtThanhTien.Clear();
            txtKhachTra.Clear();
            txtTienThua.Clear();
        }

        private void txtKhachTra_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d$");
            //Tien Nhap vao ko dc la chu so
            if (Regex.IsMatch(txtKhachTra.Text, "^(0|[1-9][0-9]*)$"))
            {
                txtTienThua.Text = (decimal.Parse(txtKhachTra.Text) - decimal.Parse(txtThanhTien.Text)).ToString();
                if (decimal.Parse(txtKhachTra.Text) < decimal.Parse(txtThanhTien.Text)) //khachs chua dua du tien
                {
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    btnThanhToan.Enabled = true;
                }
            }
            else
            {
                btnThanhToan.Enabled = false;
                return;
            }
        }
    }

}
