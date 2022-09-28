using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using GardenGroupModel;
using GardenGroupLogic;
using System.Net.Mail;
using System.Net;

namespace GradenGroupUI
{
    public partial class LoginForm : Form
    {

        private string code;
        private Employee employee;
        public LoginForm()
        {            
            InitializeComponent();
        }


        EmployeeService employeeService = new EmployeeService();

        PasswordService passwordService = new PasswordService();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            employee = employeeService.GetEmployee(username);
            if (employee == null)
            {
                labelErrorText.Text = "Email does not exist";
                return;
            }
            
           
            RegularEmployeeForm regularEmployeeForm = new RegularEmployeeForm(employee);
            ServiceDeskEmployeeForm serviceDeskEmployeeForm = new ServiceDeskEmployeeForm(employee);
            if (!passwordService.VerifyPassword(password, employee.Password))
            {
                labelErrorText.Text = "Password Incorrect";
                return;            
            }
            else if (employee.IsServiceDeskEmployee)
            {
                serviceDeskEmployeeForm.Show();
            }
            else
            {
                regularEmployeeForm.Show();
            }

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee = employeeService.GetEmployee(textBoxEmailPassword.Text);
            if (employee == null)
            {
                labelErrorPasswordForgotten.Text = "Email does not exist in our system";
                return;
            }
            SendEmail(GetUserName(), GetPassword());
            
        }
        public static string GetUserName()
        {
            return "gardengroupict@outlook.com";
        }
        public static string GetPassword()
        {
            return "Thijswatzitjetezoeken";
        }
        public string ToAddress()
        {
            return textBoxEmailPassword.Text;
            
        }
        public void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient()
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.office365.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password)
                
            };
            code = "";
            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                code = code + random.Next(0, 10);
            }
            string subject = "Garden Group password forgotten";
            string body = $"The code for your new password is {code}";
            try
            {
                email.Send(fromAddress, ToAddress(), subject, body);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmCode.Text == code)
            {
                panelNewPassword.Visible = true;
            }
            else
            {
                labelErrorCode.Text = "Inncorrect code entered";
            }
        }

        private void buttonConfirmPassword_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxNewPasswordReentered.Text)
            {
                employee.Password = passwordService.GenerateSaltedHash(64, textBoxNewPassword.Text);
                employeeService.UpdateEmployee(employee);
                panelForgotPassword.Visible = false;
                panelNewPassword.Visible = false;
            }
            else
            {
                labelPasswordMatch.Visible = true;
            }
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            panelForgotPassword.Visible=true;
        }
    }
}
