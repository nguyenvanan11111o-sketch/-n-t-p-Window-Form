namespace bai4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            tblViTri = new TableLayoutPanel();
            lblSoLuong = new Label();
            lblTamTinh = new Label();
            cboKhungGio = new ComboBox();
            btnXacNhan = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Location = new Point(322, 0);
            lblTieuDe.Margin = new Padding(6, 0, 6, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(419, 31);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN\r\n";
            // 
            // tblViTri
            // 
            tblViTri.ColumnCount = 2;
            tblViTri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblViTri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblViTri.Location = new Point(133, 44);
            tblViTri.Name = "tblViTri";
            tblViTri.RowCount = 2;
            tblViTri.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblViTri.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblViTri.Size = new Size(570, 179);
            tblViTri.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(135, 253);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(267, 31);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số vị trí đang chọn: 0";
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Location = new Point(133, 363);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(283, 31);
            lblTamTinh.TabIndex = 3;
            lblTamTinh.Text = "Tạm tính tiền: 0 VVNĐ";
            // 
            // cboKhungGio
            // 
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });
            cboKhungGio.Location = new Point(135, 304);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(216, 39);
            cboKhungGio.TabIndex = 4;
            cboKhungGio.Text = "Chọn khung giờ";
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.Location = new Point(322, 418);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(139, 34);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(503, 417);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(164, 35);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy chọn tất cả";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 857);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(cboKhungGio);
            Controls.Add(lblTamTinh);
            Controls.Add(lblSoLuong);
            Controls.Add(tblViTri);
            Controls.Add(lblTieuDe);
            Font = new Font("Microsoft Sans Serif", 16F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private TableLayoutPanel tblViTri;
        private Label lblSoLuong;
        private Label lblTamTinh;
        private ComboBox cboKhungGio;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}
