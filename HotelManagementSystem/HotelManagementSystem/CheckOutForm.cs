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
    public partial class CheckOutForm : UserControl
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }
        public static CheckOutForm _instance;
        public static CheckOutForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CheckOutForm();
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
