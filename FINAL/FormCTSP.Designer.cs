namespace FINAL
{
    partial class FormCTSP
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
            groupBox1 = new GroupBox();
            label13 = new Label();
            txt_gia = new TextBox();
            dtg_sp = new DataGridView();
            btn_suasp = new Button();
            btn_addsp = new Button();
            txt_tensp = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtg_ms = new DataGridView();
            btn_suams = new Button();
            btn_addms = new Button();
            txt_ms = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dtg_kc = new DataGridView();
            btn_suakc = new Button();
            btn_addkc = new Button();
            txt_kc = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            dtg_th = new DataGridView();
            btn_suath = new Button();
            btn_addth = new Button();
            txt_th = new TextBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            rbtn_hh = new RadioButton();
            rbtn_db = new RadioButton();
            label12 = new Label();
            txt_sl = new TextBox();
            label11 = new Label();
            txt_xxct = new TextBox();
            label10 = new Label();
            txt_thct = new TextBox();
            label9 = new Label();
            txt_kcct = new TextBox();
            label8 = new Label();
            txt_msct = new TextBox();
            label7 = new Label();
            dtg_ctsp = new DataGridView();
            btn_suact = new Button();
            btn_addct = new Button();
            txt_masp = new TextBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            dtg_xx = new DataGridView();
            btn_suaxx = new Button();
            btn_addxx = new Button();
            txt_xx = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sp).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ms).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_kc).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_th).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ctsp).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xx).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_gia);
            groupBox1.Controls.Add(dtg_sp);
            groupBox1.Controls.Add(btn_suasp);
            groupBox1.Controls.Add(btn_addsp);
            groupBox1.Controls.Add(txt_tensp);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 87);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 6;
            label13.Text = "Giá";
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(132, 87);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(100, 23);
            txt_gia.TabIndex = 5;
            // 
            // dtg_sp
            // 
            dtg_sp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sp.Location = new Point(22, 125);
            dtg_sp.Name = "dtg_sp";
            dtg_sp.Size = new Size(335, 150);
            dtg_sp.TabIndex = 4;
            dtg_sp.CellClick += dtg_sp_CellClick;
            // 
            // btn_suasp
            // 
            btn_suasp.Location = new Point(282, 87);
            btn_suasp.Name = "btn_suasp";
            btn_suasp.Size = new Size(75, 23);
            btn_suasp.TabIndex = 3;
            btn_suasp.Text = "Sửa";
            btn_suasp.UseVisualStyleBackColor = true;
            btn_suasp.Click += btn_suasp_Click;
            // 
            // btn_addsp
            // 
            btn_addsp.Location = new Point(282, 47);
            btn_addsp.Name = "btn_addsp";
            btn_addsp.Size = new Size(75, 23);
            btn_addsp.TabIndex = 2;
            btn_addsp.Text = "Thêm";
            btn_addsp.UseVisualStyleBackColor = true;
            btn_addsp.Click += btn_addsp_Click;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(132, 47);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(100, 23);
            txt_tensp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 45);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_ms);
            groupBox2.Controls.Add(btn_suams);
            groupBox2.Controls.Add(btn_addms);
            groupBox2.Controls.Add(txt_ms);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(405, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Màu sắc";
            // 
            // dtg_ms
            // 
            dtg_ms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ms.Location = new Point(22, 125);
            dtg_ms.Name = "dtg_ms";
            dtg_ms.Size = new Size(335, 150);
            dtg_ms.TabIndex = 4;
            dtg_ms.CellClick += dtg_ms_CellClick;
            // 
            // btn_suams
            // 
            btn_suams.Location = new Point(282, 87);
            btn_suams.Name = "btn_suams";
            btn_suams.Size = new Size(75, 23);
            btn_suams.TabIndex = 3;
            btn_suams.Text = "Sửa";
            btn_suams.UseVisualStyleBackColor = true;
            btn_suams.Click += btn_suams_Click;
            // 
            // btn_addms
            // 
            btn_addms.Location = new Point(282, 47);
            btn_addms.Name = "btn_addms";
            btn_addms.Size = new Size(75, 23);
            btn_addms.TabIndex = 2;
            btn_addms.Text = "Thêm";
            btn_addms.UseVisualStyleBackColor = true;
            btn_addms.Click += btn_addms_Click;
            // 
            // txt_ms
            // 
            txt_ms.Location = new Point(132, 47);
            txt_ms.Name = "txt_ms";
            txt_ms.Size = new Size(100, 23);
            txt_ms.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 45);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Màu sắc";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_kc);
            groupBox3.Controls.Add(btn_suakc);
            groupBox3.Controls.Add(btn_addkc);
            groupBox3.Controls.Add(txt_kc);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(798, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 281);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kích cỡ";
            // 
            // dtg_kc
            // 
            dtg_kc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kc.Location = new Point(22, 125);
            dtg_kc.Name = "dtg_kc";
            dtg_kc.Size = new Size(335, 150);
            dtg_kc.TabIndex = 4;
            dtg_kc.CellClick += dtg_kc_CellClick;
            // 
            // btn_suakc
            // 
            btn_suakc.Location = new Point(282, 87);
            btn_suakc.Name = "btn_suakc";
            btn_suakc.Size = new Size(75, 23);
            btn_suakc.TabIndex = 3;
            btn_suakc.Text = "Sửa";
            btn_suakc.UseVisualStyleBackColor = true;
            btn_suakc.Click += btn_suakc_Click;
            // 
            // btn_addkc
            // 
            btn_addkc.Location = new Point(282, 47);
            btn_addkc.Name = "btn_addkc";
            btn_addkc.Size = new Size(75, 23);
            btn_addkc.TabIndex = 2;
            btn_addkc.Text = "Thêm ";
            btn_addkc.UseVisualStyleBackColor = true;
            btn_addkc.Click += btn_addkc_Click;
            // 
            // txt_kc
            // 
            txt_kc.Location = new Point(132, 47);
            txt_kc.Name = "txt_kc";
            txt_kc.Size = new Size(100, 23);
            txt_kc.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 45);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Kích cỡ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtg_th);
            groupBox4.Controls.Add(btn_suath);
            groupBox4.Controls.Add(btn_addth);
            groupBox4.Controls.Add(txt_th);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(1191, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(387, 281);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thương hiệu";
            // 
            // dtg_th
            // 
            dtg_th.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_th.Location = new Point(22, 125);
            dtg_th.Name = "dtg_th";
            dtg_th.Size = new Size(335, 150);
            dtg_th.TabIndex = 4;
            dtg_th.CellClick += dtg_th_CellClick;
            // 
            // btn_suath
            // 
            btn_suath.Location = new Point(282, 87);
            btn_suath.Name = "btn_suath";
            btn_suath.Size = new Size(75, 23);
            btn_suath.TabIndex = 3;
            btn_suath.Text = "Sửa";
            btn_suath.UseVisualStyleBackColor = true;
            btn_suath.Click += btn_suath_Click;
            // 
            // btn_addth
            // 
            btn_addth.Location = new Point(282, 47);
            btn_addth.Name = "btn_addth";
            btn_addth.Size = new Size(75, 23);
            btn_addth.TabIndex = 2;
            btn_addth.Text = "Thêm ";
            btn_addth.UseVisualStyleBackColor = true;
            btn_addth.Click += btn_addth_Click;
            // 
            // txt_th
            // 
            txt_th.Location = new Point(132, 47);
            txt_th.Name = "txt_th";
            txt_th.Size = new Size(100, 23);
            txt_th.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 45);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 0;
            label4.Text = "Thương hiệu";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbtn_hh);
            groupBox5.Controls.Add(rbtn_db);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(txt_sl);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(txt_xxct);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txt_thct);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txt_kcct);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(txt_msct);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(dtg_ctsp);
            groupBox5.Controls.Add(btn_suact);
            groupBox5.Controls.Add(btn_addct);
            groupBox5.Controls.Add(txt_masp);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(12, 312);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1173, 281);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // rbtn_hh
            // 
            rbtn_hh.AutoSize = true;
            rbtn_hh.Location = new Point(382, 93);
            rbtn_hh.Name = "rbtn_hh";
            rbtn_hh.Size = new Size(74, 19);
            rbtn_hh.TabIndex = 17;
            rbtn_hh.TabStop = true;
            rbtn_hh.Text = "Hết hàng";
            rbtn_hh.UseVisualStyleBackColor = true;
            // 
            // rbtn_db
            // 
            rbtn_db.AutoSize = true;
            rbtn_db.Location = new Point(282, 93);
            rbtn_db.Name = "rbtn_db";
            rbtn_db.Size = new Size(76, 19);
            rbtn_db.TabIndex = 16;
            rbtn_db.TabStop = true;
            rbtn_db.Text = "Đang bán";
            rbtn_db.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(213, 95);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 15;
            label12.Text = "Trạng thái";
            // 
            // txt_sl
            // 
            txt_sl.Location = new Point(92, 89);
            txt_sl.Name = "txt_sl";
            txt_sl.Size = new Size(100, 23);
            txt_sl.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 93);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 13;
            label11.Text = "Số lượng";
            // 
            // txt_xxct
            // 
            txt_xxct.Location = new Point(808, 37);
            txt_xxct.Name = "txt_xxct";
            txt_xxct.Size = new Size(100, 23);
            txt_xxct.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(764, 45);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 11;
            label10.Text = "Mã xx";
            // 
            // txt_thct
            // 
            txt_thct.Location = new Point(621, 37);
            txt_thct.Name = "txt_thct";
            txt_thct.Size = new Size(100, 23);
            txt_thct.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(577, 45);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 9;
            label9.Text = "Mã Th";
            // 
            // txt_kcct
            // 
            txt_kcct.Location = new Point(441, 37);
            txt_kcct.Name = "txt_kcct";
            txt_kcct.Size = new Size(100, 23);
            txt_kcct.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 45);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Mã kc";
            // 
            // txt_msct
            // 
            txt_msct.Location = new Point(257, 37);
            txt_msct.Name = "txt_msct";
            txt_msct.Size = new Size(100, 23);
            txt_msct.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 45);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 5;
            label7.Text = "Mã ms";
            // 
            // dtg_ctsp
            // 
            dtg_ctsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ctsp.Location = new Point(22, 125);
            dtg_ctsp.Name = "dtg_ctsp";
            dtg_ctsp.Size = new Size(1121, 150);
            dtg_ctsp.TabIndex = 4;
            dtg_ctsp.CellClick += dtg_ctsp_CellClick;
            // 
            // btn_suact
            // 
            btn_suact.Location = new Point(1078, 85);
            btn_suact.Name = "btn_suact";
            btn_suact.Size = new Size(75, 23);
            btn_suact.TabIndex = 3;
            btn_suact.Text = "Sửa";
            btn_suact.UseVisualStyleBackColor = true;
            btn_suact.Click += btn_suact_Click;
            // 
            // btn_addct
            // 
            btn_addct.Location = new Point(1078, 45);
            btn_addct.Name = "btn_addct";
            btn_addct.Size = new Size(75, 23);
            btn_addct.TabIndex = 2;
            btn_addct.Text = "Thêm ";
            btn_addct.UseVisualStyleBackColor = true;
            btn_addct.Click += btn_addct_Click;
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(66, 37);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(100, 23);
            txt_masp.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 45);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Mã sp";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dtg_xx);
            groupBox6.Controls.Add(btn_suaxx);
            groupBox6.Controls.Add(btn_addxx);
            groupBox6.Controls.Add(txt_xx);
            groupBox6.Controls.Add(label6);
            groupBox6.Location = new Point(1191, 312);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(387, 281);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Xuất xứ";
            // 
            // dtg_xx
            // 
            dtg_xx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_xx.Location = new Point(22, 125);
            dtg_xx.Name = "dtg_xx";
            dtg_xx.Size = new Size(335, 150);
            dtg_xx.TabIndex = 4;
            dtg_xx.CellClick += dtg_xx_CellClick;
            // 
            // btn_suaxx
            // 
            btn_suaxx.Location = new Point(282, 87);
            btn_suaxx.Name = "btn_suaxx";
            btn_suaxx.Size = new Size(75, 23);
            btn_suaxx.TabIndex = 3;
            btn_suaxx.Text = "Sửa";
            btn_suaxx.UseVisualStyleBackColor = true;
            btn_suaxx.Click += btn_suaxx_Click;
            // 
            // btn_addxx
            // 
            btn_addxx.Location = new Point(282, 47);
            btn_addxx.Name = "btn_addxx";
            btn_addxx.Size = new Size(75, 23);
            btn_addxx.TabIndex = 2;
            btn_addxx.Text = "Thêm ";
            btn_addxx.UseVisualStyleBackColor = true;
            btn_addxx.Click += btn_addxx_Click;
            // 
            // txt_xx
            // 
            txt_xx.Location = new Point(132, 47);
            txt_xx.Name = "txt_xx";
            txt_xx.Size = new Size(100, 23);
            txt_xx.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 45);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 0;
            label6.Text = "Nơi sản xuất";
            // 
            // FormCTSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 703);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormCTSP";
            Text = "FormCTSP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sp).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ms).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_kc).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_th).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ctsp).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_sp;
        private Button btn_suasp;
        private Button btn_addsp;
        private TextBox txt_tensp;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dtg_ms;
        private Button btn_suams;
        private Button btn_addms;
        private TextBox txt_ms;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dtg_kc;
        private Button btn_suakc;
        private Button btn_addkc;
        private TextBox txt_kc;
        private Label label3;
        private GroupBox groupBox4;
        private DataGridView dtg_th;
        private Button btn_suath;
        private Button btn_addth;
        private TextBox txt_th;
        private Label label4;
        private GroupBox groupBox5;
        private RadioButton rbtn_hh;
        private RadioButton rbtn_db;
        private Label label12;
        private TextBox txt_sl;
        private Label label11;
        private TextBox txt_xxct;
        private Label label10;
        private TextBox txt_thct;
        private Label label9;
        private TextBox txt_kcct;
        private Label label8;
        private TextBox txt_msct;
        private Label label7;
        private DataGridView dtg_ctsp;
        private Button btn_suact;
        private Button btn_addct;
        private TextBox txt_masp;
        private Label label5;
        private GroupBox groupBox6;
        private DataGridView dtg_xx;
        private Button btn_suaxx;
        private Button btn_addxx;
        private TextBox txt_xx;
        private Label label6;
        private Label label13;
        private TextBox txt_gia;
    }
}