// Created by Project Group 8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LibraryDBClassProject
{
    // This class deals with the database actvities for the Book Manager module
   public class BooksClass
    {


        public string DBError { get; set; }


        public DataTable getBooks()
        {

            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT BookId, BookTitle, BookStatus FROM Books ORDER BY BookId";
                DataSet libBooks = new DataSet();

                libBooks = libDataclass.getDataSet(sqlString);
                return libBooks.Tables[0];

            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }


        }



        public DataTable getSearchBooks(string bookTitle)
        {

            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT BookId, BookTitle, BookStatus FROM Books WHERE BookTitle like '" + bookTitle + "'";
                DataSet libBooks = new DataSet();

                libBooks = libDataclass.getDataSet(sqlString);
                return libBooks.Tables[0];

            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }


        }





        public int saveBookdetails(string title, int id, string status)
        {

            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "INSERT into Books (BookId, BookTitle, BookStatus) VALUES (" + id + ",'" + title + "','" + status + "')";
                int inserted = libDataclass.insertBookDetails(sqlString);

                return inserted;

            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return 0;
            }
        }


      
    }
}
