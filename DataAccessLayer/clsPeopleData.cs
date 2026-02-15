using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccessLayer
{
    public class clsPeopleData
    {

        private static string _ConnectionString = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("DefaultConnection")!;

        public static DataTable GetPeopleData()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT p.NationalNo, 
                                    p.FirstName, 
                                    p.SecondName, 
                                    p.ThirdName, 
                                    p.LastName, 
                                    p.DateOfBirth, 
                                    p.Gender, 
                                    p.Address, 
                                    p.Phone, 
                                    p.Email,
                                    c.CountryName,
                                    p.ImagePath
                                    FROM People p
                                    JOIN Countries c
                                        ON p.NationalityCountryID = c.CountryID";

            using (SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {

                            if (rdr.HasRows)
                            {
                                dt.Load(rdr);
                            }
                        }
                    } catch (Exception ex)
                    {
                        File.AppendAllText("log.txt", "GetPeopleData() Exception: " + ex.Message + "\n");
                    }

                }
            }

            return dt;
        }

        public static bool NationalNumberExists(string NationalNumber)
        {
            bool IsExists = false;

            string query = @"SELECT IsFound = 1 
                            FROM People 
                            WHERE NationalNO = @NationalNumber";

            using(SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.Add("@NationalNumber", SqlDbType.NVarChar, 20).Value = NationalNumber;

                    try
                    {
                        conn.Open();

                        IsExists = (cmd.ExecuteScalar() != null);

                    }catch(Exception ex)
                    {
                        File.AppendAllText("log.txt", "NationalNumberExists() Exception: " + ex.Message + "\n");
                    }
                }
            }

            return IsExists;
        }

        public static DataTable LoadAllCountries()
        {
            string query = @"SELECT CountryID, CountryName 
                             FROM Countries;";

            DataTable dt = new DataTable();

            using(SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    try
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt;
        }
    }
}
