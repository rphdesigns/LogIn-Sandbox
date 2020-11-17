using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIn_Sandbox.User_Query;

namespace LogIn_Sandbox.Home_Page
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var logIn = new LogIn();
            Hide();
            logIn.Show();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            var newUser = new NewUser();
            Hide();
            newUser.Show();
        }

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logIn = new LogIn();
            Hide();
            logIn.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newUser = new NewUser();
            Hide();
            newUser.Show();
        }

        private void UserQueryButton_Click(object sender, EventArgs e)
        {
            var userQuery = new UserQuery();
            Hide();
            userQuery.Show();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userQuery = new UserQuery();
            Hide();
            userQuery.Show();
        }

        private void counter_Button_Click(object sender, EventArgs e)
        {
            var counter = new Counter.Counter_Home();
            Hide();
            counter.Show();
        }
    }
}
