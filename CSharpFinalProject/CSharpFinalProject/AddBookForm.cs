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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }
        //This method deals with adding a book
        private void AddBookButton_Click(object sender, EventArgs e)
        {

            string title;
            int id;
            errorProvider1.Clear();
            resultLabel.Text = "";
            if (BookIdTextBox.Text != ""&&bookTitleTextBox.Text != "")
                // Checks for empty values
            {
              
            
                title = bookTitleTextBox.Text;
                // Checks whether input is integer
                if (int.TryParse(BookIdTextBox.Text, out id))

                {
                   


                        LibraryDBClassProject.BooksClass libDataclass = new LibraryDBClassProject.BooksClass();
                        int saved = libDataclass.saveBookdetails(title, id, "available");
                    // Checks whether the record being inserted in the database
                        if (saved != 0)
                            ErrorProvider.Text = "Book added successfully";
                        else
                            ErrorProvider.Text = "Book Id already exists. Please enter a different ID.";
                   
                }
                else
                    ErrorProvider.Text = "Book ID must be numeric";
            

            }
            else
                ErrorProvider.Text = "Input values can not be blank. Please enter valid inputs.";
            


        }
    }
}
