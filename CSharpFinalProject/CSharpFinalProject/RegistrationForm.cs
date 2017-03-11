// Created by Project Group 8

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinalProject
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        // method deals with user registration
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            // Checks for empty values

            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                LibraryDBClassProject.Login libDataclass = new LibraryDBClassProject.Login();

                int x = libDataclass.Register(userName, password);
                // Checks whetehr the record being inserted in the database


                if (x > 0)
                    ErrorLabel.Text = "Registered Successfully";
                else

                    ErrorLabel.Text = "Registration Failure. Try again.";
            }
            else
                ErrorLabel.Text = "Input can not blank. Please enter all fields.";
        }
        

        private void LoginButton_Click(object sender, EventArgs e)
        {

            LoginForm childForm = new LoginForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}