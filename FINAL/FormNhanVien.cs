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
    public partial class FormNhanVien : Form
    {
        TaikhoanService _servicestk;
        NhanvienService _servicesnv;
        int iDWhenClick;
        int iDWhenClicktk;
        public FormNhanVien()
        {
            InitializeComponent();
            _servicestk = new TaikhoanService();
            _servicesnv = new NhanvienService();
            LoadGrid();
            LoadGrid1();
        }

        public void LoadGrid()
        {
            int stt = 1;
            dgv_nv.ColumnCount = 11;
            dgv_nv.Columns[0].Name = "Số thứ tự";
            dgv_nv.Columns[1].Name = "Mã nhân viên";
            dgv_nv.Columns[2].Name = "Tên nhân viên";
            dgv_nv.Columns[3].Name = "Giới tính";
            dgv_nv.Columns[4].Name = "Ngày sinh";
            dgv_nv.Columns[5].Name = "Quốc Tịch";
            dgv_nv.Columns[6].Name = "Địa chỉ";
            dgv_nv.Columns[7].Name = "Vai trò";
            dgv_nv.Columns[8].Name = "Mã Tài Khoản";
            dgv_nv.Columns[9].Name = "Username";
            dgv_nv.Columns[10].Name = "Password";
            dgv_nv.Rows.Clear();

            var lstNhanvien = _servicesnv.GetAllNhanviens();
            var lstTaikhoan = _servicestk.GetTaikhoans();
            var dataJoinTk = lstNhanvien.Join(lstTaikhoan,
                                           nv => nv.Matk, tk => tk.MaTk,
                                           (nv, tk) => new
                                           {
                                               MaTk = tk.MaTk,
                                               Username = tk.Username,
                                               Password = tk.Passwords,
                                               MaNV = nv.Manv,
                                               TenNV = nv.Tennv,
                                               GioiTinh = nv.Gioitinh,
                                               Ngaysinh = nv.Ngaysinh,
                                               QuocTich = nv.Quoctich,
                                               Diachi = nv.Diachi,
                                               Vaitro = nv.Vaitro,
                                           }).ToList();

            foreach (var data in dataJoinTk)
            {
                dgv_nv.Rows.Add(stt++, data.MaNV, data.TenNV, data.GioiTinh, data.Ngaysinh, data.QuocTich, data.Diachi, data.Vaitro, data.MaTk, data.Username, data.Password);
            }
        }
        private void FillData()
        {
            var clone = _servicesnv.GetAllNhanviens().FirstOrDefault(x => x.Manv == iDWhenClick);
            if (clone != null)
            {
                txttennv.Text = clone.Tennv;
                if (clone.Gioitinh == true)
                {
                    rdonam.Checked = true;
                }
                else
                {
                    rdonu.Checked = true;
                }
                txtdiachi.Text = clone.Diachi;
                txtquoctich.Text = clone.Quoctich;
                txtdiachi.Text = clone.Diachi;
                txt_vt.Text = clone.Vaitro;
                dpkngaysinh.Value = clone.Ngaysinh;
                txtmataikhoan.Text = clone.Matk.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy được xem mk ấn vào dòng nào 
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= dgv_nv.RowCount - 1)
                return;

            // Trích xuất cột chứa dữ liệu chứa Id
            if (int.TryParse(dgv_nv.Rows[selectedRow].Cells[1].Value?.ToString(), out iDWhenClicktk))
            {
                FillData1();
            }
            else
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien nhanvien = new Nhanvien
                {
                    Tennv = txttennv.Text,
                    Gioitinh = rdonam.Checked, // Giả sử rbtn_nam và rbtn_nu là RadioButton cho giới tính
                    Diachi = txtdiachi.Text,
                    Quoctich = txtquoctich.Text,
                    Vaitro = txt_vt.Text,
                    Ngaysinh = dpkngaysinh.Value,
                    Createby = "Admin", // Set the createby value here
                    Updateby = "Admin"
                };

                if (int.TryParse(txtmataikhoan.Text, out int matk))
                {
                    nhanvien.Matk = matk;
                }
                else
                {
                    MessageBox.Show("Mã tài khoản không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string result = _servicesnv.AddNhanVien(nhanvien);
                MessageBox.Show(result);


                if (result.Contains("thành công"))
                {
                    // Tải lại dữ liệu lên DataGridView nếu thành công
                    LoadGrid();

                    // Xóa các trường nhập liệu sau khi thêm thành công
                    txttennv.Clear();
                    rdonam.Checked = false;
                    rdonu.Checked = false;
                    txtdiachi.Clear();
                    txtquoctich.Clear();
                    txt_vt.Clear();
                    dpkngaysinh.Value = DateTime.Now;
                    txtmataikhoan.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có muốn sửa nhân viên không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var update = _servicesnv.GetAllNhanviens().FirstOrDefault(x => x.Manv == iDWhenClick);

                if (update != null)
                {
                    // Update the properties of the employee
                    update.Tennv = txttennv.Text;
                    update.Gioitinh = rdonam.Checked; // Assuming rbtn_nam and rbtn_nu are RadioButtons
                    update.Diachi = txtdiachi.Text;
                    update.Quoctich = txtquoctich.Text;
                    update.Vaitro = txt_vt.Text;
                    update.Ngaysinh = dpkngaysinh.Value;
                    update.Matk = int.Parse(txtmataikhoan.Text);


                    // Call the update service
                    var result = _servicesnv.UpdateNhanVien(update);
                    MessageBox.Show(result);
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại.");
                }
            }
        }
        public void LoadGrid1()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Số thứ tự";
            dataGridView1.Columns[1].Name = "Mã tài khoản";
            dataGridView1.Columns[2].Name = "Tài khoản";
            dataGridView1.Columns[3].Name = "Mật khẩu";
            dataGridView1.Rows.Clear();
            foreach (var item in _servicestk.GetTaikhoans())
            {
                dataGridView1.Rows.Add(stt++, item.MaTk, item.Username, item.Passwords);
            }
        }
        private void FillData1()
        {
            var clone = _servicestk.GetTaikhoans().FirstOrDefault(x => x.MaTk == iDWhenClick);
            if (clone != null)
            {
                txt_taikhoan.Text = clone.Username;
                txt_password.Text = clone.Passwords;
            }
        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            try
            {
                var taikhoan = new DTO.Models.Taikhoan()
                {
                    Username = txt_taikhoan.Text,
                    Passwords = txt_password.Text,
                    Createby = "Admin", // Thêm giá trị cho createby
                    Updateby = "Admin",
                };

                string result = _servicestk.ThemTK(taikhoan);
                MessageBox.Show(result);

                if (result.Contains("thành công")) // Assuming the result contains this phrase when successful
                {
                    LoadGrid1();

                    // Clear input fields after successful addition
                    txt_taikhoan.Clear();
                    txt_password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuatk_Click(object sender, EventArgs e)
        {
            try
            {
                var update = _servicestk.GetTaikhoans().FirstOrDefault(x => x.MaTk == iDWhenClick);
                if (update != null)
                {
                    update.Username = txt_taikhoan.Text;
                    update.Passwords = txt_password.Text;
                    update.Createby = "Admin";
                    update.Updateby = "Admin"; // Set the updateby value here

                    string result = _servicestk.SuaTK(update);
                    MessageBox.Show(result);

                    if (result.Contains("thành công")) // Assuming the result contains this phrase when successful
                    {
                        LoadGrid1();
                        // Clear input fields after successful update
                        txt_taikhoan.Clear();
                        txt_password.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy được xem mk ấn vào dòng nào 
            int selectedRow = e.RowIndex;
            if (selectedRow < 0 || selectedRow >= dgv_nv.RowCount - 1)
                return;

            // Trích xuất cột chứa dữ liệu chứa Id
            if (int.TryParse(dgv_nv.Rows[selectedRow].Cells[1].Value?.ToString(), out iDWhenClick))
            {
                FillData();
            }
            else
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
