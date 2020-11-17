namespace LogIn_Sandbox.Home_Page
{
    partial class PasswordReset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resetPWButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.newPWLabel = new System.Windows.Forms.Label();
            this.confirmPWLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.newPWBox = new System.Windows.Forms.TextBox();
            this.confirmPWBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resetPWButton
            // 
            this.resetPWButton.Location = new System.Drawing.Point(187, 134);
            this.resetPWButton.Name = "resetPWButton";
            this.resetPWButton.Size = new System.Drawing.Size(75, 23);
            this.resetPWButton.TabIndex = 0;
            this.resetPWButton.Text = "Reset Password";
            this.resetPWButton.UseVisualStyleBackColor = true;
            this.resetPWButton.Click += new System.EventHandler(this.ResetPWButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(54, 59);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "User Name";
            // 
            // newPWLabel
            // 
            this.newPWLabel.AutoSize = true;
            this.newPWLabel.Location = new System.Drawing.Point(54, 85);
            this.newPWLabel.Name = "newPWLabel";
            this.newPWLabel.Size = new System.Drawing.Size(78, 13);
            this.newPWLabel.TabIndex = 3;
            this.newPWLabel.Text = "New Password";
            // 
            // confirmPWLabel
            // 
            this.confirmPWLabel.AutoSize = true;
            this.confirmPWLabel.Location = new System.Drawing.Point(54, 111);
            this.confirmPWLabel.Name = "confirmPWLabel";
            this.confirmPWLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPWLabel.TabIndex = 4;
            this.confirmPWLabel.Text = "Confirm Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(158, 56);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(131, 20);
            this.usernameBox.TabIndex = 5;
            // 
            // newPWBox
            // 
            this.newPWBox.Location = new System.Drawing.Point(158, 82);
            this.newPWBox.Name = "newPWBox";
            this.newPWBox.Size = new System.Drawing.Size(131, 20);
            this.newPWBox.TabIndex = 6;
            // 
            // confirmPWBox
            // 
            this.confirmPWBox.Location = new System.Drawing.Point(158, 108);
            this.confirmPWBox.Name = "confirmPWBox";
            this.confirmPWBox.Size = new System.Drawing.Size(131, 20);
            this.confirmPWBox.TabIndex = 7;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 198);
            this.Controls.Add(this.confirmPWBox);
            this.Controls.Add(this.newPWBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.confirmPWLabel);
            this.Controls.Add(this.newPWLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetPWButton);
            this.Name = "PasswordReset";
            this.Text = "Password_Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetPWButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label newPWLabel;
        private System.Windows.Forms.Label confirmPWLabel;
        private System.Windows.Forms.TextBox newPWBox;
        private System.Windows.Forms.TextBox confirmPWBox;
        private System.Windows.Forms.TextBox usernameBox;
    }
}