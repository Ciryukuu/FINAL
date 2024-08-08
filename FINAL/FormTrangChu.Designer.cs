namespace FINAL
{
    partial class FormTrangChu
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
            button1 = new Button();
            pnjoinform = new Panel();
            panel2 = new Panel();
            pnjoin = new FlowLayoutPanel();
            btnlichsu = new Button();
            btnbanhang = new Button();
            btnkhuyenmai = new Button();
            btnnhanvien = new Button();
            btnhoadon = new Button();
            btntrangchu = new Button();
            btntonkho = new Button();
            btnsanpham = new Button();
            btnthongke = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.pngtree_sneakers_main_picture_background_material_image_196600;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pnjoinform);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1792, 968);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10F);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1640, 66);
            button1.Name = "button1";
            button1.Size = new Size(90, 26);
            button1.TabIndex = 9;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnjoinform
            // 
            pnjoinform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnjoinform.BackColor = Color.Transparent;
            pnjoinform.Location = new Point(3, 199);
            pnjoinform.Name = "pnjoinform";
            pnjoinform.Size = new Size(1786, 766);
            pnjoinform.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pnjoin);
            panel2.Controls.Add(btnlichsu);
            panel2.Controls.Add(btnbanhang);
            panel2.Controls.Add(btnkhuyenmai);
            panel2.Controls.Add(btnnhanvien);
            panel2.Controls.Add(btnhoadon);
            panel2.Controls.Add(btntrangchu);
            panel2.Controls.Add(btntonkho);
            panel2.Controls.Add(btnsanpham);
            panel2.Controls.Add(btnthongke);
            panel2.Location = new Point(3, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(4962, 57);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // pnjoin
            // 
            pnjoin.Location = new Point(3, 56);
            pnjoin.Name = "pnjoin";
            pnjoin.Size = new Size(1786, 766);
            pnjoin.TabIndex = 5;
            // 
            // btnlichsu
            // 
            btnlichsu.BackColor = SystemColors.ActiveCaption;
            btnlichsu.FlatAppearance.BorderSize = 0;
            btnlichsu.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnlichsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnlichsu.FlatStyle = FlatStyle.Flat;
            btnlichsu.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnlichsu.Location = new Point(1637, 0);
            btnlichsu.Name = "btnlichsu";
            btnlichsu.Size = new Size(152, 57);
            btnlichsu.TabIndex = 9;
            btnlichsu.Text = "Lịch sử GD";
            btnlichsu.UseVisualStyleBackColor = false;
            btnlichsu.Click += btnlichsu_Click;
            // 
            // btnbanhang
            // 
            btnbanhang.BackColor = SystemColors.ActiveCaption;
            btnbanhang.FlatAppearance.BorderSize = 0;
            btnbanhang.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnbanhang.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnbanhang.FlatStyle = FlatStyle.Flat;
            btnbanhang.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnbanhang.Location = new Point(1447, 0);
            btnbanhang.Name = "btnbanhang";
            btnbanhang.Size = new Size(152, 57);
            btnbanhang.TabIndex = 8;
            btnbanhang.Text = "Bán hàng";
            btnbanhang.UseVisualStyleBackColor = false;
            btnbanhang.Click += btnbanhang_Click;
            // 
            // btnkhuyenmai
            // 
            btnkhuyenmai.BackColor = SystemColors.ActiveCaption;
            btnkhuyenmai.FlatAppearance.BorderSize = 0;
            btnkhuyenmai.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnkhuyenmai.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnkhuyenmai.FlatStyle = FlatStyle.Flat;
            btnkhuyenmai.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnkhuyenmai.Location = new Point(1236, 0);
            btnkhuyenmai.Name = "btnkhuyenmai";
            btnkhuyenmai.Size = new Size(152, 57);
            btnkhuyenmai.TabIndex = 7;
            btnkhuyenmai.Text = "Khuyến mại";
            btnkhuyenmai.UseVisualStyleBackColor = false;
            btnkhuyenmai.Click += btnkhuyenmai_Click;
            // 
            // btnnhanvien
            // 
            btnnhanvien.BackColor = SystemColors.ActiveCaption;
            btnnhanvien.FlatAppearance.BorderSize = 0;
            btnnhanvien.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnnhanvien.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnnhanvien.FlatStyle = FlatStyle.Flat;
            btnnhanvien.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnnhanvien.Location = new Point(1033, 0);
            btnnhanvien.Name = "btnnhanvien";
            btnnhanvien.Size = new Size(152, 57);
            btnnhanvien.TabIndex = 6;
            btnnhanvien.Text = "Nhân viên";
            btnnhanvien.UseVisualStyleBackColor = false;
            btnnhanvien.Click += btnnhanvien_Click;
            // 
            // btnhoadon
            // 
            btnhoadon.BackColor = SystemColors.ActiveCaption;
            btnhoadon.FlatAppearance.BorderSize = 0;
            btnhoadon.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnhoadon.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnhoadon.FlatStyle = FlatStyle.Flat;
            btnhoadon.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnhoadon.Location = new Point(829, 0);
            btnhoadon.Name = "btnhoadon";
            btnhoadon.Size = new Size(152, 57);
            btnhoadon.TabIndex = 2;
            btnhoadon.Text = "Hóa đơn";
            btnhoadon.UseVisualStyleBackColor = false;
            btnhoadon.Click += btnhoadon_Click;
            // 
            // btntrangchu
            // 
            btntrangchu.BackColor = SystemColors.ActiveCaption;
            btntrangchu.FlatAppearance.BorderSize = 0;
            btntrangchu.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btntrangchu.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btntrangchu.FlatStyle = FlatStyle.Flat;
            btntrangchu.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btntrangchu.ImageAlign = ContentAlignment.MiddleLeft;
            btntrangchu.Location = new Point(83, 0);
            btntrangchu.Name = "btntrangchu";
            btntrangchu.RightToLeft = RightToLeft.Yes;
            btntrangchu.Size = new Size(152, 57);
            btntrangchu.TabIndex = 1;
            btntrangchu.Text = "Trang chủ";
            btntrangchu.UseVisualStyleBackColor = false;
            btntrangchu.Click += btntrangchu_Click;
            // 
            // btntonkho
            // 
            btntonkho.BackColor = SystemColors.ActiveCaption;
            btntonkho.FlatAppearance.BorderSize = 0;
            btntonkho.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btntonkho.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btntonkho.FlatStyle = FlatStyle.Flat;
            btntonkho.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btntonkho.Location = new Point(636, 0);
            btntonkho.Name = "btntonkho";
            btntonkho.Size = new Size(152, 57);
            btntonkho.TabIndex = 3;
            btntonkho.Text = "Tồn kho";
            btntonkho.UseVisualStyleBackColor = false;
            btntonkho.Click += btntonkho_Click;
            // 
            // btnsanpham
            // 
            btnsanpham.BackColor = SystemColors.ActiveCaption;
            btnsanpham.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnsanpham.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnsanpham.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnsanpham.FlatStyle = FlatStyle.Flat;
            btnsanpham.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnsanpham.Location = new Point(262, 0);
            btnsanpham.Name = "btnsanpham";
            btnsanpham.Size = new Size(152, 57);
            btnsanpham.TabIndex = 5;
            btnsanpham.Text = "Sản phẩm";
            btnsanpham.UseVisualStyleBackColor = false;
            btnsanpham.Click += button5_Click;
            // 
            // btnthongke
            // 
            btnthongke.BackColor = SystemColors.ActiveCaption;
            btnthongke.FlatAppearance.BorderSize = 0;
            btnthongke.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnthongke.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnthongke.FlatStyle = FlatStyle.Flat;
            btnthongke.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnthongke.Location = new Point(449, 0);
            btnthongke.Name = "btnthongke";
            btnthongke.Size = new Size(152, 57);
            btnthongke.TabIndex = 4;
            btnthongke.Text = "Thống kê";
            btnthongke.UseVisualStyleBackColor = false;
            btnthongke.Click += btnthongke_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.z5640227041635_913419bac43fe8f3345320df4365f54d_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(859, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 197);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 961);
            Controls.Add(panel1);
            Name = "FormTrangChu";
            Text = "FormTrangChu";
            Load += FormTrangChu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnlichsu;
        private Button btnbanhang;
        private Button btnkhuyenmai;
        private Button btnnhanvien;
        private Button btnhoadon;
        private Button btntrangchu;
        private Button btntonkho;
        private Button btnsanpham;
        private Button btnthongke;
        private PictureBox pictureBox1;
        private FlowLayoutPanel pnjoin;
        private Panel pnjoinform;
        private Button button1;
    }
}