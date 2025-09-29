using System;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            // Gán sự kiện cho các nút
            btnRight.Click += btnRight_Click;
            btnRightAll.Click += btnRightAll_Click;
            btnLeft.Click += btnLeft_Click;
            btnLeftAll.Click += btnLeftAll_Click;
        }

        // Chuyển 1 mục sang phải
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedItem != null)
            {
                lstDaChon.Items.Add(lstMatHang.SelectedItem);
                lstMatHang.Items.Remove(lstMatHang.SelectedItem);
            }
        }

        // Chuyển tất cả sang phải
        private void btnRightAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstMatHang.Items)
                lstDaChon.Items.Add(item);

            lstMatHang.Items.Clear();
        }

        // Chuyển 1 mục về trái
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstDaChon.SelectedItem != null)
            {
                lstMatHang.Items.Add(lstDaChon.SelectedItem);
                lstDaChon.Items.Remove(lstDaChon.SelectedItem);
            }
        }

        // Chuyển tất cả về trái
        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDaChon.Items)
                lstMatHang.Items.Add(item);

            lstDaChon.Items.Clear();
        }
    }
}
