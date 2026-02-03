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
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        using(SqlDataReader rdr = cmd.ExecuteReader())
                        {

                            if (rdr.HasRows)
                            {
                                dt.Load(rdr);
                            }
                        }
                    }catch(Exception ex)
                    {
                        File.AppendAllText("log.txt", ex.Message + "\n");
                    }

                }
            }

            return dt;
        }
    }
}
