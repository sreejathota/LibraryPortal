// Created by Project Group 8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.ComponentModel;
// This class includes the connection string and manages the database connections
namespace LibraryDBClassProject
{
    public class LibraryDataClass
    {
        private SqlConnection libraryConnection;

        string libConnectionString = ConfigurationManager.ConnectionStrings["CSharpFinalProject.Properties.Settings.LibraryDBConnectionString"].ToString();

        public SqlConnection GetConnection()
        {
            if (libraryConnection == null)
            {
                libraryConnection = new SqlConnection(libConnectionString);





            } //end if
            return libraryConnection;
        } //end GetConnection() method.

        public void Open()
        {
            if (libraryConnection.State == ConnectionState.Closed)
            {
                libraryConnection.Open();
            } //end if
        } // end Open() method.

        public void Close()
        {
            libraryConnection.Close();
        } //end close method

        public DataSet getDataSet(string sqlString)
        {
            DataSet libDataSet = new DataSet();
            try
            {

                SqlDataAdapter nwDataAdapter = new SqlDataAdapter(sqlString, this.GetConnection());
                nwDataAdapter.Fill(libDataSet);
                return libDataSet;
            }
            finally
            {
                this.Close();
            }



        } //end getDataSet;
        public int insertBookDetails(string sqlString)
        {
            int inserted;
            // SqlDataReader dbr;
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlString;
                cmd.Connection = this.GetConnection();

                this.Open();
                inserted = cmd.ExecuteNonQuery();
                cmd.Clone();
                this.Close();

                //this.Open();
                //SqlCommand cmd = new SqlCommand(sqlString, this.GetConnection());
                //inserted = cmd.ExecuteNonQuery();
                //dbr= cmd.ExecuteReader();
                // inserted = 1;
            }
            finally
            {
                this.Close();

            }
            return inserted;

        }

        public int insertIssueDetails(string sqlString)
        {
            int inserted;
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlString;
                cmd.Connection = this.GetConnection();

                this.Open();
                inserted=cmd.ExecuteNonQuery();
                cmd.Clone();
                this.Close();

               
            }
            finally
            {
                this.Close();

            }
            return inserted;

        }

        public int updateIssued(string sqlString2)
        {
            int inserted;
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlString2;
                cmd.Connection = this.GetConnection();

                this.Open();
                inserted = cmd.ExecuteNonQuery();
                cmd.Clone();
                this.Close();


            }
            finally
            {
                this.Close();

            }
            return inserted; 

        }

        internal int updateReturned(string sqlString2)
        {
            int inserted;
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlString2;
                cmd.Connection = this.GetConnection();

                this.Open();
                inserted = cmd.ExecuteNonQuery();
                cmd.Clone();
                this.Close();


            }
            finally
            {
                this.Close();

            }
            return inserted; 

        

        }
    }
}
