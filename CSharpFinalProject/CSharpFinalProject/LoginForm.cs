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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //method redirects to registration form

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm childForm = new RegistrationForm();
            childForm.MdiParent = this;
            childForm.Show();

        }
        //method checks login 

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string userName = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            // checks whether input is blank
            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != ""){

            LibraryDBClassProject.Login libDataclass = new LibraryDBClassProject.Login();

            string x = libDataclass.getLogin(userName, password);
            if (x.Equals("success"))
            {


                MenuForm childForm = new MenuForm();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else {
                ErrorLabel.Text = "Invalid Credentials";
            }
            }
           else {
                ErrorLabel.Text = "Input can not blank. Please enter all fields.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
