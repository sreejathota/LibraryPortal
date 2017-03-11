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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }
        // search for books
        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            string bookTitle = BookTitleTextBox.Text;
            // Checks for empty values

            if (BookTitleTextBox.Text != "" && BookTitleTextBox.Text != null)
            {

                try
                {
                    // Checks whether the record being available in the database

                    LibraryDBClassProject.BooksClass libDataclass = new LibraryDBClassProject.BooksClass();
                    if (libDataclass.getSearchBooks(bookTitle).Rows.Count != 0)
                    {
                        SearchBookDataGridView.DataSource = libDataclass.getSearchBooks(bookTitle);
                        errorLabel1.Text = libDataclass.DBError;
                    }
                    else
                        errorLabel1.Text = " Book title does not exist. Please enter a valid book title.";
                }
                catch (Exception ex)
                {

                    errorLabel1.Text = ex.Message + " An Error Occurred";
                }
            
            

            }
            else
                errorLabel1.Text =  " Book title can not be blank. Please enter a valid book title.";

        }
    }
}
