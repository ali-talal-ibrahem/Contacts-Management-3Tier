using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Contacts_Management_DataLayer
{
    public class clsContactData
    {
        public static bool GetContactinfoById(int ID, ref string firstName, ref string lastName ,ref string email ,ref string phone, ref string address, ref DateTime dateOfBirth, ref int countryID, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath FROM Contacts WHERE ContactID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;

                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    countryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        imagePath = "";
                    }
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch
            {
                isFound = false;
            }
            finally {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetAllContactsFromDataBase() {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch
            {
            
            }
            finally {
                connection.Close();
            }
            return dt;
        }


        static void Main(string[] args)
        {


        }
    }
}

