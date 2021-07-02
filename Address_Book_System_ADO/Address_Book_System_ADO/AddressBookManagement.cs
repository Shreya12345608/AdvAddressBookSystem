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
        // UC2:- Ability to create a Address Book Table with first and last names, address, city, state, zip, phone number and email as its attributes 
        public void GetAllContact()
        {
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {
                    // Query to get all the data from the table
                    string query = "select * from AddressBook";
                    // Impementing the command on the connection fetched database table
                    // Create a command object  
                    SqlCommand command = new SqlCommand(query, connection); 

                    connection.Open();  //Open the connection.
                    // executing the sql data reader to fetch the records
                    // Call ExecuteReader to return a SQlDataReader  
                    SqlDataReader reader = command.ExecuteReader();  
                    if (reader.HasRows)
                    {

                        // Loop through all the rows in the DataTableReader
                        // Mapping the data to the employee model class object
                        while (reader.Read())  
                        {
                            model.FirstName       = reader.GetString(0);
                            model.LastName        = reader.GetString(1);
                            model.Address         = reader.GetString(2);
                            model.City            = reader.GetString(3);
                            model.State           = reader.GetString(4);
                            model.Zip             = reader.GetInt32(5);
                            model.PhoneNumber     = reader.GetInt64(6);
                            model.EmailId         = reader.GetString(7);
                            model.AddressBookType = reader.GetString(8);
                            model.AddressBookName = reader.GetString(9);
                            //prinitng the output
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", model.FirstName, model.LastName,
                                model.Address, model.City, model.State, model.Zip, model.PhoneNumber, model.EmailId, model.AddressBookType, model.AddressBookName);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found Address Book System Table");
                    }
                    reader.Close();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                // Always ensuring the closing of the connection
                connection.Close(); 
            }

        }
    }
}
