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
    public partial class CheckInForm : UserControl
    {
        

        public CheckInForm()
        {
            InitializeComponent();
        }

        public static CheckInForm _instance;
        public static CheckInForm Instance
        {
            get {  
                    if (_instance == null ) {
                        _instance = new CheckInForm();
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
