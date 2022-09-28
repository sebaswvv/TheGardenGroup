using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;

namespace GradenGroupUI.UserControls
{
    public partial class CreateNewEmployeeUC : UserControl
    {
        PasswordService passwordService;
        EmployeeService employeeService;
        public CreateNewEmployeeUC()
        {
            InitializeComponent();
            passwordService = new PasswordService();
            employeeService = new EmployeeService();
            
        }



       
        private string password;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Employee employee;
            password = GeneratePassword();
            Password Encryptedpassword = passwordService.GenerateSaltedHash(64, password);
            if (Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$"))
            {
                if (Regex.IsMatch(textBoxPhoneNumber.Text, @"^[0-9]+$") || textBoxPhoneNumber.MaxLength == 10)
                {
                    if (comboBoxUser.SelectedIndex == 0)
                    {
                        employee = new Employee(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text, Encryptedpassword, (GardenGroupModel.Enums.Location)comboBoxLocation.SelectedIndex, false);
                    }
                    else
                    {
                        employee = new Employee(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxPhoneNumber.Text, passwordService.GenerateSaltedHash(64, ""), (GardenGroupModel.Enums.Location)comboBoxLocation.SelectedIndex, true);
                    }
                    SendEmail(GetUserName(), GetPassword());
                    employeeService.AddEmployee(employee);

                }
                else
                {
                    labelErrorMessage.Text = "Phonenumber can only contain 10 digits and no letters";
                }
            }
            else
            {
                labelErrorMessage.Text = "Names can not include digets";
            }
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
            return textBoxEmail.Text;

        }
        public string GeneratePassword()
        {
            string password = "";
            for (int i = 0; i < 10; i++)
            {
                string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
                Random rand = new Random();
                int num = rand.Next(0, chars.Length);
                password = password + chars[num];
            }
            return password;
        }

        public void SendEmail(string fromAddress, string mailpassword)
        {
            using SmtpClient email = new SmtpClient()
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.office365.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, mailpassword)

            };
            
            string subject = "Welcome to Garden Group Corp.";
            string body = "";
            if (checkBoxPassword.Checked)
            {
                body = $"Your auto generated password = {password}";
            }
            else
            {
                body = "You can create a password by pressing 'forgot password' and filling in this email address.";
            }
            try
            {
                email.Send(fromAddress, ToAddress(), subject, body);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
