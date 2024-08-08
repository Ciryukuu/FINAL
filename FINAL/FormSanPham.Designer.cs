namespace FINAL
{
    partial class FormSanPham
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
            pngoc = new Panel();
            btn_ctsp = new Button();
            dtg_full = new DataGridView();
            cb_trangthai = new ComboBox();
            pngoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_full).BeginInit();
            SuspendLayout();
            // 
            // pngoc
            // 
            pngoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pngoc.BackColor = Color.Transparent;
            pngoc.Controls.Add(btn_ctsp);
            pngoc.Controls.Add(dtg_full);
            pngoc.Controls.Add(cb_trangthai);
            pngoc.Location = new Point(77, 12);
            pngoc.Name = "pngoc";
            pngoc.Size = new Size(1333, 567);
            pngoc.TabIndex = 0;
            pngoc.Paint += pngoc_Paint;
            // 
            // btn_ctsp
            // 
            btn_ctsp.Location = new Point(1161, 89);
            btn_ctsp.Name = "btn_ctsp";
            btn_ctsp.Size = new Size(148, 90);
            btn_ctsp.TabIndex = 75;
            btn_ctsp.Text = "Chi tiết sản phẩm ";
            btn_ctsp.UseVisualStyleBackColor = true;
            btn_ctsp.Click += btn_ctsp_Click;
            // 
            // dtg_full
            // 
            dtg_full.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_full.Location = new Point(3, 89);
            dtg_full.Name = "dtg_full";
            dtg_full.Size = new Size(1142, 437);
            dtg_full.TabIndex = 73;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "Đang bán", "Hết hàng", "Tất cả" });
            cb_trangthai.Location = new Point(941, 42);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(204, 23);
            cb_trangthai.TabIndex = 74;
            cb_trangthai.SelectedIndexChanged += cb_trangthai_SelectedIndexChanged;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 617);
            Controls.Add(pngoc);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            pngoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_full).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pngoc;
        private Button btn_ctsp;
        private DataGridView dtg_full;
        private ComboBox cb_trangthai;
    }
}