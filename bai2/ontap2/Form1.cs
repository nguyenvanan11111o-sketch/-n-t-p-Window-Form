namespace ontap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Mức độ ưu tiên
            string uuTien = "";

            if (radioButton1.Checked)
                uuTien = "Thấp";
            else if (radioButton2.Checked)
                uuTien = "Trung bình";
            else if (radioButton3.Checked)
                uuTien = "Khẩn cấp";

            if (uuTien == "")
            {
                MessageBox.Show("Vui lòng chọn mức độ ưu tiên!");
                return;
            }

            // Loại sự cố
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sự cố!");
                return;
            }

            // Thiết bị ảnh hưởng
            string thietBi = "";

            if (checkBox1.Checked)
                thietBi += "Máy tính bàn, ";

            if (checkBox2.Checked)
                thietBi += "Laptop, ";

            if (checkBox3.Checked)
                thietBi += "Máy in, ";

            if (checkBox4.Checked)
                thietBi += "Điện thoại, ";

            if (thietBi == "")
                thietBi = "Không có";
            else
                thietBi = thietBi.TrimEnd(' ', ',');

            // Thông tin ảnh
            string anhLoi = pictureBox1.Image != null
                ? "Đã tải ảnh"
                : "Chưa tải ảnh";

            // Tổng hợp phiếu
            string thongTin =
                "Mã phiếu: " + textBox1.Text +
                "\nNgười yêu cầu: " + textBox2.Text +
                "\nNgày ghi nhận: " +
                dateTimePicker1.Value.ToString("dd/MM/yyyy") +
                "\nMức độ ưu tiên: " + uuTien +
                "\nLoại sự cố: " + comboBox1.Text +
                "\nThiết bị ảnh hưởng: " + thietBi +
                "\nẢnh lỗi: " + anhLoi;

            MessageBox.Show(
                thongTin,
                "THÔNG TIN PHIẾU SỰ CỐ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Chọn ảnh lỗi";
            ofd.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (Image img = Image.FromFile(ofd.FileName))
                {
                    Image anhCu = pictureBox1.Image;
                    pictureBox1.Image = new Bitmap(img);
                    anhCu?.Dispose();
                }

                pictureBox1.SizeMode =
                    PictureBoxSizeMode.StretchImage;
            }

            ofd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            dateTimePicker1.Value = DateTime.Now;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            comboBox1.SelectedIndex = -1;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            Image anhCu = pictureBox1.Image;
            pictureBox1.Image = null;
            anhCu?.Dispose();

            textBox1.Focus();
        }
    }
}
