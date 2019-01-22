using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class RegistrationForm : UserControl
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        SqlDataReader rdr = null;
        DataTable dtable;
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();

        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Persist Security Info=True;User ID=sa;Password=net";

       

        public static RegistrationForm _instance;
        public static RegistrationForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegistrationForm();
                }
                return _instance;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public bool validateEmail( string emailAddress) {

            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (email.IsMatch(emailAddress))
            {
                return true;
            }
            else return false;
        }

        private bool isPhoneNumberValid(string number) {
            bool phoneValid;
            string phoneNumberRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            Regex checkPhone = new Regex(phoneNumberRegex);
            if (string.IsNullOrEmpty(number) != true)
            {
                phoneValid = checkPhone.IsMatch(number);
            }
            else {
                phoneValid = false;

            }
            return phoneValid;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string trimmer = txtFirstName.Text.Trim();
                int nr = trimmer.Length;
                if (nr==0) {
                    MessageBox.Show("Please enter First Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();

                }

                string trimmer1 = txtLastName.Text.Trim();
                int nr1 = trimmer1.Length;
                if (nr1 == 0)
                {
                    MessageBox.Show("Please enter Last Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();

                }

                string trimmer2 = txtUserName.Text.Trim();
                int nr2 = trimmer2.Length;
                if (nr2 == 0)
                {
                    MessageBox.Show("Please enter User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();

                }

                string trimmer3 = txtPassword.Text.Trim();
                int nr3 = trimmer3.Length;
                if (nr3 == 0)
                {
                    MessageBox.Show("Please enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();

                }

                string trimmer4 = txtMobileNo.Text.Trim();
                int nr4 = trimmer4.Length;
                if (nr4 == 0)
                {
                    MessageBox.Show("Please enter Mobile No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobileNo.Focus();

                }

                string trimmer5 = txtEmail.Text.Trim();
                int nr5 = trimmer5.Length;
                if (nr5 == 0)
                {
                    MessageBox.Show("Please enter  Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();

                }

                /*if (isPhoneNumberValid(txtMobileNo.Text)==false) {
                    MessageBox.Show("Please enter a Valid Mobile No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobileNo.Focus();
                }

                if (validateEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Please enter a Valid Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();

                }*/
                con = new SqlConnection(cs);
                con.Open();
                string ct = "SELECT User_Name FROM Registration_table Where User_Name=@find";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "User_Name"));
                cmd.Parameters["@find"].Value = txtUserName.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.Read()) {
                    MessageBox.Show("UserName already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    else
                    {
                        con = new SqlConnection(cs);
                        con.Open();
                        string cb = "INSERT INTO Registration_table(First_Name,Last_Name,User_Name,Password,Mobile_Number,Email) VALUES(@d1,@d2,@d3,@d4,@d5,@d6)";
                        cmd = new SqlCommand(cb);
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NVarChar, 50, "First_Name"));
                        cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NVarChar, 50, "Last_Name"));
                        cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NVarChar, 50, "User_Name"));
                        cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NVarChar, 20, "Password"));
                        cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NVarChar, 12, "Mobile_Number"));
                        cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NVarChar, 50, "Email"));
                        cmd.Parameters["@d1"].Value = txtFirstName.Text;
                        cmd.Parameters["@d2"].Value = txtLastName.Text;
                        cmd.Parameters["@d3"].Value = txtUserName.Text;
                        cmd.Parameters["@d4"].Value = txtPassword.Text;
                        cmd.Parameters["@d5"].Value = txtMobileNo.Text;
                        cmd.Parameters["@d6"].Value = txtEmail.Text;
                        cmd.ExecuteReader();
                        MessageBox.Show("Successfully registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtMobileNo.Text = "";
                        txtEmail.Text = "";
                        con.Close();
                    }

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }


}
