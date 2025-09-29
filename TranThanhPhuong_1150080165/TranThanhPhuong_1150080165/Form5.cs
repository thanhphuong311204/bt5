using System;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            // Gắn sự kiện
            this.txtNhapSo.KeyPress += TxtNhapSo_KeyPress;
            this.txtNhapSo.KeyDown += TxtNhapSo_KeyDown;
            this.btnNhapSo.Click += btnNhapSo_Click;
            this.btnTang2.Click += btnTang2_Click;
            this.btnChonChanDau.Click += btnChonChanDau_Click;
            this.btnChonLeCuoi.Click += btnChonLeCuoi_Click;
            this.btnXoaDangChon.Click += btnXoaDangChon_Click;
            this.btnXoaDau.Click += btnXoaDau_Click;
            this.btnXoaCuoi.Click += btnXoaCuoi_Click;
            this.btnXoaDay.Click += btnXoaDay_Click;
            this.btnKetThuc.Click += btnKetThuc_Click;
        }

        private void TxtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void TxtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NhapSo();
                e.SuppressKeyPress = true;
            }
        }

        private void btnNhapSo_Click(object sender, EventArgs e) => NhapSo();

        private void NhapSo()
        {
            if (int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                lsbDaySo.Items.Add(so);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
                lsbDaySo.Items[i] = Convert.ToInt32(lsbDaySo.Items[i]) + 2;
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào!");
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào!");
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            while (lsbDaySo.SelectedIndices.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndices[0]);
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDay_Click(object sender, EventArgs e) => lsbDaySo.Items.Clear();

        private void btnKetThuc_Click(object sender, EventArgs e) => Application.Exit();

        private void lblNhapSo_Click(object sender, EventArgs e)
        {

        }

        private void grpChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoaCuoi_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoaDangChon_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChonChanDau_Click_1(object sender, EventArgs e)
        {

        }
    }
}
