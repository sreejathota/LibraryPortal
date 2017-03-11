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
    public partial class ViewIssuedBooks : Form
    {
        public ViewIssuedBooks()
        {
            InitializeComponent();
        }
        // Displays all issued books

        private void ViewIssuedBooks_Load(object sender, EventArgs e)
        {
             try
            {
                LibraryDBClassProject.LibraryManagement libDataclass = new LibraryDBClassProject.LibraryManagement();

                ViewIssuedBooksDataGridView.DataSource = libDataclass.getIssuedBooks();
                ErrorLabel.Text = libDataclass.DBError;
            }
            catch (Exception ex)
            {

                ErrorLabel.Text = ex.Message + " An Error Occurred";
            }

        }
        }
    }

