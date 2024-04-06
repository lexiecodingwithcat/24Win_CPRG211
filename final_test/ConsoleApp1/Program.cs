using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ConsoleApp1
    {
    public class OracleDB
        {
        public static string ReadData()
            {
            string first_name = "a";
            //create a connection
            string oraDB = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=sys;Password=David123520;DBA Privilege=SYSDBA;";
            OracleConnection connection = new OracleConnection(oraDB);
            //oepn the connection
            connection.Open();


            //create a command object
            OracleCommand cmd = new OracleCommand();
            //write query statement
            cmd.CommandText = "SELECT first_name FROM rcv_customer WHERE last_name ='Cooper'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            //create a oracle database reader
            OracleDataReader reader = cmd.ExecuteReader();
            using (reader)
                {
                //reader.Read() will return a boolean, if more rows, true
                while (reader.Read())
                    {
                    first_name = reader.GetString(0);

                    }
                }

            connection.Close();
            return first_name;

            }
        }
    internal class Program
        {
        static void Main(string[] args)
            {
            string name = OracleDB.ReadData();
            Console.WriteLine(name);




                }
        }
    }
