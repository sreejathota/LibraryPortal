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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }
        // method deals with displaying issued books to students
        private void SearchIssuedBooksButton_Click(object sender, EventArgs e)
        {
            int studentId;
            // Checks for empty values

            if (StudentIdTextBox.Text != "" && StudentIdTextBox.Text != null)
            {
                // Checks whether input is integer

                if (int.TryParse(StudentIdTextBox.Text, out studentId))
                {

                    try
                    {
                        LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();
                        // Checks whether the record being inserted in the database


                        if (libDataclass.getSearchStudentID(studentId).Rows.Count != 0)
                        {
                        if (libDataclass.getSearchIssuedBooks(studentId).Rows.Count != 0)
                        {


                            ReturnBooksDataGridView.DataSource = libDataclass.getSearchIssuedBooks(studentId);

                            ErrorLabel.Text = libDataclass.DBError;
                        }
                        else{
                            ErrorLabel.Text = "No books has been issued.";
                            ReturnBooksDataGridView.ClearSelection();
                            
                        }
                        }
                        else{
                            ErrorLabel.Text = "Student ID doesnt not exist.";                                                
                            ReturnBooksDataGridView.ClearSelection();

                        }

                    }


                    catch (Exception ex)
                    {

                        ErrorLabel.Text = ex.Message + " An Error Occurred";
                    }


                }
                else
                {
                    ErrorLabel.Text = "Student ID must be numeric. Please enter a valid ID";
                    ReturnBooksDataGridView.ClearSelection();
                }

            }
            else
            {
                ErrorLabel.Text = "Student ID can not be blank. Please enter a valid ID";
                ReturnBooksDataGridView.ClearSelection();

            }

        }
        
       
        // method deals with returning books

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            DateTimePickerReturn.MinDate = DateTimePickerReturn.MaxDate = DateTime.Now;
            string returnDate = DateTimePickerReturn.Text;
            int bookID;
            // Checks for empty values

            if (ReturnIDTextBox.Text != "" && ReturnIDTextBox.Text != null)
            {
                // Checks whether input is integer

                if (int.TryParse(ReturnIDTextBox.Text, out bookID))

                {
                    LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();
                    // Checks whether the record being inserted in the database


                    if (libDataclass.getSearchBookID(bookID).Rows.Count != 0)
                    {
                        if (libDataclass.checkBookStatus(bookID).Rows.Count == 0)
                        {


                            int x = libDataclass.returnBook(bookID, returnDate);
                            if (x > 0)
                                ErrorLabel.Text = "Book returned successfully";
                            else
                                ErrorLabel.Text = "Book has not issued to anyone";
                        }
                        else
                            ErrorLabel.Text = "Book already returned and availble to issue.";

                    }
                    else
                        ErrorLabel.Text = "Book does not exist";


                }
                else
                    ErrorLabel.Text = "Book ID must be numeric. Please enter a valid ID";
            }


            else
                ErrorLabel.Text = "Book ID can not be blank. Please enter a valid ID";







        }
        
        }
    }

