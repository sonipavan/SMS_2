using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using Microsoft.Practices.EnterpriseLibrary.Data;
//using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace DA.DA 
{
    public class LoginDA
    {
        string Connection_String = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();

        /// <summary>  
        /// This method is used to get Login data  
        /// </summary>  
        /// <returns></returns>  
        public string VerifyUser(string name, string password)
        {
            // Initialize the connection
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                // Create the command object
                using (SqlCommand command = new SqlCommand("SP_VerifyUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and read the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the value from the result set
                                string status = reader["Status"].ToString();
                                return status;
                            }
                            else
                            {
                                // Handle the case where no rows are returned
                                return "Error: No result returned.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., logging)
                        throw new ApplicationException("An error occurred while verifying the user.", ex);
                    }
                }
            }
        }
    }
}
