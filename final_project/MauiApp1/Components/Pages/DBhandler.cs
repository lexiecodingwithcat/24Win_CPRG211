using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace MauiApp1.Components.Pages
    {
    public class DBhandler
        {
        static string connect_string = "Data Source=D:\\SAIT\\c#\\final_project\\member.db";

        public DBhandler()
           {
        CreateTableDB();
           }

        //check whether the table exists or not
        protected bool IsTableExist()
            {
                using (SQLiteConnection connection = new SQLiteConnection(connect_string))
                    {
                    connection.Open();

                    string sql = $"SELECT name FROM sqlite_master WHERE type='table' AND name='member';";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                        {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                            return reader.Read();
                            }
                        }
                    }
            }

        private void CreateTableDB()
            {
            //if table does not exists
            if (!IsTableExist())
                {
                //create connection 

                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = "CREATE TABLE member (first_name TEXT(30), last_name TEXT(30), email TEXT(50) PRIMARY KEY, password TEXT(30) );";
                //create command object
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                using (cmd)
                    {
                    cmd.ExecuteNonQuery();
                    }

                connection.Close();
                }

            }

        public static string DeleteTable()
            {
            try {
                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = "DROP TABLE IF EXISTS member;";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                using (cmd)
                    {
                    cmd.ExecuteNonQuery();
                    }
                connection.Close();
                return "deleted";
                }catch(Exception ex)
                {
                return ex.Message;
                }
            
            }







       public string InsertMemberToDB(string fname, string lname, string email, string password)
            {
            try
                {
                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = $"INSERT INTO member(first_name, last_name, email, password) VALUES (@fname,@lname,@email,@password)";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                using (cmd)
                    {
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    }
                connection.Close();
                return "Registered successfully";
                }catch(Exception ex)
                {
                return ex.Message;
                }
                
             }
       }

        
    }
