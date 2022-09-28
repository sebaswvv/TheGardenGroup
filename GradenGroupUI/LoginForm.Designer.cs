namespace GradenGroupUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelErrorText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonForgot = new System.Windows.Forms.Button();
            this.panelForgotPassword = new System.Windows.Forms.Panel();
            this.labelErrorPasswordForgotten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirmCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirmCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmailPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.labelErrorCode = new System.Windows.Forms.Label();
            this.panelForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(151, 132);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(235, 129);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(172, 23);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(151, 164);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(235, 158);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(172, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(73, 32);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelErrorText
            // 
            this.labelErrorText.AutoSize = true;
            this.labelErrorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelErrorText.ForeColor = System.Drawing.Color.Red;
            this.labelErrorText.Location = new System.Drawing.Point(191, 220);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(176, 15);
            this.labelErrorText.TabIndex = 5;
            this.labelErrorText.Text = "Incorrect username of password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(151, 266);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(256, 46);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonForgot
            // 
            this.buttonForgot.Location = new System.Drawing.Point(215, 344);
            this.buttonForgot.Name = "buttonForgot";
            this.buttonForgot.Size = new System.Drawing.Size(134, 31);
            this.buttonForgot.TabIndex = 7;
            this.buttonForgot.Text = "Forgot password?";
            this.buttonForgot.UseVisualStyleBackColor = true;
            // 
            // panelForgotPassword
            // 
            this.panelForgotPassword.Controls.Add(this.labelErrorCode);
            this.panelForgotPassword.Controls.Add(this.panelNewPassword);
            this.panelForgotPassword.Controls.Add(this.labelErrorPasswordForgotten);
            this.panelForgotPassword.Controls.Add(this.label3);
            this.panelForgotPassword.Controls.Add(this.buttonConfirmCode);
            this.panelForgotPassword.Controls.Add(this.label2);
            this.panelForgotPassword.Controls.Add(this.textBoxConfirmCode);
            this.panelForgotPassword.Controls.Add(this.label1);
            this.panelForgotPassword.Controls.Add(this.textBoxEmailPassword);
            this.panelForgotPassword.Controls.Add(this.labelEmail);
            this.panelForgotPassword.Controls.Add(this.button1);
            this.panelForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForgotPassword.Location = new System.Drawing.Point(0, 0);
            this.panelForgotPassword.Name = "panelForgotPassword";
            this.panelForgotPassword.Size = new System.Drawing.Size(545, 502);
            this.panelForgotPassword.TabIndex = 8;
            // 
            // labelErrorPasswordForgotten
            // 
            this.labelErrorPasswordForgotten.AutoSize = true;
            this.labelErrorPasswordForgotten.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPasswordForgotten.Location = new System.Drawing.Point(161, 266);
            this.labelErrorPasswordForgotten.Name = "labelErrorPasswordForgotten";
            this.labelErrorPasswordForgotten.Size = new System.Drawing.Size(10, 15);
            this.labelErrorPasswordForgotten.TabIndex = 8;
            this.labelErrorPasswordForgotten.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "don\'t forget to check your spam!!!";
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.Location = new System.Drawing.Point(215, 399);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmCode.TabIndex = 6;
            this.buttonConfirmCode.Text = "Confirm";
            this.buttonConfirmCode.UseVisualStyleBackColor = true;
            this.buttonConfirmCode.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code in the sent Email:";
            // 
            // textBoxConfirmCode
            // 
            this.textBoxConfirmCode.Location = new System.Drawing.Point(182, 362);
            this.textBoxConfirmCode.Name = "textBoxConfirmCode";
            this.textBoxConfirmCode.Size = new System.Drawing.Size(144, 23);
            this.textBoxConfirmCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forgot password";
            // 
            // textBoxEmailPassword
            // 
            this.textBoxEmailPassword.Location = new System.Drawing.Point(138, 217);
            this.textBoxEmailPassword.Name = "textBoxEmailPassword";
            this.textBoxEmailPassword.Size = new System.Drawing.Size(229, 23);
            this.textBoxEmailPassword.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(99, 162);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(297, 17);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Please enter the email of the forgotten password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Request Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.Location = new System.Drawing.Point(0, 0);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(545, 502);
            this.panelNewPassword.TabIndex = 9;
            this.panelNewPassword.Visible = false;
            // 
            // labelErrorCode
            // 
            this.labelErrorCode.AutoSize = true;
            this.labelErrorCode.Location = new System.Drawing.Point(201, 443);
            this.labelErrorCode.Name = "labelErrorCode";
            this.labelErrorCode.Size = new System.Drawing.Size(10, 15);
            this.labelErrorCode.TabIndex = 10;
            this.labelErrorCode.Text = ".";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 502);
            this.Controls.Add(this.panelForgotPassword);
            this.Controls.Add(this.buttonForgot);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelForgotPassword.ResumeLayout(false);
            this.panelForgotPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelErrorText;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonForgot;
        private System.Windows.Forms.Panel panelForgotPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConfirmCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmailPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConfirmCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErrorPasswordForgotten;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Label labelErrorCode;
    }
}
