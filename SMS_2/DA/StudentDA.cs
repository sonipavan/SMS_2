using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SMS_2.Models;
namespace DA.DA
{

    //public class Student
    //{
    //    public int StudentId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime DateOfBirth { get; set; }
    //    public string Email { get; set; }
    //    public string Phone { get; set; }
    //    public string Address { get; set; }
    //    public DateTime EnrollmentDate { get; set; }
    //    public string Gender { get; set; }
    //}
    public class StudentDA
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();

        public List<Students> GetStudentRecords(int? studentId = null)
        {
            List<Students> students = new List<Students>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetStudentRecords", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the student ID parameter if it's provided
                    if (studentId.HasValue)
                    {
                        command.Parameters.Add(new SqlParameter("@StudentId", SqlDbType.Int) { Value = studentId.Value });
                    }

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Students
                            {
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                DateOfBirth = reader.GetString(reader.GetOrdinal("DateOfBirth")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? null : reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address")),
                                EnrollmentDate = reader.GetString(reader.GetOrdinal("EnrollmentDate")),
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? null : reader.GetString(reader.GetOrdinal("Gender"))
                            });
                        }
                    }
                }
            }

            return students;
        }


        public string InsertUpdateStudent(int? studentId = null)
        {
            try
            {
                string result = string.Empty;

                // Create a new instance of the SqlConnection
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Define the stored procedure name
                    string storedProcedureName = "StudentInsertUpdate";

                    // Create a SqlCommand to call the stored procedure
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        // Set the command type to stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        command.Parameters.Add(new SqlParameter("@StudentID", SqlDbType.Int)).Value = (object)1 ?? DBNull.Value; // Replace 1 with actual value
                        command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50)).Value = (object)"John" ?? DBNull.Value; // Replace "John" with actual value
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50)).Value = (object)"Doe" ?? DBNull.Value; // Replace "Doe" with actual value
                        command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.Date)).Value = (object)DateTime.Parse("2000-01-01") ?? DBNull.Value; // Replace date with actual value
                        command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100)).Value = (object)"john.doe@example.com" ?? DBNull.Value; // Replace email with actual value
                        command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 15)).Value = (object)"123-456-7890" ?? DBNull.Value; // Replace phone number with actual value
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 100)).Value = (object)"Male" ?? DBNull.Value; // Replace gender with actual value
                        command.Parameters.Add(new SqlParameter("@EnrollmentDate", SqlDbType.NVarChar, 200)).Value = (object)"2024-08-27" ?? DBNull.Value; // Replace enrollment date with actual value
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200)).Value = (object)"123 Main St, Anytown" ?? DBNull.Value; // Replace address with actual value

                        // Open the connection
                        connection.Open();

                        // Execute the stored procedure and retrieve the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Read the flag value from the result set
                                 result = reader["flag"].ToString();
                                
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
