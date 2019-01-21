using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {

            if (panel3.Controls.Contains(CheckInForm.Instance)!=true) {

                panel3.Controls.Add(CheckInForm.Instance);
                CheckInForm.Instance.Dock = DockStyle.Fill;
                CheckInForm.Instance.BringToFront();
                CheckInForm.Instance.Visible = true;

            }
            CheckInForm.Instance.BringToFront();
            CheckInForm.Instance.Visible = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
