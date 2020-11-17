using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_Sandbox.Counter
{
    public partial class Counter_Home : Form
    {
        public Counter_Home()
        {
            InitializeComponent();
            flash_GroupBox.Visible = false;
            config_GroupBox.Visible = false;
            c360_GroupBox.Visible = false;
            flashOtherTextBox.Visible = false;
            config_OtherTextBox.Visible = false;
            c360_OtherTextBox.Visible = false;
            
        }

        private void flash_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flash_GroupBox.Visible = !flash_GroupBox.Visible;

        }

        private void config_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config_GroupBox.Visible = !config_GroupBox.Visible;
        }

        private void c360_myeaton_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            c360_GroupBox.Visible = !c360_GroupBox.Visible;
        }

        private void flash_OtherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            flashOtherTextBox.Visible = !flashOtherTextBox.Visible;
        }

        private void config_OtherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            config_OtherTextBox.Visible = !config_OtherTextBox.Visible;
        }

        private void c360_OtherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            c360_OtherTextBox.Visible = !c360_OtherTextBox.Visible;
        }

        private void flash_PWCB_CheckedChanged(object sender, EventArgs e)
        {
            
          message_TextBox.Text = "Password reset for ";
            
        }
        
        private void flash_NUCB_CheckedChanged(object sender, EventArgs e)
        {
            message_TextBox.Text = "New user set up for ";
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            flash_CheckBox.Checked = false;
            config_CheckBox.Checked = false;
            c360_myeaton_CheckBox.Checked = false;
            flash_PWCB.Checked = false;
            flash_NUCB.Checked = false;
            flash_TerritoryCB.Checked = false;
            flash_OtherCheckBox.Checked = false;
            message_TextBox.Clear();


        }

        private void flashOtherTextBox_TextChanged(object sender, EventArgs e)
        {
            var flashOtherText = flashOtherTextBox.Text;

            if (flashOtherText == "CUD" || flashOtherText == "cud")
                message_TextBox.Text = "CUD Code error for order # ";
            if (flashOtherText == "Server" || flashOtherText == "server")
                message_TextBox.Text = "Server issues";
        }

        private void flash_TerritoryCB_CheckedChanged(object sender, EventArgs e)
        {
            message_TextBox.Text = "Territory Code for order # ";
        }

        private void copy_MessageButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(message_TextBox.Text);
        }
    }
}
