using System;
using System.Drawing;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    public class Form2 : Form
    {
        private GroupBox grpNhap, grpChon, grpKetQua;
        private Label lblA, lblB, lblKetQua;
        private TextBox txtA, txtB, txtKetQua;
        private RadioButton rdoUSCLN, rdoBSCNN;
        private Button btnTim, btnThoat;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            grpNhap = new GroupBox();
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            grpChon = new GroupBox();
            rdoUSCLN = new RadioButton();
            rdoBSCNN = new RadioButton();
            grpKetQua = new GroupBox();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            btnTim = new Button();
            btnThoat = new Button();
            grpNhap.SuspendLayout();
            grpChon.SuspendLayout();
            grpKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhap
            // 
            grpNhap.BackColor = Color.LightGreen;
            grpNhap.Controls.Add(lblA);
            grpNhap.Controls.Add(txtA);
            grpNhap.Controls.Add(lblB);
            grpNhap.Controls.Add(txtB);
            grpNhap.Location = new Point(20, 20);
            grpNhap.Name = "grpNhap";
            grpNhap.Size = new Size(459, 185);
            grpNhap.TabIndex = 0;
            grpNhap.TabStop = false;
            grpNhap.Text = "Nhập dữ liệu:";
            // 
            // lblA
            // 
            lblA.Location = new Point(6, 33);
            lblA.Name = "lblA";
            lblA.Size = new Size(213, 80);
            lblA.TabIndex = 0;
            lblA.Text = "Số nguyên a:";
            // 
            // txtA
            // 
            txtA.Location = new Point(242, 30);
            txtA.Name = "txtA";
            txtA.Size = new Size(180, 43);
            txtA.TabIndex = 1;
            // 
            // lblB
            // 
            lblB.Location = new Point(12, 110);
            lblB.Name = "lblB";
            lblB.Size = new Size(207, 75);
            lblB.TabIndex = 2;
            lblB.Text = "Số nguyên b:";
            // 
            // txtB
            // 
            txtB.Location = new Point(242, 111);
            txtB.Name = "txtB";
            txtB.Size = new Size(180, 43);
            txtB.TabIndex = 3;
            // 
            // grpChon
            // 
            grpChon.BackColor = Color.LightGray;
            grpChon.Controls.Add(rdoUSCLN);
            grpChon.Controls.Add(rdoBSCNN);
            grpChon.Location = new Point(498, 20);
            grpChon.Name = "grpChon";
            grpChon.Size = new Size(216, 185);
            grpChon.TabIndex = 1;
            grpChon.TabStop = false;
            grpChon.Text = "Tùy chọn:";
            // 
            // rdoUSCLN
            // 
            rdoUSCLN.Location = new Point(20, 42);
            rdoUSCLN.Name = "rdoUSCLN";
            rdoUSCLN.Size = new Size(165, 46);
            rdoUSCLN.TabIndex = 0;
            rdoUSCLN.Text = "USCLN";
            // 
            // rdoBSCNN
            // 
            rdoBSCNN.Location = new Point(12, 103);
            rdoBSCNN.Name = "rdoBSCNN";
            rdoBSCNN.Size = new Size(159, 51);
            rdoBSCNN.TabIndex = 1;
            rdoBSCNN.Text = "BSCNN";
            // 
            // grpKetQua
            // 
            grpKetQua.Controls.Add(lblKetQua);
            grpKetQua.Controls.Add(txtKetQua);
            grpKetQua.Controls.Add(btnTim);
            grpKetQua.Location = new Point(12, 228);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Size = new Size(604, 138);
            grpKetQua.TabIndex = 2;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            lblKetQua.Location = new Point(8, 60);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(154, 57);
            lblKetQua.TabIndex = 0;
            lblKetQua.Text = "Kết quả:";
            lblKetQua.Click += lblKetQua_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(180, 71);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(250, 43);
            txtKetQua.TabIndex = 1;
            txtKetQua.TextChanged += txtKetQua_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(468, 42);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(93, 72);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.Click += BtnTim_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(480, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.Click += BtnThoat_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(773, 408);
            Controls.Add(grpNhap);
            Controls.Add(grpChon);
            Controls.Add(grpKetQua);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            grpNhap.ResumeLayout(false);
            grpNhap.PerformLayout();
            grpChon.ResumeLayout(false);
            grpKetQua.ResumeLayout(false);
            grpKetQua.PerformLayout();
            ResumeLayout(false);
        }

        // Hàm tính USCLN
        private int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Hàm tính BSCNN
        private int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) ||
                !int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdoUSCLN.Checked)
            {
                txtKetQua.Text = USCLN(a, b).ToString();
            }
            else if (rdoBSCNN.Checked)
            {
                txtKetQua.Text = BSCNN(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpKetQua_Enter(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
