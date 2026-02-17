using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccessLayer
{
    public class clsPeopleData
    {

        private static string GetConnectionString()
        {
            try
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true)
                    .Build()
                    .GetConnectionString("DefaultConnection") ?? "";
            }
            catch
            {
                return "";
            }
        }

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

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
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

            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
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

            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
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
                        File.AppendAllText("log.txt", "LoadAllCountries() Exception: " + ex.Message + "\n");
                    }
                }
            }

            return dt;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, 
                                       DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email,
                                       int NationalityCountryID, string ImagePath)
        {

            int PersonID = -1;

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender,
                                                 Address, Phone, Email, NationalityCountryID, ImagePath)
                                                 Values(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender
                                                 @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = FirstName;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = SecondName;
                    if (!string.IsNullOrWhiteSpace(ThirdName))
                    {
                        cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = ThirdName;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = LastName;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
                    cmd.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = Gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email;
                    cmd.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;
                    if (!string.IsNullOrWhiteSpace(ImagePath))
                    {
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = ImagePath;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value;
                    }

                    try
                    {
                        conn.Open();

                        object scalar = cmd.ExecuteScalar();

                        if(scalar != null && scalar != DBNull.Value)
                        {
                            PersonID = Convert.ToInt32(scalar);
                        }

                    }catch(Exception ex)
                    {
                        File.AppendAllText("log.txt", "AddNewPerson() Exception: " + ex.Message + "\n");
                    }
                }
            }

            return PersonID;
        }

        public static bool UpdatePersonInfo(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
                                           DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email,
                                           int NationalityCountryID, string ImagePath)
        {

            int AffectedRows = 0;

            bool UpdatedSuccessfully = false;

            string query = @"UPDATE People 
                                SET NationalNo = @NationalNo,
                                    FirstName = @FirstName,
                                    SecondName = @SecondName,
                                    ThirdName = @ThirdName,
                                    LastName = @LastName,
                                    DateOfBirth = @DateOfBirth,
                                    Gender = @Gender,
                                    Address = @Address,
                                    Phone = @Phone,
                                    Email = @Email,
                                    NationalityCountryID = @NationalityCountryID,
                                    ImagePath = @ImagePath
                            WHERE PersonID = @PersonID";

            using(SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = FirstName;
                    cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = SecondName;
                    if (!string.IsNullOrWhiteSpace(ThirdName))
                    {
                        cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = ThirdName;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ThirdName", SqlDbType.NVarChar).Value = DBNull.Value;
                    }
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = LastName;
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
                    cmd.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = Gender;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = Email;
                    cmd.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NationalityCountryID;
                    if (!string.IsNullOrWhiteSpace(ImagePath))
                    {
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = ImagePath;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value;
                    }

                    try
                    {
                        conn.Open();

                        AffectedRows = cmd.ExecuteNonQuery();

                        if(AffectedRows != 0)
                        {
                            UpdatedSuccessfully = true;
                        }
                    }catch(Exception ex)
                    {
                        File.AppendAllText("log.txt", "UpdatePersonInfo() Exception: " + ex.Message + "\n");
                    }
                }
            }

            return UpdatedSuccessfully;
        }
    }
}
