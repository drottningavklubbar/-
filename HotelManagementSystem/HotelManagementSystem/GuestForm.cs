using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class GuestForm : UserControl
    {
        public GuestForm()
        {
            InitializeComponent();
        }


        public static GuestForm _instance;
        public static GuestForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GuestForm();
                }
                return _instance;
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
