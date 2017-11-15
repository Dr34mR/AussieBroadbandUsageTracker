using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AussieUsage.Forms
{
    public partial class FormLogin : Form
    {
        public byte[] UserName;
        public byte[] UserPass;
        public bool PressedOk;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u25CF';
            txtUsername.Focus();

            lblBorder.Text = string.Empty;
            lblBorder.BorderStyle = BorderStyle.FixedSingle;
            lblBorder.AutoSize = false;
            lblBorder.Location = new Point(0, 0);
            lblBorder.Size = Size;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show(this, "Please enter a username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(this, "Please enter a password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            UserName = Encoding.UTF8.GetBytes(txtUsername.Text);
            UserPass = Encoding.UTF8.GetBytes(txtPassword.Text);
            PressedOk = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
