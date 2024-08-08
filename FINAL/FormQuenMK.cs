using BLL.Services;
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
    public partial class FormQuenMK : Form
    {
        TaikhoanService _services;
        public FormQuenMK()
        {
            InitializeComponent();
            _services = new TaikhoanService();
        }

        private void FormQuenMK_Load(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.");
                return;
            }

            string forget = _services.QuenMk(username);
            MessageBox.Show(forget);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }
    }
}
