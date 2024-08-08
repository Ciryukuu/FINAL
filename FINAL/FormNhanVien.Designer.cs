namespace FINAL
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dgv_nv = new DataGridView();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnsuatk = new Button();
            btnthemtk = new Button();
            label3 = new Label();
            label4 = new Label();
            txtpassword = new TextBox();
            txttaikhoan = new TextBox();
            groupBox2 = new GroupBox();
            txtquoctich = new TextBox();
            txt_vt = new TextBox();
            btanan = new Button();
            btnsua = new Button();
            btnthem = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            rdonu = new RadioButton();
            label14 = new Label();
            rdonam = new RadioButton();
            txttennv = new TextBox();
            txtmataikhoan = new TextBox();
            txtdiachi = new TextBox();
            label21 = new Label();
            dpkngaysinh = new DateTimePicker();
            label13 = new Label();
            groupBox1 = new GroupBox();
            dgv_tk = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_password = new TextBox();
            txt_taikhoan = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nv).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tk).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 903);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightCyan;
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dgv_nv);
            groupBox3.Location = new Point(12, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1900, 403);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân viên";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F);
            label5.Location = new Point(72, 19);
            label5.Name = "label5";
            label5.Size = new Size(72, 16);
            label5.TabIndex = 46;
            label5.Text = "Tìm kiếm :";
            // 
            // dgv_nv
            // 
            dgv_nv.AllowDrop = true;
            dgv_nv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_nv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nv.Location = new Point(23, 50);
            dgv_nv.Name = "dgv_nv";
            dgv_nv.Size = new Size(1851, 331);
            dgv_nv.TabIndex = 4;
            dgv_nv.CellClick += dgv_nv_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 323);
            panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Linen;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(btnsuatk);
            groupBox4.Controls.Add(btnthemtk);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(txtpassword);
            groupBox4.Controls.Add(txttaikhoan);
            groupBox4.Font = new Font("Arial", 12F);
            groupBox4.Location = new Point(1093, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(781, 288);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tài khoản";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(363, 243);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnsuatk
            // 
            btnsuatk.Location = new Point(239, 160);
            btnsuatk.Name = "btnsuatk";
            btnsuatk.Size = new Size(75, 23);
            btnsuatk.TabIndex = 13;
            btnsuatk.Text = "Sửa";
            btnsuatk.UseVisualStyleBackColor = true;
            btnsuatk.Click += btnsuatk_Click;
            // 
            // btnthemtk
            // 
            btnthemtk.Location = new Point(146, 160);
            btnthemtk.Name = "btnthemtk";
            btnthemtk.Size = new Size(75, 23);
            btnthemtk.TabIndex = 12;
            btnthemtk.Text = "Thêm";
            btnthemtk.UseVisualStyleBackColor = true;
            btnthemtk.Click += btnthemtk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(34, 105);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(34, 59);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 10;
            label4.Text = "Tài khoản";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(124, 101);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(260, 26);
            txtpassword.TabIndex = 9;
            // 
            // txttaikhoan
            // 
            txttaikhoan.Location = new Point(124, 55);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(260, 26);
            txttaikhoan.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(txtquoctich);
            groupBox2.Controls.Add(txt_vt);
            groupBox2.Controls.Add(btanan);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(rdonu);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(rdonam);
            groupBox2.Controls.Add(txttennv);
            groupBox2.Controls.Add(txtmataikhoan);
            groupBox2.Controls.Add(txtdiachi);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(dpkngaysinh);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(23, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1008, 288);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhân viên";
            // 
            // txtquoctich
            // 
            txtquoctich.Location = new Point(599, 148);
            txtquoctich.Name = "txtquoctich";
            txtquoctich.Size = new Size(216, 26);
            txtquoctich.TabIndex = 64;
            // 
            // txt_vt
            // 
            txt_vt.Location = new Point(145, 191);
            txt_vt.Name = "txt_vt";
            txt_vt.Size = new Size(221, 26);
            txt_vt.TabIndex = 63;
            // 
            // btanan
            // 
            btanan.ForeColor = Color.Black;
            btanan.Location = new Point(888, 167);
            btanan.Name = "btanan";
            btanan.Size = new Size(75, 23);
            btanan.TabIndex = 62;
            btanan.Text = "Ẩn";
            btanan.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.ForeColor = Color.Black;
            btnsua.Location = new Point(888, 104);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 61;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.ForeColor = Color.Black;
            btnthem.Location = new Point(888, 45);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 60;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(71, 148);
            label19.Name = "label19";
            label19.Size = new Size(65, 18);
            label19.TabIndex = 43;
            label19.Text = "Địa chỉ :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(509, 153);
            label18.Name = "label18";
            label18.Size = new Size(81, 18);
            label18.TabIndex = 44;
            label18.Text = "Quốc tịch :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(37, 50);
            label17.Name = "label17";
            label17.Size = new Size(107, 18);
            label17.TabIndex = 45;
            label17.Text = "Tênnhân viên :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(509, 102);
            label16.Name = "label16";
            label16.Size = new Size(84, 18);
            label16.TabIndex = 46;
            label16.Text = "Ngày sinh :";
            // 
            // rdonu
            // 
            rdonu.AutoSize = true;
            rdonu.Location = new Point(228, 100);
            rdonu.Name = "rdonu";
            rdonu.Size = new Size(48, 22);
            rdonu.TabIndex = 56;
            rdonu.TabStop = true;
            rdonu.Text = "Nữ";
            rdonu.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 100);
            label14.Name = "label14";
            label14.Size = new Size(74, 18);
            label14.TabIndex = 47;
            label14.Text = "Giới tính :";
            // 
            // rdonam
            // 
            rdonam.AutoSize = true;
            rdonam.Location = new Point(157, 100);
            rdonam.Name = "rdonam";
            rdonam.Size = new Size(59, 22);
            rdonam.TabIndex = 55;
            rdonam.TabStop = true;
            rdonam.Text = "Nam";
            rdonam.UseVisualStyleBackColor = true;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(150, 50);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(221, 26);
            txttennv.TabIndex = 48;
            // 
            // txtmataikhoan
            // 
            txtmataikhoan.Location = new Point(599, 50);
            txtmataikhoan.Name = "txtmataikhoan";
            txtmataikhoan.Size = new Size(216, 26);
            txtmataikhoan.TabIndex = 54;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(145, 150);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(221, 26);
            txtdiachi.TabIndex = 49;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(488, 58);
            label21.Name = "label21";
            label21.Size = new Size(105, 18);
            label21.TabIndex = 53;
            label21.Text = "Mã tài khoản :";
            // 
            // dpkngaysinh
            // 
            dpkngaysinh.Location = new Point(599, 100);
            dpkngaysinh.Name = "dpkngaysinh";
            dpkngaysinh.Size = new Size(216, 26);
            dpkngaysinh.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(71, 191);
            label13.Name = "label13";
            label13.Size = new Size(61, 18);
            label13.TabIndex = 52;
            label13.Text = "Vai trò :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(dgv_tk);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_taikhoan);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(1079, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 0);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản";
            // 
            // dgv_tk
            // 
            dgv_tk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_tk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tk.Location = new Point(391, 25);
            dgv_tk.Name = "dgv_tk";
            dgv_tk.Size = new Size(387, 243);
            dgv_tk.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(226, 189);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(133, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(21, 134);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 11;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(21, 88);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 10;
            label1.Text = "Tài khoản";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(111, 130);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(260, 26);
            txt_password.TabIndex = 9;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(111, 84);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(260, 26);
            txt_taikhoan.TabIndex = 8;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 903);
            Controls.Add(panel1);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nv).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private TextBox txt_vt;
        private Button btanan;
        private Button btnsua;
        private Button btnthem;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private RadioButton rdonu;
        private Label label14;
        private RadioButton rdonam;
        private TextBox txttennv;
        private TextBox txtmataikhoan;
        private TextBox txtdiachi;
        private Label label21;
        private DateTimePicker dpkngaysinh;
        private Label label13;
        private DataGridView dgv_tk;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txt_password;
        private TextBox txt_taikhoan;
        private GroupBox groupBox3;
        private DataGridView dgv_nv;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button btnsuatk;
        private Button btnthemtk;
        private Label label3;
        private Label label4;
        private TextBox txtpassword;
        private TextBox txttaikhoan;
        private Label label5;
        private TextBox txtquoctich;
        private ComboBox comboBox1;
    }
}