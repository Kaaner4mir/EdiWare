using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdiWare
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlWindow_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCrossMark_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWindowControl_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pbxQuestionMark_Click(object sender, EventArgs e)
        {
            Process.Start("https://kaaner4mir.github.io/Bio/");
        }

        private void pbxInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/kaaner4mir/");
        }

        private void pbxLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/emirhan-kaaner-78511b375/");

        }

        private void pbxGmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:kaaner4mir@gmail.com");
        }

        private void pbxEduware_Click(object sender, EventArgs e)
        {
            Process.Start("https://kaaner4mir.github.io/Bio/");
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Username")
                tbxUsername.Text = "";
            tbxUsername.ForeColor = Color.Black;
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
                tbxUsername.Text = "Username";
            tbxUsername.ForeColor = Color.Black;
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if(tbxPassword.Text=="Password")
                tbxPassword.Text = "";
            tbxPassword.ForeColor = Color.Black;
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if(tbxPassword.Text=="")
                tbxPassword.Text = "Password";
            tbxPassword.ForeColor=Color.Black;
        }
    }
}
