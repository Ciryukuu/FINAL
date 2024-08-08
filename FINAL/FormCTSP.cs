using BLL.Services;
using DTO.Models;
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
    public partial class FormCTSP : Form
    {
        Sanphamservice spservice = new Sanphamservice();
        Mausacservice msservice = new Mausacservice();
        Kichcoservice kcservice = new Kichcoservice();
        Thuonghieuservice thservice = new Thuonghieuservice();
        Xuatxuservice xxservice = new Xuatxuservice();
        CTSPservice ctspservice = new CTSPservice();
        int idwhenclick;
        public FormCTSP()
        {
            InitializeComponent();
            loadSP();
            loadms();
            loadkc();
            loadxx();
            loadth();
            loadct();
        }
        public void loadSP()
        {
            dtg_sp.ColumnCount = 3;
            dtg_sp.Columns[0].Name = "Mã sản phẩm ";
            dtg_sp.Columns[1].Name = "Tên sản phẩm";
            dtg_sp.Columns[2].Name = "Giá";
            dtg_sp.Rows.Clear();
            foreach (var sp in spservice.GetSanphams())
            {
                dtg_sp.Rows.Add(sp.Masp, sp.Tensp, sp.Gia);
            }
        }

        private void dtg_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= spservice.GetSanphams().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_sp.Rows[rowindex].Cells[0].Value.ToString());
            filldatasp();
        }
        public void filldatasp()
        {
            var data = spservice.GetSanphams().Where(x => x.Masp == idwhenclick).FirstOrDefault();
            txt_tensp.Text = data.Tensp;
            txt_gia.Text = data.Gia.ToString();
        }

        private void btn_addsp_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text != "" || txt_gia.Text != "" || decimal.TryParse(txt_gia.Text, out decimal gia))
            {
                Sanpham sp = new Sanpham();
                sp.Tensp = txt_tensp.Text;
                sp.Gia = decimal.Parse(txt_gia.Text);
                MessageBox.Show(spservice.addsp(sp));
                loadSP();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text != "" || txt_gia.Text != "")
            {
                var sp = spservice.GetSanphams().Where(x => x.Masp == idwhenclick).FirstOrDefault();
                sp.Tensp = txt_tensp.Text;
                sp.Gia = decimal.Parse(txt_gia.Text);
                MessageBox.Show(spservice.addsp(sp));
                loadSP();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
        public void loadms()
        {
            dtg_ms.ColumnCount = 2;
            dtg_ms.Columns[0].Name = "Mã màu sắc ";
            dtg_ms.Columns[1].Name = "Tên màu sắc";

            dtg_ms.Rows.Clear();
            foreach (var ms in msservice.GetMausacs())
            {
                dtg_ms.Rows.Add(ms.Mams, ms.Tenms);
            }
        }

        private void dtg_ms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= msservice.GetMausacs().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_ms.Rows[rowindex].Cells[0].Value.ToString());
            filldatams();
        }
        public void filldatams()
        {
            var data = msservice.GetMausacs().Where(x => x.Mams == idwhenclick).FirstOrDefault();
            txt_ms.Text = data.Tenms;
        }

        private void btn_addms_Click(object sender, EventArgs e)
        {
            if (txt_ms.Text != "")
            {
                Mausac ms = new Mausac();
                ms.Tenms = txt_ms.Text;
                MessageBox.Show(msservice.addms(ms));
                loadms();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suams_Click(object sender, EventArgs e)
        {
            if (txt_ms.Text != "")
            {
                var ms = msservice.GetMausacs().Where(x => x.Mams == idwhenclick).FirstOrDefault();

                ms.Tenms = txt_ms.Text;
                MessageBox.Show(msservice.addms(ms));
                loadms();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
        public void loadkc()
        {
            dtg_kc.ColumnCount = 2;
            dtg_kc.Columns[0].Name = "Mã kich xỡ ";
            dtg_kc.Columns[1].Name = "Kích cỡ";

            dtg_kc.Rows.Clear();
            foreach (var kc in kcservice.GetKichcos())
            {
                dtg_kc.Rows.Add(kc.Makc, kc.Kichco1);
            }
        }

        private void dtg_kc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= kcservice.GetKichcos().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_kc.Rows[rowindex].Cells[0].Value.ToString());
            filldatakc();
        }
        public void filldatakc()
        {
            var data = kcservice.GetKichcos().Where(x => x.Makc == idwhenclick).FirstOrDefault();
            txt_kc.Text = data.Kichco1.ToString();
        }

        private void btn_addkc_Click(object sender, EventArgs e)
        {
            if (txt_kc.Text != "")
            {
                Kichco kc = new Kichco();
                kc.Kichco1 = float.Parse(txt_kc.Text);
                MessageBox.Show(kcservice.addkc(kc));
                loadkc();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suakc_Click(object sender, EventArgs e)
        {
            if (txt_kc.Text != "")
            {
                var kc = kcservice.GetKichcos().Where(x => x.Makc == idwhenclick).FirstOrDefault();

                kc.Kichco1 = float.Parse(txt_kc.Text);
                MessageBox.Show(kcservice.addkc(kc));
                loadkc();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
        public void loadxx()
        {
            dtg_xx.ColumnCount = 2;
            dtg_xx.Columns[0].Name = "Mã xuất xứ ";
            dtg_xx.Columns[1].Name = "Xuất xứ";

            dtg_xx.Rows.Clear();
            foreach (var kc in xxservice.GetXuatxus())
            {
                dtg_xx.Rows.Add(kc.Maxx, kc.Tenxx);
            }
        }

        private void dtg_xx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= xxservice.GetXuatxus().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_xx.Rows[rowindex].Cells[0].Value.ToString());
            filldataxx();
        }
        public void filldataxx()
        {
            var data = xxservice.GetXuatxus().Where(x => x.Maxx == idwhenclick).FirstOrDefault();
            txt_xx.Text = data.Tenxx;
        }

        private void btn_addxx_Click(object sender, EventArgs e)
        {
            if (txt_xx.Text != "")
            {
                Xuatxu xx = new Xuatxu();
                xx.Tenxx = txt_xx.Text;
                MessageBox.Show(xxservice.addxx(xx));
                loadxx();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suaxx_Click(object sender, EventArgs e)
        {
            if (txt_xx.Text != "")
            {
                var xx = xxservice.GetXuatxus().Where(x => x.Maxx == idwhenclick).FirstOrDefault();
                xx.Tenxx = txt_xx.Text;
                MessageBox.Show(xxservice.addxx(xx));
                loadxx();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
        public void loadth()
        {
            dtg_th.ColumnCount = 2;
            dtg_th.Columns[0].Name = "Mã thương hiệu ";
            dtg_th.Columns[1].Name = "Thương hiệu";

            dtg_th.Rows.Clear();
            foreach (var th in thservice.GetThuonghieus())
            {
                dtg_th.Rows.Add(th.Math, th.Tenth);
            }

        }

        private void dtg_th_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= thservice.GetThuonghieus().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_th.Rows[rowindex].Cells[0].Value.ToString());
            filldatath();
        }
        public void filldatath()
        {
            var data = thservice.GetThuonghieus().Where(x => x.Math == idwhenclick).FirstOrDefault();
            txt_th.Text = data.Tenth;
        }

        private void btn_addth_Click(object sender, EventArgs e)
        {
            if (txt_th.Text != "")
            {
                Thuonghieu th = new Thuonghieu();
                th.Tenth = txt_th.Text;
                MessageBox.Show(thservice.addth(th));
                loadth();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suath_Click(object sender, EventArgs e)
        {
            if (txt_th.Text != "")
            {
                var th = thservice.GetThuonghieus().Where(x => x.Math == idwhenclick).FirstOrDefault();
                MessageBox.Show(thservice.addth(th));
                loadth();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
        public void loadct()
        {
            dtg_ctsp.ColumnCount = 8;
            dtg_ctsp.Columns[0].Name = "Mã chi tiết";
            dtg_ctsp.Columns[1].Name = "Mã sản phẩm";
            dtg_ctsp.Columns[2].Name = "Mã màu";
            dtg_ctsp.Columns[3].Name = "Mã kích cỡ";
            dtg_ctsp.Columns[4].Name = "Mã thương hiệu";
            dtg_ctsp.Columns[5].Name = "Mã xuất xứ";
            dtg_ctsp.Columns[6].Name = "Số lượng ";
            dtg_ctsp.Columns[7].Name = "Trạng thái";
            dtg_ctsp.Rows.Clear();
            foreach (var ct in ctspservice.GetCtsps())
            {
                dtg_ctsp.Rows.Add(ct.Mactsp, ct.Masp, ct.Mams, ct.Makc, ct.Math, ct.Maxx, ct.Soluong, ct.Trangthai == true ? "Đang bán" : "Hết hàng");
            }
        }

        private void dtg_ctsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;
            if (rowindex < 0 || rowindex >= ctspservice.GetCtsps().Count())
            {
                return;
            }
            idwhenclick = int.Parse(dtg_ctsp.Rows[rowindex].Cells[0].Value.ToString());
            filldatact();
        }
        public void filldatact()
        {
            var data = ctspservice.GetCtsps().Where(x => x.Mactsp == idwhenclick).FirstOrDefault();
            txt_masp.Text = data.Masp.ToString();
            txt_msct.Text = data.Mams.ToString();
            txt_thct.Text = data.Math.ToString();
            txt_xxct.Text = data.Maxx.ToString();
            txt_kcct.Text = data.Makc.ToString();
            txt_sl.Text = data.Soluong.ToString();
            if (data.Trangthai == true)
            {
                rbtn_db.Checked = true;
            }
            else
            {
                rbtn_db.Checked = false;
            }

        }

        private void btn_addct_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text == "" || txt_msct.Text == "" || txt_thct.Text == "" || txt_kcct.Text == "" || txt_xxct.Text == "" || txt_sl.Text == "")
            {
                Ctsp ct = new Ctsp();
                ct.Masp = int.Parse(txt_masp.Text);
                ct.Mams = int.Parse(txt_msct.Text);
                ct.Makc = int.Parse(txt_kcct.Text);
                ct.Maxx = int.Parse(txt_xxct.Text);
                ct.Math = int.Parse(txt_thct.Text);
                ct.Soluong = int.Parse(txt_sl.Text);
                if (rbtn_db.Checked == true)
                {
                    ct.Trangthai = true;
                }
                else
                {
                    ct.Trangthai = false;
                }
                MessageBox.Show(ctspservice.addct(ct));
                loadct();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btn_suact_Click(object sender, EventArgs e)
        {

            if (txt_masp.Text == "" || txt_msct.Text == "" || txt_thct.Text == "" || txt_kcct.Text == "" || txt_xxct.Text == "" || txt_sl.Text == "")
            {
                var ct = ctspservice.GetCtsps().Where(x => x.Mactsp == idwhenclick).FirstOrDefault();
                ct.Masp = int.Parse(txt_masp.Text);
                ct.Mams = int.Parse(txt_msct.Text);
                ct.Makc = int.Parse(txt_kcct.Text);
                ct.Maxx = int.Parse(txt_xxct.Text);
                ct.Math = int.Parse(txt_thct.Text);
                ct.Soluong = int.Parse(txt_sl.Text);
                if (rbtn_db.Checked == true)
                {
                    ct.Trangthai = true;
                }
                else
                {
                    ct.Trangthai = false;
                }
                MessageBox.Show(ctspservice.addct(ct));
                loadct();
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }
    }
}
