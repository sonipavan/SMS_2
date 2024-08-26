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
    }
}
