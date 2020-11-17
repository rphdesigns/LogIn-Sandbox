using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIn_Sandbox.Home_Page;

namespace LogIn_Sandbox.User_Query
{
    public partial class UserQuery : Form
    {
        public UserQuery()
        {
            InitializeComponent();
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            Hide();
            homePage.Show();
        }
    }
}
