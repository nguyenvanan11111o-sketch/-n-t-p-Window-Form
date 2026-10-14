namespace ontap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVatTu.SelectedItems[0];

                txtMaVT.Text = item.SubItems[0].Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDonViTinh.Text = item.SubItems[2].Text;
                txtDonGia.Text = item.SubItems[3].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            string ma = txtMaVT.Text.Trim();

            if (KiemTraTrung(ma))
            {
                MessageBox.Show("Mã vật tư đã tồn tại!");
                return;
            }

            ListViewItem item = new ListViewItem(ma);

            item.SubItems.Add(txtTenVT.Text.Trim());
            item.SubItems.Add(cboDonViTinh.Text);
            item.SubItems.Add(txtDonGia.Text.Trim());

            lvVatTu.Items.Add(item);

            MessageBox.Show("Thêm thành công!");
            XoaTrang();
        }
        private bool KiemTra()
        {
            decimal gia;

            if (txtMaVT.Text.Trim() == "" ||
                txtTenVT.Text.Trim() == "" ||
                cboDonViTinh.SelectedIndex == -1 ||
                !decimal.TryParse(txtDonGia.Text, out gia) ||
                gia < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!");
                return false;
            }

            return true;
        }

        private bool KiemTraTrung(string ma)
        {
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void XoaTrang()
        {
            lvVatTu.SelectedItems.Clear();
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            cboDonViTinh.SelectedIndex = -1;
            txtMaVT.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần cập nhật!");
                return;
            }

            if (!KiemTra()) return;

            ListViewItem item = lvVatTu.SelectedItems[0];
            string ma = txtMaVT.Text.Trim();

            // Kiểm tra mã trùng với dòng khác
            foreach (ListViewItem vt in lvVatTu.Items)
            {
                if (vt != item &&
                    vt.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!");
                    return;
                }
            }

            item.SubItems[0].Text = ma;
            item.SubItems[1].Text = txtTenVT.Text.Trim();
            item.SubItems[2].Text = cboDonViTinh.Text;
            item.SubItems[3].Text = txtDonGia.Text.Trim();

            MessageBox.Show("Cập nhật thành công!");
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa vật tư này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);

                XoaTrang();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ danh sách?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();

                XoaTrang();
                MessageBox.Show("Đã xóa toàn bộ!");
            }
        }
    }
}
