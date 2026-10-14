namespace On_tap_window_form
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(221, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Làm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(99, 363);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Tính tiền";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(99, 19);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 2;
            label1.Text = "Đơn giá dịch vụ(VNĐ)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 90);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Số lượng khách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 163);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Giảm giá(%)";
            // 
            // label4
            // 
            label4.BackColor = Color.Yellow;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(99, 255);
            label4.Name = "label4";
            label4.Size = new Size(216, 64);
            label4.TabIndex = 5;
            label4.Text = "Tổng tiền";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
