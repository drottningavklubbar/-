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
    public partial class CheckOutListForm : UserControl
    {
        public CheckOutListForm()
        {
            InitializeComponent();
        }
        public static CheckOutListForm _instance;
        public static CheckOutListForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CheckOutListForm();
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
