namespace bai5
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
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            splitContainer1 = new SplitContainer();
            lblSoDienThoai = new Label();
            lblKhachHang = new Label();
            lblMaDon = new Label();
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSoLuong = new ToolStripStatusLabel();
            lblTongTrongLuong = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            dgvHangHoa = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabKhachHang = new TabPage();
            tabVanChuyen = new TabPage();
            txtMaDon = new TextBox();
            txtSoDienThoai = new TextBox();
            txtKhachHang = new TextBox();
            lblLoaiVanChuyen = new Label();
            lblThongTinKH = new Label();
            cboLoaiVanChuyen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            tabKhachHang.SuspendLayout();
            tabVanChuyen.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 18F);
            lblTieuDe.Location = new Point(288, 75);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(397, 36);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ ĐƠN GIAO HÀNG";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Panel2.Controls.Add(dgvHangHoa);
            splitContainer1.Size = new Size(1182, 653);
            splitContainer1.SplitterDistance = 394;
            splitContainer1.TabIndex = 1;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(42, 198);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(42, 150);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(89, 20);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // lblMaDon
            // 
            lblMaDon.AutoSize = true;
            lblMaDon.Location = new Point(42, 98);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(67, 20);
            lblMaDon.TabIndex = 1;
            lblMaDon.Text = "Mã đơn: ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblTongSoLuong, lblTongTrongLuong, lblTongTien });
            statusStrip1.Location = new Point(0, 627);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(74, 20);
            lblThoiGian.Text = "Thời gian:";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(84, 20);
            lblTongSoLuong.Text = "Số lượng: 0";
            // 
            // lblTongTrongLuong
            // 
            lblTongTrongLuong.Name = "lblTongTrongLuong";
            lblTongTrongLuong.Size = new Size(125, 20);
            lblTongTrongLuong.Text = "Trọng lượng: 0 kg";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(122, 20);
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(0, 0);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(784, 653);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellEndEdit += dgvHangHoa_CellEndEdit;
            dgvHangHoa.CellValidating += dgvHangHoa_CellValidating;
            dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
            dgvHangHoa.KeyDown += dgvHangHoa_KeyDown;
            // 
            // colTenHang
            // 
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            colTrongLuong.HeaderText = "Trọng lượng(kg)";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabKhachHang);
            tabControl1.Controls.Add(tabVanChuyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(394, 653);
            tabControl1.TabIndex = 9;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Controls.Add(lblThongTinKH);
            tabKhachHang.Controls.Add(txtKhachHang);
            tabKhachHang.Controls.Add(txtSoDienThoai);
            tabKhachHang.Controls.Add(txtMaDon);
            tabKhachHang.Controls.Add(lblMaDon);
            tabKhachHang.Controls.Add(lblSoDienThoai);
            tabKhachHang.Controls.Add(lblKhachHang);
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(386, 620);
            tabKhachHang.TabIndex = 0;
            tabKhachHang.Text = "Khách hàng";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabVanChuyen
            // 
            tabVanChuyen.Controls.Add(cboLoaiVanChuyen);
            tabVanChuyen.Controls.Add(lblLoaiVanChuyen);
            tabVanChuyen.Location = new Point(4, 29);
            tabVanChuyen.Name = "tabVanChuyen";
            tabVanChuyen.Padding = new Padding(3);
            tabVanChuyen.Size = new Size(386, 620);
            tabVanChuyen.TabIndex = 1;
            tabVanChuyen.Text = "Vận chuyển";
            tabVanChuyen.UseVisualStyleBackColor = true;
            // 
            // txtMaDon
            // 
            txtMaDon.Location = new Point(185, 98);
            txtMaDon.Name = "txtMaDon";
            txtMaDon.Size = new Size(125, 27);
            txtMaDon.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(185, 198);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 8;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Location = new Point(185, 143);
            txtKhachHang.Multiline = true;
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(125, 27);
            txtKhachHang.TabIndex = 9;
            // 
            // lblLoaiVanChuyen
            // 
            lblLoaiVanChuyen.AutoSize = true;
            lblLoaiVanChuyen.Location = new Point(47, 112);
            lblLoaiVanChuyen.Name = "lblLoaiVanChuyen";
            lblLoaiVanChuyen.Size = new Size(117, 20);
            lblLoaiVanChuyen.TabIndex = 7;
            lblLoaiVanChuyen.Text = "Loại vận chuyển:";
            // 
            // lblThongTinKH
            // 
            lblThongTinKH.AutoSize = true;
            lblThongTinKH.Location = new Point(108, 26);
            lblThongTinKH.Name = "lblThongTinKH";
            lblThongTinKH.Size = new Size(187, 20);
            lblThongTinKH.TabIndex = 10;
            lblThongTinKH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // cboLoaiVanChuyen
            // 
            cboLoaiVanChuyen.FormattingEnabled = true;
            cboLoaiVanChuyen.Items.AddRange(new object[] { "Giao thường", "Giao nhanh", "Hỏa tốc" });
            cboLoaiVanChuyen.Location = new Point(197, 104);
            cboLoaiVanChuyen.Name = "cboLoaiVanChuyen";
            cboLoaiVanChuyen.Size = new Size(151, 28);
            cboLoaiVanChuyen.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(splitContainer1);
            Controls.Add(lblTieuDe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn giao hàng";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabControl1.ResumeLayout(false);
            tabKhachHang.ResumeLayout(false);
            tabKhachHang.PerformLayout();
            tabVanChuyen.ResumeLayout(false);
            tabVanChuyen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private SplitContainer splitContainer1;
        private Label lblKhachHang;
        private Label lblMaDon;
        private Label lblSoDienThoai;
        private DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSoLuong;
        private ToolStripStatusLabel lblTongTrongLuong;
        private ToolStripStatusLabel lblTongTien;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabKhachHang;
        private TabPage tabVanChuyen;
        private TextBox txtKhachHang;
        private TextBox txtSoDienThoai;
        private TextBox txtMaDon;
        private Label lblThongTinKH;
        private ComboBox cboLoaiVanChuyen;
        private Label lblLoaiVanChuyen;
    }
}
