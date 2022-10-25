namespace GradenGroupUI.UserControls
{
    partial class CreateNewEmployeeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.panelUserAdded = new System.Windows.Forms.Panel();
            this.ButtonOkNewUser = new System.Windows.Forms.Button();
            this.labelUserAdded = new System.Windows.Forms.Label();
            this.panelUserAdded.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(383, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register new employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 445);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 493);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 542);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 590);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Send password?";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(454, 653);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(137, 48);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(309, 298);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(435, 31);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(309, 347);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(435, 31);
            this.textBoxLastName.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(309, 440);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(435, 31);
            this.textBoxEmail.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(309, 488);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(435, 31);
            this.textBoxPhoneNumber.TabIndex = 14;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Employee",
            "Servicedesk employee"});
            this.comboBoxUser.Location = new System.Drawing.Point(309, 397);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(435, 33);
            this.comboBoxUser.TabIndex = 17;
            this.comboBoxUser.Text = "Select type";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "HaarlemHQ"});
            this.comboBoxLocation.Location = new System.Drawing.Point(309, 537);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(435, 33);
            this.comboBoxLocation.TabIndex = 18;
            this.comboBoxLocation.Text = "Select location";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(309, 590);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(462, 29);
            this.checkBoxPassword.TabIndex = 19;
            this.checkBoxPassword.Text = "yes, I want an autogenerated password mailed to me.";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(383, 233);
            this.labelErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 25);
            this.labelErrorMessage.TabIndex = 20;
            // 
            // panelUserAdded
            // 
            this.panelUserAdded.Controls.Add(this.ButtonOkNewUser);
            this.panelUserAdded.Controls.Add(this.labelUserAdded);
            this.panelUserAdded.Location = new System.Drawing.Point(160, 268);
            this.panelUserAdded.Name = "panelUserAdded";
            this.panelUserAdded.Size = new System.Drawing.Size(729, 433);
            this.panelUserAdded.TabIndex = 21;
            this.panelUserAdded.Visible = false;
            // 
            // ButtonOkNewUser
            // 
            this.ButtonOkNewUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOkNewUser.Location = new System.Drawing.Point(299, 210);
            this.ButtonOkNewUser.Name = "ButtonOkNewUser";
            this.ButtonOkNewUser.Size = new System.Drawing.Size(159, 40);
            this.ButtonOkNewUser.TabIndex = 2;
            this.ButtonOkNewUser.Text = "Ok";
            this.ButtonOkNewUser.UseVisualStyleBackColor = true;
            this.ButtonOkNewUser.Click += new System.EventHandler(this.ButtonOkNewUser_Click);
            // 
            // labelUserAdded
            // 
            this.labelUserAdded.AutoSize = true;
            this.labelUserAdded.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserAdded.Location = new System.Drawing.Point(186, 114);
            this.labelUserAdded.Name = "labelUserAdded";
            this.labelUserAdded.Size = new System.Drawing.Size(413, 38);
            this.labelUserAdded.TabIndex = 1;
            this.labelUserAdded.Text = "User has been added to system!";
            // 
            // CreateNewEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserAdded);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateNewEmployeeUC";
            this.Size = new System.Drawing.Size(989, 1005);
            this.panelUserAdded.ResumeLayout(false);
            this.panelUserAdded.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Panel panelUserAdded;
        private System.Windows.Forms.Label labelUserAdded;
        private System.Windows.Forms.Button ButtonOkNewUser;
    }
}
