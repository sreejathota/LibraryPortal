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
    public partial class StudentIssued : Form
    {
        public StudentIssued()
        {
            InitializeComponent();
        }

        private void SeaerchStudentBooksbutton_Click(object sender, EventArgs e)
        {
            int StudentId;
            if (StudentIDTextBox.Text != "" && StudentIDTextBox.Text != null)
            {
                if (int.TryParse(StudentIDTextBox.Text, out StudentId))
                {
                try
                {
                    LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();
                    if (libDataclass.getSearchStudentID(StudentId).Rows.Count != 0)
                    {
                        if (libDataclass.getStudentIssuedBooks(StudentId).Rows.Count != 0)
                        {
                            SearchIssuedDataGridView.DataSource = libDataclass.getStudentIssuedBooks(StudentId);

                            errorLabel1.Text = libDataclass.DBError;
                        }
                        else
                            errorLabel1.Text = " No Books is issued to this student";
                    }
                    else
                        errorLabel1.Text = " Student ID does not exist. Please enter a valid student ID";


                }
                catch (Exception ex)
                {

                    errorLabel1.Text = ex.Message + " An Error Occurred";
                }
                }
                else
                errorLabel1.Text =  " Student Id must be numeric. Please enter a valid student ID";

            }
            else
                errorLabel1.Text =  " Student Id can not be blank. Please enter a valid student ID";


        }
        }
    }

