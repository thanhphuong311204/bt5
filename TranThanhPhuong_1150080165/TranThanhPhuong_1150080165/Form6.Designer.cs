namespace TranThanhPhuong_1150080165
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstMatHang;
        private ListBox lstDaChon;
        private Button btnRight, btnRightAll, btnLeft, btnLeftAll;

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
            lstMatHang = new ListBox();
            lstDaChon = new ListBox();
            btnRight = new Button();
            btnRightAll = new Button();
            btnLeft = new Button();
            btnLeftAll = new Button();
            SuspendLayout();
            // 
            // lstMatHang
            // 
            lstMatHang.Items.AddRange(new object[] { "CPU", "MainBoard", "RAM", "Keyboard", "Mouse", "NIC", "FAN" });
            lstMatHang.Location = new Point(20, 40);
            lstMatHang.Name = "lstMatHang";
            lstMatHang.Size = new Size(201, 324);
            lstMatHang.TabIndex = 0;
            // 
            // lstDaChon
            // 
            lstDaChon.Location = new Point(380, 40);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(199, 324);
            lstDaChon.TabIndex = 1;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(260, 60);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(99, 50);
            btnRight.TabIndex = 2;
            btnRight.Text = ">";
            // 
            // btnRightAll
            // 
            btnRightAll.Location = new Point(260, 140);
            btnRightAll.Name = "btnRightAll";
            btnRightAll.Size = new Size(99, 52);
            btnRightAll.TabIndex = 3;
            btnRightAll.Text = ">>";
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(260, 218);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(99, 52);
            btnLeft.TabIndex = 4;
            btnLeft.Text = "<";
            // 
            // btnLeftAll
            // 
            btnLeftAll.Location = new Point(260, 293);
            btnLeftAll.Name = "btnLeftAll";
            btnLeftAll.Size = new Size(99, 61);
            btnLeftAll.TabIndex = 5;
            btnLeftAll.Text = "<<";
            // 
            // Form6
            // 
            ClientSize = new Size(651, 401);
            Controls.Add(lstMatHang);
            Controls.Add(lstDaChon);
            Controls.Add(btnRight);
            Controls.Add(btnRightAll);
            Controls.Add(btnLeft);
            Controls.Add(btnLeftAll);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài tập 7 - ListBox";
            ResumeLayout(false);
        }
    }
}
