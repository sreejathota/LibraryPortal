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
    // This class deals with the database actvities for the Issue and returns
    public class LibraryManagement
    {
        public string DBError { get; set; }


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



        public int issueBook(int bookId, int studentID, String date)
        {
            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "INSERT into Library (StudentID, BookID, IssueDate) VALUES (" + studentID + "," + bookId + ",'" +date +"')";
                string sqlString2 = "UPDATE BOOKS set BookStatus='issued' where BookId="+bookId;
                int issued=libDataclass.insertIssueDetails(sqlString);
               int updated= libDataclass.updateIssued(sqlString2);
                return issued;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return 0;
            }
            
        }
        public DataTable getSearchIssuedBooks(int studentID)
        {

            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT BookID,IssueDate FROM Library WHERE StudentID =  " + studentID + "and ReturnDate is null";
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



        public int returnBook(int bookID, string returnDate)
        {
            LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
            string sqlString2 = "UPDATE BOOKS set BookStatus='available' where BookId=" + bookID;

            string sqlString1 = "UPDATE LIBRARY set ReturnDate= '"+returnDate+"' where BookId=" + bookID;
            DataSet libBooks = new DataSet();

            int updated = libDataclass.updateReturned(sqlString1);
            int updated2 = libDataclass.updateReturned(sqlString2);


            return updated;
        }

        public DataTable getIssuedBooks()
        {
            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT BookID,StudentID,IssueDate FROM Library WHERE ReturnDate is NULL ";
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

        public DataTable getStudentIssuedBooks(int StudentId)
        {
            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT Students.StudentID,Students.StudentName,Library.BookID, Library.IssueDate from Library Join Students on Students.StudentID=Library.StudentID where Library.StudentID="+StudentId+"and ReturnDate is null";
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

        public DataTable checkBookStatus(int bookId)
        {
            LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
            string sqlString = "SELECT BookTitle from Books where BookId="+bookId+" and BookStatus='available'";
            DataSet libBooks = new DataSet();

            libBooks = libDataclass.getDataSet(sqlString);
            return libBooks.Tables[0];

        }

        public DataTable getSearchStudentID(int studentId)
        {
            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "SELECT StudentName FROM Students WHERE StudentID =  " + studentId + "";
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

        public DataTable getSearchBookID(int bookID)
        {
            LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
            string sqlString = "SELECT BookTitle from Books where BookID=" + bookID + " ";
            DataSet libBooks = new DataSet();

            libBooks = libDataclass.getDataSet(sqlString);
            return libBooks.Tables[0];
            
        }
    }
}
