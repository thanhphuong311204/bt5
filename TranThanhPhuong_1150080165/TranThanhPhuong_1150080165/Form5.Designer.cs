namespace TranThanhPhuong_1150080165
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle, lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnNhapSo, btnTang2, btnChonChanDau, btnChonLeCuoi,
                       btnXoaDangChon, btnXoaDau, btnXoaCuoi, btnXoaDay, btnKetThuc;
        private ListBox lsbDaySo;
        private GroupBox grpChucNang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblNhapSo = new Label();
            txtNhapSo = new TextBox();
            btnNhapSo = new Button();
            lsbDaySo = new ListBox();
            grpChucNang = new GroupBox();
            btnTang2 = new Button();
            btnChonChanDau = new Button();
            btnChonLeCuoi = new Button();
            btnXoaDangChon = new Button();
            btnXoaDau = new Button();
            btnXoaCuoi = new Button();
            btnKetThuc = new Button();
            btnXoaDay = new Button();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(798, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ứng dụng xử lý dãy số";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            lblNhapSo.AutoSize = true;
            lblNhapSo.Location = new Point(0, 59);
            lblNhapSo.Name = "lblNhapSo";
            lblNhapSo.Size = new Size(217, 37);
            lblNhapSo.TabIndex = 1;
            lblNhapSo.Text = "Nhập số nguyên:";
            lblNhapSo.Click += lblNhapSo_Click;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(223, 67);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(150, 43);
            txtNhapSo.TabIndex = 2;
            // 
            // btnNhapSo
            // 
            btnNhapSo.Location = new Point(421, 71);
            btnNhapSo.Name = "btnNhapSo";
            btnNhapSo.Size = new Size(147, 39);
            btnNhapSo.TabIndex = 3;
            btnNhapSo.Text = "Nhập số";
            // 
            // lsbDaySo
            // 
            lsbDaySo.ItemHeight = 37;
            lsbDaySo.Location = new Point(34, 174);
            lsbDaySo.Name = "lsbDaySo";
            lsbDaySo.Size = new Size(212, 226);
            lsbDaySo.TabIndex = 4;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnTang2);
            grpChucNang.Controls.Add(btnChonChanDau);
            grpChucNang.Controls.Add(btnChonLeCuoi);
            grpChucNang.Controls.Add(btnXoaDangChon);
            grpChucNang.Controls.Add(btnXoaDau);
            grpChucNang.Controls.Add(btnXoaCuoi);
            grpChucNang.Location = new Point(354, 116);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(432, 417);
            grpChucNang.TabIndex = 5;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng:";
            grpChucNang.Enter += grpChucNang_Enter;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(30, 42);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(264, 55);
            btnTang2.TabIndex = 0;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            // 
            // btnChonChanDau
            // 
            btnChonChanDau.Location = new Point(30, 103);
            btnChonChanDau.Name = "btnChonChanDau";
            btnChonChanDau.Size = new Size(264, 58);
            btnChonChanDau.TabIndex = 1;
            btnChonChanDau.Text = "Chọn số chẵn đầu";
            btnChonChanDau.Click += btnChonChanDau_Click_1;
            // 
            // btnChonLeCuoi
            // 
            btnChonLeCuoi.Location = new Point(30, 167);
            btnChonLeCuoi.Name = "btnChonLeCuoi";
            btnChonLeCuoi.Size = new Size(264, 51);
            btnChonLeCuoi.TabIndex = 2;
            btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.Location = new Point(30, 224);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(264, 47);
            btnXoaDangChon.TabIndex = 3;
            btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            btnXoaDangChon.Click += btnXoaDangChon_Click_1;
            // 
            // btnXoaDau
            // 
            btnXoaDau.Location = new Point(30, 286);
            btnXoaDau.Name = "btnXoaDau";
            btnXoaDau.Size = new Size(264, 47);
            btnXoaDau.TabIndex = 4;
            btnXoaDau.Text = "Xóa phần tử đầu";
            // 
            // btnXoaCuoi
            // 
            btnXoaCuoi.Location = new Point(30, 348);
            btnXoaCuoi.Name = "btnXoaCuoi";
            btnXoaCuoi.Size = new Size(264, 51);
            btnXoaCuoi.TabIndex = 5;
            btnXoaCuoi.Text = "Xóa phần tử cuối";
            btnXoaCuoi.Click += btnXoaCuoi_Click_1;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.Maroon;
            btnKetThuc.ForeColor = Color.White;
            btnKetThuc.Location = new Point(12, 539);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(217, 51);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Kết thúc ứng dụng";
            btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // btnXoaDay
            // 
            btnXoaDay.BackColor = Color.Black;
            btnXoaDay.ForeColor = Color.White;
            btnXoaDay.Location = new Point(421, 539);
            btnXoaDay.Name = "btnXoaDay";
            btnXoaDay.Size = new Size(197, 51);
            btnXoaDay.TabIndex = 7;
            btnXoaDay.Text = "Xóa dãy số";
            btnXoaDay.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            ClientSize = new Size(798, 672);
            Controls.Add(lblTitle);
            Controls.Add(lblNhapSo);
            Controls.Add(txtNhapSo);
            Controls.Add(btnNhapSo);
            Controls.Add(lsbDaySo);
            Controls.Add(grpChucNang);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaDay);
            Font = new Font("Segoe UI", 10F);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng xử lý dãy số";
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
