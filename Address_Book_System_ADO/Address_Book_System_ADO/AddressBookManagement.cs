using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_ADO
{
    class AddressBookManagement
    {
        //Specifying the connection string from the sql server connection.
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBookServiceDB;Integrated Security=true;";
        // Establishing the connection using the Sqlconnection.  
        SqlConnection connection = new SqlConnection(connectionString); 

        public void DataBaseConnection()
        {
            try
            {
                //create object DateTime class 
                //DateTime.Now class access system date and time 
                // Get current DateTime. It can be any DateTime object in your code.  
                DateTime now = DateTime.Now;
                // open connection
                connection.Open();
                //using SqlConnection
                using (connection) 
                {
                    //print msg Connection is created Successful  with date and time
                    Console.WriteLine($"Connection is created Successful {now}"); 
                }
                //close connection
                connection.Close(); 
            }
            catch (Exception ex)
            {
                // handle exception here
                Console.WriteLine(ex.Message);
            }
        }
    }
}
