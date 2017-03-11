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
    public partial class ViewallBooksForm : Form
    {
        public ViewallBooksForm()
        {
            InitializeComponent();
        }

        private void ViewallBooksForm_Load(object sender, EventArgs e)
        {

            try
            {
                LibraryDBClassProject.BooksClass libDataclass = new LibraryDBClassProject.BooksClass();

                BooksDataGridView.DataSource = libDataclass.getBooks();
                errorLabel.Text = libDataclass.DBError;
            }
            catch (Exception ex)
            {

                errorLabel.Text = ex.Message + " An Error Occurred";
            }

        }
    }
}
