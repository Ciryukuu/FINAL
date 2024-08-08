namespace FINAL
{
    partial class FormQuenMK
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
            pnsignin = new Panel();
            btncancel = new Button();
            btnsignin = new Button();
            txtname = new TextBox();
            lblname = new Label();
            lblsignin = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            pnsignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.pngtree_sneakers_main_picture_background_material_image_196600;
            panel1.Controls.Add(pnsignin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1784, 962);
            panel1.TabIndex = 0;
            // 
            // pnsignin
            // 
            pnsignin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnsignin.BackColor = Color.Transparent;
            pnsignin.Controls.Add(btncancel);
            pnsignin.Controls.Add(btnsignin);
            pnsignin.Controls.Add(txtname);
            pnsignin.Controls.Add(lblname);
            pnsignin.Controls.Add(lblsignin);
            pnsignin.Location = new Point(1028, 449);
            pnsignin.Name = "pnsignin";
            pnsignin.Size = new Size(545, 331);
            pnsignin.TabIndex = 9;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(297, 224);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 23);
            btncancel.TabIndex = 8;
            btncancel.Text = "Quay lại";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnsignin
            // 
            btnsignin.Location = new Point(157, 224);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(75, 23);
            btnsignin.TabIndex = 7;
            btnsignin.Text = "Nhận mã";
            btnsignin.UseVisualStyleBackColor = true;
            btnsignin.Click += btnsignin_Click;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtname.Location = new Point(52, 168);
            txtname.Name = "txtname";
            txtname.Size = new Size(451, 29);
            txtname.TabIndex = 3;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblname.ForeColor = Color.White;
            lblname.Location = new Point(197, 122);
            lblname.Name = "lblname";
            lblname.Size = new Size(160, 22);
            lblname.TabIndex = 1;
            lblname.Text = "Tên  đăng nhập ";
            // 
            // lblsignin
            // 
            lblsignin.AutoSize = true;
            lblsignin.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblsignin.ForeColor = Color.Transparent;
            lblsignin.Location = new Point(161, 23);
            lblsignin.Name = "lblsignin";
            lblsignin.Size = new Size(225, 34);
            lblsignin.TabIndex = 0;
            lblsignin.Text = "Quên mật khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.z5640227041635_913419bac43fe8f3345320df4365f54d_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(478, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 400);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormQuenMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 961);
            Controls.Add(panel1);
            Name = "FormQuenMK";
            Text = "FormQuenMK";
            Load += FormQuenMK_Load;
            panel1.ResumeLayout(false);
            pnsignin.ResumeLayout(false);
            pnsignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnsignin;
        private Button btncancel;
        private Button btnsignin;
        private TextBox txtname;
        private Label lblname;
        private Label lblsignin;
        private PictureBox pictureBox1;
    }
}