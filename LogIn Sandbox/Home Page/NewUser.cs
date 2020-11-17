using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogIn_Sandbox.Home_Page
{
    public partial class NewUser : Form
    {
        //SQL Connection Variables
        
        public NewUser()
        {
            InitializeComponent();
        }


        private void HomePageButton_Click(object sender, EventArgs e)
        { 
            //Return to Home Page
            var homePage = new HomePage();
            Hide();
            homePage.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear all fields
            usernameBox.Clear();
            passwordBox.Clear();
            confirmPwBox.Clear();
            firstNameBox.Clear();
            lastnameBox.Clear();
            emailBox.Clear();
            addressBox.Clear();
            cityBox.Clear();
            stateBox.Clear();
            zipCodeBox.Clear();
        }
        private bool validate_NewUser(string username, string password, string firstname, string lastname, 
                 string email, string address, string city, string state, string zipcode)
        {
            //Add new user to SQL Database connection command

            DataBaseConnection.db_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO USER_TABLE(USERNAME,PASSWORD,FIRST_NAME,LAST_NAME,EMAIL" +
                              ",ADDRESS,CITY,STATE_US,ZIPCODE_US) VALUES(@username,@password,@firstname,@lastname," +
                              "@email,@address,@city,@state_US,@zipCode_US)";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state_US", state);
            cmd.Parameters.AddWithValue("@zipCode_US", zipcode);
            cmd.Connection = DataBaseConnection.connect;
            if (cmd.ExecuteNonQuery()==1)
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
        private void CreateNUButton_Click(object sender, EventArgs e)
        {
            //New User Form Parameters = No Boxes Blank, PW and ConfirmPW must be same, PW requirements
            //Validate all Text Box entries and New User create in SQL Database, return to LogIn Page

            var username = usernameBox.Text;
            var password = passwordBox.Text;
            var confirmPw = confirmPwBox.Text;
            var firstname = firstNameBox.Text;
            var lastname = lastnameBox.Text;
            var email = emailBox.Text;
            var address = addressBox.Text;
            var city = cityBox.Text;
            var state = stateBox.Text;
            var zipcode = zipCodeBox.Text;
            bool passwordPolicy = PasswordPolicy.IsValid(password);


            if (username == "" || password == "" || confirmPw == ""|| firstname == "" || lastname == "" || email =="" || address == ""
                || city == "" || state == "" || zipcode == "")
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

            bool r = validate_NewUser(username, password, firstname, lastname, email, address, city, state, zipcode);
            if (r)
            {
                MessageBox.Show("New User Created!");
                var logInPage = new LogIn();
                Hide();
                logInPage.Show();
            }
            else
                MessageBox.Show("Fail");
        }
    }
}
