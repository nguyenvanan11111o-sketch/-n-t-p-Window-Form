namespace On_tap_window_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double donGia;
            int soLuong;
            double giamGia;

            if (!double.TryParse(textBox1.Text, out donGia))
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out soLuong))
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ!");
                textBox2.Focus();
                return;
            }

            if (!double.TryParse(textBox3.Text, out giamGia))
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ!");
                textBox3.Focus();
                return;
            }

            if (donGia < 0 || soLuong < 0 || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            double tongTien = (donGia * soLuong) * (100 - giamGia) / 100;

            label4.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label4.Text = "Tổng tiền";

            textBox1.Focus();
        }
    }
}