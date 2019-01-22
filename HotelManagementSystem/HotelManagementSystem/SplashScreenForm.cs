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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Width += 10;
                
                if (progressBar1.Width >= 324) {
                    timer1.Stop();
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
