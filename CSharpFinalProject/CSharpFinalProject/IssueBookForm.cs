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
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }
        //This method deals with issuing book
        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            // Checks for empty values

            if (BookIDTextBox.Text != "" && StudentIDTextBox.Text != "")
            {
                int bookId;
                int studentID;
                // Checks whether input is integer


                if (int.TryParse(BookIDTextBox.Text, out bookId) && int.TryParse(StudentIDTextBox.Text, out studentID))
                {
                    DateTimePicker1.MinDate = DateTimePicker1.MaxDate = DateTime.Now;

                    String date = DateTimePicker1.Text;

                    LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();
                    // Checks whether the record being inserted in the database

                    if (libDataclass.getSearchBookID(bookId).Rows.Count != 0)
                    {
                        if (libDataclass.checkBookStatus(bookId).Rows.Count !=0)
                        {
                            int x = libDataclass.issueBook(bookId, studentID, date);

                            if (x != 0)
                                ErrorLabel.Text = " Book Issued Successfully";

                            else
                                ErrorLabel.Text = " Invalid inputs. Please provide a valid Student ID.";
                        }
                        else

                            ErrorLabel.Text = " Book is already issued.";

                    }
                    else
                        ErrorLabel.Text = " Book does not exist";

                }
               
                else
                    ErrorLabel.Text = " Input values should be numeric. Please provide numeric inputs.";


           }
            else
                ErrorLabel.Text = " Input values can not be blank. Please provide inputs.";

        }
        // method deals with finding a book

        private void FindBookButton_Click(object sender, EventArgs e)
        {

            string bookTitle = SearchBookIDTextBox.Text;
            // Checks for empty values

            if (bookTitle!=null && bookTitle!="")
            {

                try
                {
                    LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();
                    // Checks whether the record being available in the database

                    if (libDataclass.getSearchBooks(bookTitle).Rows.Count != 0)
                    BooksDataGridView.DataSource = libDataclass.getSearchBooks(bookTitle);
                    else
                        ErrorLabel.Text =  " Please enter a valid Book Id to search";




                }
                catch (Exception ex)
                {

                    ErrorLabel.Text = ex.Message + " An Error Occurred";
                }
            }
            else
                ErrorLabel.Text = "Book Title can not be blank";
        }
    }
}
