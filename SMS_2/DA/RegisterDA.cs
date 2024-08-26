
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DA.DA
{
    public class RegisterDA
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
        public string SaveStudent(string firstName, string lastName, DateTime dateOfBirth, string email, string phone, string address, string password)
        {
            try
            {


                string flag = string.Empty;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SaveRegData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = firstName });
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = lastName });
                        command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.Date) { Value = dateOfBirth });
                        command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100) { Value = email });
                        command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Value = password });

                        command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = (object)phone ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Value = (object)address ?? DBNull.Value });

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return flag = reader["flag"].ToString();
                            }
                        }
                    }
                }
                return "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
