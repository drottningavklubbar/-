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
    public partial class CheckInListForm : UserControl
    {
        public CheckInListForm()
        {
            InitializeComponent();
        }
        public static CheckInListForm _instance;
        public static CheckInListForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CheckInListForm();
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
