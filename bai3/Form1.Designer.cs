namespace ontap3
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            cboDonViTinh = new ComboBox();
            lblDonViTinh = new Label();
            txtTenVT = new TextBox();
            lblTenVT = new Label();
            txtMaVT = new TextBox();
            lblMaVT = new Label();
            groupBox2 = new GroupBox();
            lvVatTu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnXoaTatCa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 1;
            label1.Text = "Quản lý vật tư / Linh kiện";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(lblDonGia);
            groupBox1.Controls.Add(cboDonViTinh);
            groupBox1.Controls.Add(lblDonViTinh);
            groupBox1.Controls.Add(txtTenVT);
            groupBox1.Controls.Add(lblTenVT);
            groupBox1.Controls.Add(txtMaVT);
            groupBox1.Controls.Add(lblMaVT);
            groupBox1.Location = new Point(14, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 250);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vật tư";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(117, 138);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(151, 27);
            txtDonGia.TabIndex = 7;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(6, 138);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(99, 20);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá nhập";
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.Location = new Point(117, 104);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(151, 28);
            cboDonViTinh.TabIndex = 5;
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Location = new Point(6, 102);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(81, 20);
            lblDonViTinh.TabIndex = 4;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(117, 69);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(151, 27);
            txtTenVT.TabIndex = 3;
            // 
            // lblTenVT
            // 
            lblTenVT.AutoSize = true;
            lblTenVT.Location = new Point(6, 68);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(76, 20);
            lblTenVT.TabIndex = 2;
            lblTenVT.Text = "Tên Vật tư";
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(117, 35);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(151, 27);
            txtMaVT.TabIndex = 1;
            // 
            // lblMaVT
            // 
            lblMaVT.AutoSize = true;
            lblMaVT.Location = new Point(6, 34);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(74, 20);
            lblMaVT.TabIndex = 0;
            lblMaVT.Text = "Mã Vật tư";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvVatTu);
            groupBox2.Location = new Point(507, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 245);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách vật tư";
            // 
            // lvVatTu
            // 
            lvVatTu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;
            lvVatTu.Location = new Point(29, 39);
            lvVatTu.MultiSelect = false;
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(186, 167);
            lvVatTu.TabIndex = 0;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            lvVatTu.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã VT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn vị tính ";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 120;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 329);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 75);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(214, 329);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(133, 75);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(386, 329);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 75);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá dòng";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(578, 329);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(144, 66);
            btnXoaTatCa.TabIndex = 7;
            btnXoaTatCa.Text = "Xoá toàn bộ";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Label lblDonGia;
        private ComboBox cboDonViTinh;
        private Label lblDonViTinh;
        private TextBox txtTenVT;
        private Label lblTenVT;
        private TextBox txtMaVT;
        private Label lblMaVT;
        private TextBox txtDonGia;
        private GroupBox groupBox2;
        private ListView lvVatTu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnXoaTatCa;
    }
}
