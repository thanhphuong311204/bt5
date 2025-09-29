using System.Drawing;
using System.Windows.Forms;

namespace TranThanhPhuong_1150080165
{
    partial class Form3
    {
        private Label lblPassword;
        private TextBox txtPassword;
        private GroupBox grpKeyboard;
        private Button btnClear;
        private Button btnEnter;
        private Button btnRing;
        private DataGridView dgvLog;

        private void InitializeComponent()
        {
            lblPassword = new Label();
            txtPassword = new TextBox();
            grpKeyboard = new GroupBox();
            btnClear = new Button();
            btnEnter = new Button();
            btnRing = new Button();
            dgvLog = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            grpKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 30);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(134, 37);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(350, 43);
            txtPassword.TabIndex = 1;
            // 
            // grpKeyboard
            // 
            grpKeyboard.Controls.Add(btnClear);
            grpKeyboard.Controls.Add(btnEnter);
            grpKeyboard.Controls.Add(btnRing);
            grpKeyboard.Location = new Point(20, 103);
            grpKeyboard.Name = "grpKeyboard";
            grpKeyboard.Size = new Size(531, 202);
            grpKeyboard.TabIndex = 2;
            grpKeyboard.TabStop = false;
            grpKeyboard.Text = "Keyboard";
            grpKeyboard.Enter += grpKeyboard_Enter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Location = new Point(330, 30);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 39);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.LightGreen;
            btnEnter.Location = new Point(330, 89);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(114, 39);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnRing
            // 
            btnRing.BackColor = Color.Red;
            btnRing.ForeColor = Color.White;
            btnRing.Location = new Point(330, 149);
            btnRing.Name = "btnRing";
            btnRing.Size = new Size(114, 42);
            btnRing.TabIndex = 2;
            btnRing.Text = "RING";
            btnRing.UseVisualStyleBackColor = false;
            btnRing.Click += btnRing_Click;
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.ColumnHeadersHeight = 46;
            dgvLog.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvLog.Location = new Point(12, 311);
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.RowHeadersWidth = 82;
            dgvLog.Size = new Size(572, 215);
            dgvLog.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Form3
            // 
            ClientSize = new Size(612, 538);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(grpKeyboard);
            Controls.Add(dgvLog);
            Font = new Font("Segoe UI", 10F);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Security Panel";
            grpKeyboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
