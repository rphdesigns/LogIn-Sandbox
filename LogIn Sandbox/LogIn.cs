using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using LogIn_Sandbox.Home_Page;


namespace LogIn_Sandbox
{
    public partial class LogIn : Form
    {
        //MySQL Connection Variable

        // public static string user;
        public LogIn()
        {
            InitializeComponent();
        }

        private bool validate_login(string username, string password)
        {
            //Connect to Database to validate username and login
            DataBaseConnection.db_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM USER_TABLE WHERE USERNAME='" + username + "' and PASSWORD='" + password + "'";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = DataBaseConnection.connect;
            SqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
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
        private void LogInButton_Click(object sender, EventArgs e)
        {

            var username = userNameField.Text;
            var password = passwordField.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Empty Fields Detected! Please fill up all the fields");
                return;
            }
            bool r = validate_login(username, password);
            if (r)
            {
                var homePage = new HomePage();
                Hide();
                homePage.Show();
                
            }
            else
                MessageBox.Show("Incorrect Login Credentials");
        }

        private void NewuserlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newUserPage = new Home_Page.NewUser();
            Hide();
            newUserPage.Show();
        }

        private void ResetPWLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //user = userNameField.Text.ToString();
            var pwReset = new PasswordReset();
            Hide();
            pwReset.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            Hide();
            homePage.Show();
        }
    }
}
