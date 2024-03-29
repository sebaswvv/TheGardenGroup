﻿using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using System.Configuration;
using System.Collections.Generic;

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
            bool emailExists = false;
            string Encryptedpassword = passwordService.GenerateSaltedHash(password);
            if (!checkBoxPassword.Checked)
            {
                Encryptedpassword = "";
            }
            List<Employee> employees = employeeService.GetAllEmployees();
            foreach (Employee employee1 in employees)
            {
                if (employee1.Email == textBoxEmail.Text)
                {
                    emailExists = true;
                }
            }
            if (!emailExists)
            {
                if (Regex.IsMatch(textBoxFirstName.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(textBoxPhoneNumber.Text, @"^[0-9]+$") || comboBoxUser.SelectedIndex != -1 || comboBoxLocation.SelectedIndex != -1)
                {

                    if (comboBoxUser.SelectedIndex == 0)
                    {
                        employee = new Employee(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text.ToLower(), textBoxPhoneNumber.Text, Encryptedpassword, (GardenGroupModel.Enums.Location)comboBoxLocation.SelectedIndex, false);
                    }
                    else
                    {
                        employee = new Employee(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text.ToLower(), textBoxPhoneNumber.Text, Encryptedpassword, (GardenGroupModel.Enums.Location)comboBoxLocation.SelectedIndex, true);
                    }
                    employeeService.AddEmployee(employee);
                    SendEmail(GetUserName(), GetPassword());
                   panelUserAdded.Visible = true;
                }
                else
                {
                    labelErrorMessage.Text = "Field filled in incorrectly.";
                }
            }
            else
            {
                labelErrorMessage.Text = "Email already exists in our system.";
            }
            
        }
        public static string GetUserName()
        {
            return ConfigurationManager.AppSettings["email"];
        }
        public static string GetPassword()
        {
            return ConfigurationManager.AppSettings["password"];
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

        private void ButtonOkNewUser_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhoneNumber.Text = string.Empty;
            comboBoxLocation.SelectedIndex = -1;
            comboBoxLocation.Text = "Select location";
            checkBoxPassword.Checked = false;
            comboBoxUser.SelectedIndex = -1;
            comboBoxUser.Text = "Select type";
            labelErrorMessage.Text = String.Empty;

            panelUserAdded.Visible = false;
        }

       
    }
}
