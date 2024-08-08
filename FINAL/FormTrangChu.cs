using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSanPham sp = new FormSanPham() { TopLevel = false, TopMost = true };
            sp.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            sp.Location = new Point(0, 0);
            pnjoinform.Controls.Add(sp);
            sp.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
            FormKhuyenMai km = new FormKhuyenMai() { TopLevel = false, TopMost = true };
            km.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            km.Location = new Point(0, 0);
            pnjoinform.Controls.Add(km);
            km.Show();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe() { TopLevel = false, TopMost = true };
            tk.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            tk.Location = new Point(0, 0);
            pnjoinform.Controls.Add(tk);
            tk.Show();
        }

        private void btntonkho_Click(object sender, EventArgs e)
        {
            FormTonKho tk1 = new FormTonKho() { TopLevel = false, TopMost = true };
            tk1.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            tk1.Location = new Point(0, 0);
            pnjoinform.Controls.Add(tk1);
            tk1.Show();
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon() { TopLevel = false, TopMost = true };
            hd.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            hd.Location = new Point(0, 0);
            pnjoinform.Controls.Add(hd);
            hd.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien() { TopLevel = false, TopMost = true };
            nv.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            nv.Location = new Point(0, 0);
            pnjoinform.Controls.Add(nv);
            nv.Show();
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            FormBanHang bh = new FormBanHang() { TopLevel = false, TopMost = true };
            bh.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            bh.Location = new Point(0, 0);
            pnjoinform.Controls.Add(bh);
            bh.Show();
        }

        private void btnlichsu_Click(object sender, EventArgs e)
        {
            FormLSGD gd = new FormLSGD() { TopLevel = false, TopMost = true };
            gd.FormBorderStyle = FormBorderStyle.None;
            if (pnjoinform.Controls.Count > 0) { pnjoinform.Controls.Clear(); }
            gd.Location = new Point(0, 0);
            pnjoinform.Controls.Add(gd);
            gd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
  
        }
    }
}
