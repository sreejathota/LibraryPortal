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
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
            InitializeComponent();
        }

        // method redirects to addbook form

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddBookForm childForm = new AddBookForm();
            childForm.MdiParent = this.MdiParent; 
            childForm.Show();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // method redirects to view all book form

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewallBooksForm childForm = new ViewallBooksForm();
            childForm.MdiParent = this.MdiParent; 
            childForm.Show();
        }

        // method redirects to search book form

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm childForm = new SearchBookForm();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // method redirects to aboutbox form

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 childForm = new AboutBox1();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();
        }

        // method redirects to issuebook form

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm childForm = new IssueBookForm();

            childForm.MdiParent = this.MdiParent;
            childForm.Show();

        }
        // method redirects to returnbook form

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm childForm = new ReturnForm();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();
        }
        // method redirects to view all issued books form

        private void viewIssuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewIssuedBooks childForm = new ViewIssuedBooks();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();

        }
        // method redirects to view books issued to students form

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIssued childForm = new StudentIssued();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();

        }

       

 

    }
}
