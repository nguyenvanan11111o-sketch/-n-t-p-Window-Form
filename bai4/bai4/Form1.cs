namespace bai4
{
    public partial class Form1 : Form
    {
        int soViTriDangChon = 0;
        bool[] daDat = new bool[20];
        public Form1()
        {
            InitializeComponent();
        }
            private void buttonViTri_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Nếu vị trí đã đặt thì không cho chọn
            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Vị trí này đã được đặt!");
                return;
            }

            // Nếu đang được chọn
            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.LightGray;
                btn.ForeColor = Color.Black;

                soViTriDangChon--;
            }
            else
            {
                // Chọn vị trí
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;

                soViTriDangChon++;
            }

            CapNhatTien();
        }
        private void CapNhatTien()
        {
            int donGia = 0;

            if (cboKhungGio.SelectedIndex == 0)
            {
                donGia = 100000;
            }
            else if (cboKhungGio.SelectedIndex == 1)
            {
                donGia = 150000;
            }

            int tongTien = soViTriDangChon * donGia;

            lblSoLuong.Text = "Số vị trí đang chọn: " + soViTriDangChon;

            lblTamTinh.Text = "Tạm tính tiền: "
                            + tongTien.ToString("N0")
                            + " VNĐ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tblViTri.RowCount = 4;
            tblViTri.ColumnCount = 5;

            // Xóa cách chia cột/hàng cũ
            tblViTri.ColumnStyles.Clear();
            tblViTri.RowStyles.Clear();

            // Chia đều 5 cột
            for (int i = 0; i < 5; i++)
            {
                tblViTri.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 20F)
                );
            }

            // Chia đều 4 hàng
            for (int i = 0; i < 4; i++)
            {
                tblViTri.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 25F)
                );
            }

            
            int soViTri = 1;
            
            daDat[2] = true;   
            daDat[7] = true;   
            daDat[13] = true;  
            daDat[17] = true;  

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();

                    btn.Text = "Vị trí " + soViTri;
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(5);
                    btn.Font = new Font("Arial", 10, FontStyle.Regular);

                    // Kiểm tra vị trí đã được đặt chưa
                    if (daDat[soViTri - 1])
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = Color.LightGray;
                    }

                    // Gắn sự kiện Click chung
                    btn.Click += buttonViTri_Click;

                    tblViTri.Controls.Add(btn, j, i);

                    soViTri++;
                }
            }

            // Xóa các lựa chọn cũ trong ComboBox
            cboKhungGio.Items.Clear();

            // Thêm khung giờ
            cboKhungGio.Items.Add("Sáng - 100.000đ");
            cboKhungGio.Items.Add("Tối - 150.000đ");

            // Chọn Sáng mặc định
            cboKhungGio.SelectedIndex = 0;
        }
        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTien();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control control in tblViTri.Controls)
            {
                if (control is Button btn)
                {
                    // Chỉ bỏ chọn các vị trí màu xanh
                    if (btn.BackColor == Color.Green)
                    {
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                    }
                }
            }

            soViTriDangChon = 0;

            CapNhatTien();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (soViTriDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!");
                return;
            }

            MessageBox.Show(
                "Đặt vị trí thành công!\n" +
                "Số vị trí: " + soViTriDangChon + "\n" +
                lblTamTinh.Text,
                "Thông báo"
            );

            // Chuyển các vị trí đang chọn thành đã đặt
            foreach (Control control in tblViTri.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.BackColor == Color.Green)
                    {
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;
                    }
                }
            }

            soViTriDangChon = 0;

            CapNhatTien();
        }
    }
}
