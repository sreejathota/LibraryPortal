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
    // This class deals with the database actvities for the login and registration
   public class Login
    {
       public string DBError { get; set; }
       public int Register(string userName, string password)
        {
            try
            {
                LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
                string sqlString = "INSERT into Login (UserName, Password) VALUES ('" + userName + "','" + password + "')";
                int issued = libDataclass.insertIssueDetails(sqlString);
                return issued;
            }
            catch (Exception ex)
            {
                DBError = ex.Message;

                return 0;
            }
        }

        public string getLogin(string userName, string password)
        {

            LibraryDBClassProject.LibraryDataClass libDataclass = new LibraryDBClassProject.LibraryDataClass();
            string sqlString = "select UserName,Password from login where UserName='" + userName + "'and Password='" + password + "'";
            DataSet users = new DataSet();

            users = libDataclass.getDataSet(sqlString);
            if (users.Tables[0].Rows.Count != 0)
                return "success";
            else


            return "failure";
        }


    }
}
