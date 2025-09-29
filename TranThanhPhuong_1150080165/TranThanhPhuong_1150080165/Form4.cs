using System;
using System.Drawing;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            double tongTien = 0;

            if (chkLayCaoRang.Checked) tongTien += 50000;
            if (chkTayTrangRang.Checked) tongTien += 100000;
            if (chkHanRang.Checked) tongTien += (100000 * (int)numHanRang.Value);
            if (chkBeRang.Checked) tongTien += (10000 * (int)numBeRang.Value);
            if (chkBocRang.Checked) tongTien += (1000000 * (int)numBocRang.Value);

            MessageBox.Show($"Khách hàng: {txtTenKH.Text}\nTổng tiền: {tongTien:N0} VNĐ",
                "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLayCaoRang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
