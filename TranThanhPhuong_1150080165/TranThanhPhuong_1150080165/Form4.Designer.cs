using System.Drawing;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    partial class Form4
    {
        private Label lblTenKH;
        private TextBox txtTenKH;
        private GroupBox grpDichVu;
        private CheckBox chkLayCaoRang;
        private CheckBox chkTayTrangRang;
        private CheckBox chkHanRang;
        private CheckBox chkBeRang;
        private CheckBox chkBocRang;
        private NumericUpDown numHanRang;
        private NumericUpDown numBeRang;
        private NumericUpDown numBocRang;
        private GroupBox grpChucNang;
        private Button btnTinhTien;
        private Button btnThoat;
        private Label lblHeader;

        private void InitializeComponent()
        {
            lblHeader = new Label();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            grpDichVu = new GroupBox();
            chkLayCaoRang = new CheckBox();
            chkTayTrangRang = new CheckBox();
            chkHanRang = new CheckBox();
            numHanRang = new NumericUpDown();
            chkBeRang = new CheckBox();
            numBeRang = new NumericUpDown();
            chkBocRang = new CheckBox();
            numBocRang = new NumericUpDown();
            grpChucNang = new GroupBox();
            btnTinhTien = new Button();
            btnThoat = new Button();
            grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHanRang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBeRang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBocRang).BeginInit();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.LimeGreen;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(682, 57);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(20, 60);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(206, 37);
            lblTenKH.TabIndex = 1;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(240, 60);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(300, 43);
            txtTenKH.TabIndex = 2;
            // 
            // grpDichVu
            // 
            grpDichVu.Controls.Add(chkLayCaoRang);
            grpDichVu.Controls.Add(chkTayTrangRang);
            grpDichVu.Controls.Add(chkHanRang);
            grpDichVu.Controls.Add(numHanRang);
            grpDichVu.Controls.Add(chkBeRang);
            grpDichVu.Controls.Add(numBeRang);
            grpDichVu.Controls.Add(chkBocRang);
            grpDichVu.Controls.Add(numBocRang);
            grpDichVu.Location = new Point(20, 100);
            grpDichVu.Name = "grpDichVu";
            grpDichVu.Size = new Size(619, 293);
            grpDichVu.TabIndex = 3;
            grpDichVu.TabStop = false;
            grpDichVu.Text = "Dịch vụ tại phòng khám:";
            // 
            // chkLayCaoRang
            // 
            chkLayCaoRang.Location = new Point(20, 53);
            chkLayCaoRang.Name = "chkLayCaoRang";
            chkLayCaoRang.Size = new Size(213, 40);
            chkLayCaoRang.TabIndex = 0;
            chkLayCaoRang.Text = "Lấy cao răng        50.000đ/2 hàm";
            chkLayCaoRang.CheckedChanged += chkLayCaoRang_CheckedChanged;
            // 
            // chkTayTrangRang
            // 
            chkTayTrangRang.Location = new Point(20, 99);
            chkTayTrangRang.Name = "chkTayTrangRang";
            chkTayTrangRang.Size = new Size(337, 40);
            chkTayTrangRang.TabIndex = 1;
            chkTayTrangRang.Text = "Tẩy trắng răng    100.000đ/2 hàm";
            // 
            // chkHanRang
            // 
            chkHanRang.Location = new Point(20, 133);
            chkHanRang.Name = "chkHanRang";
            chkHanRang.Size = new Size(334, 45);
            chkHanRang.TabIndex = 2;
            chkHanRang.Text = "Hàn răng           100.000đ/1 răng";
            // 
            // numHanRang
            // 
            numHanRang.Location = new Point(400, 135);
            numHanRang.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numHanRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numHanRang.Name = "numHanRang";
            numHanRang.Size = new Size(120, 43);
            numHanRang.TabIndex = 3;
            numHanRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkBeRang
            // 
            chkBeRang.Location = new Point(20, 184);
            chkBeRang.Name = "chkBeRang";
            chkBeRang.Size = new Size(168, 39);
            chkBeRang.TabIndex = 4;
            chkBeRang.Text = "Bẻ răng             10.000đ/1 răng";
            // 
            // numBeRang
            // 
            numBeRang.Location = new Point(400, 190);
            numBeRang.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numBeRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBeRang.Name = "numBeRang";
            numBeRang.Size = new Size(120, 43);
            numBeRang.TabIndex = 5;
            numBeRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkBocRang
            // 
            chkBocRang.Location = new Point(20, 227);
            chkBocRang.Name = "chkBocRang";
            chkBocRang.Size = new Size(168, 42);
            chkBocRang.TabIndex = 6;
            chkBocRang.Text = "Bọc răng        1.000.000đ/1 răng";
            // 
            // numBocRang
            // 
            numBocRang.Location = new Point(400, 239);
            numBocRang.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numBocRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBocRang.Name = "numBocRang";
            numBocRang.Size = new Size(120, 43);
            numBocRang.TabIndex = 7;
            numBocRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnTinhTien);
            grpChucNang.Controls.Add(btnThoat);
            grpChucNang.Location = new Point(20, 388);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(562, 103);
            grpChucNang.TabIndex = 4;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng:";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(62, 53);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(86, 44);
            btnTinhTien.TabIndex = 0;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(261, 59);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(93, 44);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // Form4
            // 
            ClientSize = new Size(682, 525);
            Controls.Add(lblHeader);
            Controls.Add(lblTenKH);
            Controls.Add(txtTenKH);
            Controls.Add(grpDichVu);
            Controls.Add(grpChucNang);
            Font = new Font("Segoe UI", 10F);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng khám nha khoa Hải Âu";
            grpDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numHanRang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBeRang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBocRang).EndInit();
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
