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
    public partial class FormSanPham : Form
    {
        Sanphamservice spservice = new Sanphamservice();
        CTSPservice ctservice = new CTSPservice();
        Mausacservice msservice = new Mausacservice();
        Kichcoservice kcservice = new Kichcoservice();
        Thuonghieuservice thservice = new Thuonghieuservice();
        Xuatxuservice xxservice = new Xuatxuservice();
        List<Ctsp> listct = new List<Ctsp>();
        public FormSanPham()
        {
            InitializeComponent();
            Loadfullsp();
            settingcombobox();
            listct = ctservice.GetCtsps().Where(x => x.Trangthai == true).ToList();
        }
        public void Loadfullsp()
        {
            int stt = 1;

            dtg_full.ColumnCount = 10;
            dtg_full.Columns[0].Name = "STT";
            dtg_full.Columns[1].Name = "Mã sản phẩm";
            dtg_full.Columns[2].Name = "Tên sản phẩm ";
            dtg_full.Columns[3].Name = "Số lượng ";
            dtg_full.Columns[4].Name = "Giá";
            dtg_full.Columns[5].Name = "Trạng thái";
            dtg_full.Columns[6].Name = "Màu sắc";
            dtg_full.Columns[7].Name = "Kích cỡ";
            dtg_full.Columns[8].Name = "Thương hiệu";
            dtg_full.Columns[9].Name = "Xuất xứ";
            dtg_full.Rows.Clear();

            var listsp = spservice.GetSanphams();
            var listms = msservice.GetMausacs();
            var listkc = kcservice.GetKichcos();
            var listth = thservice.GetThuonghieus();
            var listxx = xxservice.GetXuatxus();
            var result = from sp in listsp
                         join ctsp in listct on sp.Masp equals ctsp.Masp
                         join kc in listkc on ctsp.Makc equals kc.Makc
                         join ms in listms on ctsp.Mams equals ms.Mams
                         join th in listth on ctsp.Math equals th.Math
                         join xx in listxx on ctsp.Maxx equals xx.Maxx
                         select new
                         {
                             Masp = sp.Masp,
                             Tensp = sp.Tensp,
                             Soluong = ctsp.Soluong,
                             Gia = sp.Gia,
                             Trangthai = ctsp.Trangthai,
                             Tenms = ms.Tenms,
                             Kichco1 = kc.Kichco1,
                             Tenth = th.Tenth,
                             Tenxx = xx.Tenxx,
                         };
            foreach (var x in result)
            {
                dtg_full.Rows.Add(stt++, x.Masp, x.Tensp, x.Soluong, x.Gia, x.Trangthai == true ? "Đang bán" : "Hết hàng", x.Tenms, x.Kichco1, x.Tenth, x.Tenxx);
            }
        }
        public void settingcombobox()
        {
            cb_trangthai.SelectedIndex = 0;
            cb_trangthai.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void pngoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_trangthai.SelectedIndex == 0)
            {
                listct = ctservice.GetCtsps().Where(x => x.Trangthai == true).ToList();
            }
            else if (cb_trangthai.SelectedIndex == 1)
            {
                listct = ctservice.GetCtsps().Where(x => x.Trangthai == false).ToList();
            }
            else
            {
                listct = ctservice.GetCtsps();
            }
            Loadfullsp();
        }

        private void btn_ctsp_Click(object sender, EventArgs e)
        {
            FormCTSP form = new FormCTSP();
            form.Show();
        }
    }
}
