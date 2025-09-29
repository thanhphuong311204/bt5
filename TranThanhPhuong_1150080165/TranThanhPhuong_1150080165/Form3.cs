using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TranThanhPhuong_1150080165
{
    public partial class Form3 : Form
    {
        // Map password và nhóm
        private Dictionary<string, string> passwordMap = new Dictionary<string, string>()
        {
            {"1496", "Phát triển công nghệ"},
            {"2673", "Phát triển công nghệ"},
            {"7462", "Nghiên cứu viên"},
            {"8884", "Thiết kế mô hình"},
            {"3842", "Thiết kế mô hình"},
            {"3383", "Thiết kế mô hình"}
        };

        public Form3()
        {
            InitializeComponent();
            InitKeyPad(); // thêm các nút số vào groupBox Keyboard
        }

        // Tạo bàn phím số 1–9
        private void InitKeyPad()
        {
            int xStart = 20, yStart = 30;
            int w = 60, h = 35, gap = 10;
            int num = 1;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button btn = new Button();
                    btn.Text = num.ToString();
                    btn.Size = new Size(w, h);
                    btn.Location = new Point(xStart + col * (w + gap), yStart + row * (h + gap));
                    btn.Click += NumButton_Click;
                    grpKeyboard.Controls.Add(btn);
                    num++;
                }
            }
        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                txtPassword.Text += btn.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text.Trim();
            string group = "Không có";
            string result;

            if (passwordMap.ContainsKey(pwd))
            {
                group = passwordMap[pwd];
                result = "Chấp nhận!";
            }
            else
            {
                result = "Từ chối!";
            }

            dgvLog.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), group, result);
            txtPassword.Clear();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🔔 Chuông báo động!", "RING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void grpKeyboard_Enter(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
