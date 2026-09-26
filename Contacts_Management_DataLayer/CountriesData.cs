using System;
using System.Data;
using System.Data.SqlClient;

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



    }
}
