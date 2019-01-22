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
    public partial class DiscountForm : UserControl
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        public static DiscountForm _instance;
        public static DiscountForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DiscountForm();
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
