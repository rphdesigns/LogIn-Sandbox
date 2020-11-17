using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogIn_Sandbox.Home_Page
{
    public partial class PasswordReset : Form
    {
        //public string Username = LogIn.user;
        
        public PasswordReset()
        {
            InitializeComponent();
        }

        
        private bool validate_passwordReset(string username, string password)
        {
            DataBaseConnection.db_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE USER_TABLE SET PASSWORD ='" + password + "'" +
                              "WHERE (USERNAME ='" + username + "')";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = DataBaseConnection.connect;
            if (cmd.ExecuteNonQuery() == 1)
            {
                DataBaseConnection.connect.Close();
                return true;
            }
            else
            {
                DataBaseConnection.connect.Close();
                return false;
            }
        }

        private void ResetPWButton_Click(object sender, EventArgs e)
        {
            var password = newPWBox.Text;
            var confirmPw = confirmPWBox.Text;
            var username = usernameBox.Text;
            bool passwordPolicy = PasswordPolicy.IsValid(password);

            if (password == "" || confirmPw == "" || username == "")
            {
                MessageBox.Show("Empty Fields Detected! Please fill up all the fields");
                return;
            }

            if (password != confirmPw)
            {
                MessageBox.Show("Password and Confirm does not match");
                return;
            }

            if (passwordPolicy == false)
            {
                MessageBox.Show("Password must be at least 7 characters, must include at least one upper " +
                                "case letter, one lower case letter, one special character " +
                                "and one numeric digit.");
                return;
            }
            bool r = validate_passwordReset(username, password);
            if (r)
            {
                MessageBox.Show("New Password Created!");
                var logInPage = new LogIn();
                Hide();
                logInPage.Show();
            }
            else
                MessageBox.Show("Fail");
        }
    }
}
