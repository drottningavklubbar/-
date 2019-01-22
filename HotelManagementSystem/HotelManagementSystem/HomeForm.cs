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

        

        private void btncheckinlist_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(CheckInListForm.Instance) != true)
            {

                panel3.Controls.Add(CheckInListForm.Instance);
                CheckInListForm.Instance.Dock = DockStyle.Fill;
                CheckInListForm.Instance.BringToFront();
                CheckInListForm.Instance.Visible = true;

            }
            CheckInListForm.Instance.BringToFront();
            CheckInListForm.Instance.Visible = true;
        }

        private void btnguest_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(GuestForm.Instance) != true)
            {

                panel3.Controls.Add(GuestForm.Instance);
                GuestForm.Instance.Dock = DockStyle.Fill;
                GuestForm.Instance.BringToFront();
                GuestForm.Instance.Visible = true;

            }
            GuestForm.Instance.BringToFront();
            GuestForm.Instance.Visible = true;
        }

        private void btnguestinlist_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(GuestInListForm.Instance) != true)
            {

                panel3.Controls.Add(GuestInListForm.Instance);
                GuestInListForm.Instance.Dock = DockStyle.Fill;
                GuestInListForm.Instance.BringToFront();
                GuestInListForm.Instance.Visible = true;

            }
            GuestInListForm.Instance.BringToFront();
            GuestInListForm.Instance.Visible = true;
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(RoomForm.Instance) != true)
            {

                panel3.Controls.Add(RoomForm.Instance);
                RoomForm.Instance.Dock = DockStyle.Fill;
                RoomForm.Instance.BringToFront();
                RoomForm.Instance.Visible = true;

            }
            RoomForm.Instance.BringToFront();
            RoomForm.Instance.Visible = true;
        }

        private void btnroomlist_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(RoomListForm.Instance) != true)
            {

                panel3.Controls.Add(RoomListForm.Instance);
                RoomListForm.Instance.Dock = DockStyle.Fill;
                RoomListForm.Instance.BringToFront();
                RoomListForm.Instance.Visible = true;

            }
            RoomListForm.Instance.BringToFront();
            RoomListForm.Instance.Visible = true;
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(CheckOutForm.Instance) != true)
            {

                panel3.Controls.Add(CheckOutForm.Instance);
                CheckOutForm.Instance.Dock = DockStyle.Fill;
                CheckOutForm.Instance.BringToFront();
                CheckOutForm.Instance.Visible = true;

            }
            CheckOutForm.Instance.BringToFront();
            CheckOutForm.Instance.Visible = true;
        }

        private void btncheckoutlist_Click(object sender, EventArgs e)
        {

            if (panel3.Controls.Contains(CheckOutListForm.Instance) != true)
            {

                panel3.Controls.Add(CheckOutListForm.Instance);
                CheckOutListForm.Instance.Dock = DockStyle.Fill;
                CheckOutListForm.Instance.BringToFront();
                CheckOutListForm.Instance.Visible = true;

            }
            CheckOutListForm.Instance.BringToFront();
            CheckOutListForm.Instance.Visible = true;
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Contains(DiscountForm.Instance) != true)
            {

                panel3.Controls.Add(DiscountForm.Instance);
                DiscountForm.Instance.Dock = DockStyle.Fill;
                DiscountForm.Instance.BringToFront();
                DiscountForm.Instance.Visible = true;

            }
            DiscountForm.Instance.BringToFront();
            DiscountForm.Instance.Visible = true;
        }
    }
}
