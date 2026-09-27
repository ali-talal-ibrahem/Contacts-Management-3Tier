using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Contacts_Management_DataLayer
{
    public class clsCountriesData
    {

        public static DataTable GetAllCountries() {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) {
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

        public static bool FindCountryByID(int ID , ref string CountryName , ref string PhoneCode , ref string Code)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT CountryName , Code , PhoneCode From Countries Where CountryID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    CountryName = (string)reader["CountryName"];

                    if (reader["Code"] != DBNull.Value)
                    {
                        Code = (string)reader["Code"];
                    }
                    else {
                        Code = "";
                    }

                    if (reader["PhoneCode"] != DBNull.Value)
                    {
                        PhoneCode = (string)reader["PhoneCode"];
                    }
                    else
                    {
                        PhoneCode = "";
                    }
                }
                else {
                    isFound = false;
                }

                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally 
            {
                connection.Close();
            }


            return isFound;
            
        }

        //public static bool FindCountryByName(string CountryName , ref int ID , ref string PhoneCode , ref string Code) { }

        //public static bool FindCountryByCode(string Code, ref int ID , ref string PhoneCode , ref string CountryName) { }

    }
}
