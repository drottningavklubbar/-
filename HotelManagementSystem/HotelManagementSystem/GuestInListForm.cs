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
    public partial class GuestInListForm : UserControl
    {
        public GuestInListForm()
        {
            InitializeComponent();
        }

        public static GuestInListForm _instance;
        public static GuestInListForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GuestInListForm();
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
