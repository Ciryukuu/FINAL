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
    public partial class FormDangNhap : Form
    {
        TaikhoanService _service;
        private Thread _thread;
        public FormDangNhap()
        {
            InitializeComponent();
            _service = new TaikhoanService();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            pnsignin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpassword.Text;
            string message = _service.CheckLogin(username, password);
            MessageBox.Show(message);

            if (message.Equals("Đăng nhập thành công"))
            {
                // Mở form mới không dùng MessageBox
                this.Close();

                _thread = new Thread(OpenTrangChuForm);
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();
            }
        }
        private void OpenTrangChuForm()
        {
            Application.Run(new FormTrangChu());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormQuenMK formQuenMK = new FormQuenMK();
            formQuenMK.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
