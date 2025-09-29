using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    public class Form1 : Form
    {
        private Label lblTitle;
        private Label lblA;
        private Label lblB;
        private Label lblKetQua;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnThoat;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblA = new Label();
            lblB = new Label();
            lblKetQua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitle.Location = new Point(70, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(694, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THỰC HIỆN CÁC PHÉP TÍNH SỐ HỌC";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Arial", 10F);
            lblA.ForeColor = Color.FromArgb(51, 51, 51);
            lblA.Location = new Point(115, 88);
            lblA.Name = "lblA";
            lblA.Size = new Size(146, 32);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập số a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Arial", 10F);
            lblB.ForeColor = Color.FromArgb(51, 51, 51);
            lblB.Location = new Point(115, 136);
            lblB.Name = "lblB";
            lblB.Size = new Size(146, 32);
            lblB.TabIndex = 3;
            lblB.Text = "Nhập số b:";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Arial", 10F);
            lblKetQua.ForeColor = Color.FromArgb(51, 51, 51);
            lblKetQua.Location = new Point(115, 295);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(116, 32);
            lblKetQua.TabIndex = 9;
            lblKetQua.Text = "Kết quả:";
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Font = new Font("Arial", 10F);
            txtA.Location = new Point(290, 90);
            txtA.Name = "txtA";
            txtA.Size = new Size(250, 38);
            txtA.TabIndex = 2;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Font = new Font("Arial", 10F);
            txtB.Location = new Point(290, 136);
            txtB.Name = "txtB";
            txtB.Size = new Size(250, 38);
            txtB.TabIndex = 4;
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.FromArgb(248, 248, 248);
            txtKetQua.BorderStyle = BorderStyle.FixedSingle;
            txtKetQua.Font = new Font("Arial", 10F);
            txtKetQua.Location = new Point(290, 293);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(250, 38);
            txtKetQua.TabIndex = 10;
            // 
            // btnCong
            // 
            btnCong.BackColor = Color.FromArgb(230, 230, 230);
            btnCong.Cursor = Cursors.Hand;
            btnCong.FlatStyle = FlatStyle.Popup;
            btnCong.Font = new Font("Arial", 10F);
            btnCong.Location = new Point(99, 219);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(117, 40);
            btnCong.TabIndex = 5;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = Color.FromArgb(230, 230, 230);
            btnTru.Cursor = Cursors.Hand;
            btnTru.FlatStyle = FlatStyle.Popup;
            btnTru.Font = new Font("Arial", 10F);
            btnTru.Location = new Point(290, 219);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(114, 40);
            btnTru.TabIndex = 6;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.FromArgb(230, 230, 230);
            btnNhan.Cursor = Cursors.Hand;
            btnNhan.FlatStyle = FlatStyle.Popup;
            btnNhan.Font = new Font("Arial", 10F);
            btnNhan.Location = new Point(494, 219);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(106, 40);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = Color.FromArgb(230, 230, 230);
            btnChia.Cursor = Cursors.Hand;
            btnChia.FlatStyle = FlatStyle.Popup;
            btnChia.Font = new Font("Arial", 10F);
            btnChia.Location = new Point(666, 219);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(101, 40);
            btnChia.TabIndex = 8;
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 193, 7);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Arial", 10F);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(290, 386);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 41);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(220, 53, 69);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Arial", 10F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(460, 386);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 41);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(808, 540);
            Controls.Add(lblTitle);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thực hành 1";
            ResumeLayout(false);
            PerformLayout();
        }

        // Hàm kiểm tra và lấy số từ textbox
        private bool LayGiaTri(out double a, out double b)
        {
            bool hopLe1 = double.TryParse(txtA.Text.Trim(), out a);
            bool hopLe2 = double.TryParse(txtB.Text.Trim(), out b);

            if (!hopLe1 || !hopLe2)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Event handler cho button Cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double ketQua = a + b;
                txtKetQua.Text = ketQua.ToString("0.####");
            }
        }

        // Event handler cho button Trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double ketQua = a - b;
                txtKetQua.Text = ketQua.ToString("0.####");
            }
        }

        // Event handler cho button Nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double ketQua = a * b;
                txtKetQua.Text = ketQua.ToString("0.####");
            }
        }

        // Event handler cho button Chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi toán học",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double ketQua = a / b;
                txtKetQua.Text = ketQua.ToString("0.####");
            }
        }

        // Event handler cho button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus(); // Đặt con trở về ô nhập đầu tiên
        }

        // Event handler cho button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt focus vào textbox đầu tiên khi form load
            txtA.Focus();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
