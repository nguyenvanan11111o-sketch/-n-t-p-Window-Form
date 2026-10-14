namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void CapNhatTong()
        {
            int tongSoLuong = 0;
            double tongTrongLuong = 0;
            double tongTien = 0;

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int soLuong = 0;
                double trongLuong = 0;
                double donGia = 0;

                int.TryParse(
                    Convert.ToString(row.Cells["colSoLuong"].Value),
                    out soLuong);

                double.TryParse(
                    Convert.ToString(row.Cells["colTrongLuong"].Value),
                    out trongLuong);

                double.TryParse(
                    Convert.ToString(row.Cells["colDonGia"].Value),
                    out donGia);

                double thanhTien = soLuong * donGia;

                row.Cells["colThanhTien"].Value = thanhTien;

                tongSoLuong += soLuong;
                tongTrongLuong += trongLuong;
                tongTien += thanhTien;
            }

            lblTongSoLuong.Text =
                "Số lượng: " + tongSoLuong;

            lblTongTrongLuong.Text =
                "Trọng lượng: " +
                tongTrongLuong.ToString("0.##") +
                " kg";

            lblTongTien.Text =
                "Tổng tiền: " +
                tongTien.ToString("N0") +
                " VNĐ";
        }

        private void dgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CapNhatTong();
            }
        }

        private void dgvHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn F2 để thêm dòng
            if (e.KeyCode == Keys.F2)
            {
                int rowIndex = dgvHangHoa.Rows.Add();

                dgvHangHoa.CurrentCell =
                    dgvHangHoa.Rows[rowIndex].Cells["colTenHang"];

                e.Handled = true;
            }

            // Nhấn Delete để xóa dòng
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvHangHoa.CurrentRow != null &&
                    !dgvHangHoa.CurrentRow.IsNewRow)
                {
                    dgvHangHoa.Rows.Remove(dgvHangHoa.CurrentRow);
                    CapNhatTong();
                }

                e.Handled = true;
            }
        }

        private void dgvHangHoa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Kiểm tra Số lượng
            if (e.ColumnIndex == dgvHangHoa.Columns["colSoLuong"].Index)
            {
                if (!int.TryParse(e.FormattedValue?.ToString(), out int soLuong)
                    || soLuong <= 0)
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText =
                        "Số lượng phải lớn hơn 0!";

                    e.Cancel = true;
                    return;
                }
            }

            // Kiểm tra Trọng lượng
            if (e.ColumnIndex == dgvHangHoa.Columns["colTrongLuong"].Index)
            {
                if (!double.TryParse(e.FormattedValue?.ToString(), out double trongLuong)
                    || trongLuong <= 0)
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText =
                        "Trọng lượng phải lớn hơn 0!";

                    e.Cancel = true;
                    return;
                }
            }
        }

        private void dgvHangHoa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvHangHoa.Rows[e.RowIndex].ErrorText = "";

            CapNhatTong();
        }
    }
}
