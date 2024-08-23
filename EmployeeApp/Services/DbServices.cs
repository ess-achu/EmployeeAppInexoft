using EmployeeApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeApp.Services
{
    public class DbServices
    {
        private readonly string _connectionString;
        public DbServices() 
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            _connectionString = configuration.GetConnectionString("DatabaseConnectionString");
        }
        public List<Employee> GetAllEmployeesFromDb()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetAllEmployees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee
                                {
                                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                    Manager = reader.GetString(reader.GetOrdinal("Manager")),
                                    Department = reader.GetString(reader.GetOrdinal("Department")),
                                    JoiningDate = reader.GetDateTime(reader.GetOrdinal("JoiningDate")).ToString("yyyy-MM-dd"),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")), 
                                    Nationality = reader.GetString(reader.GetOrdinal("Nationality"))
                                };

                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return employees;
        }

        public List<Salary> GetAllEmployeeSalariesFromDb()
        {
            List<Salary> salaries = new List<Salary>();

            try
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand object to represent the stored procedure
                    using (SqlCommand command = new SqlCommand("GetAllEmployeeSalaries", connection))
                    {
                        // Specify that the SqlCommand is a stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Execute the command and read the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Salary salary = new Salary
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                                    BasicPay = reader.GetDouble(reader.GetOrdinal("BasicPay")),
                                    Allowence = reader.GetDouble(reader.GetOrdinal("Allowence")),
                                    ProvidentFund = reader.GetDouble(reader.GetOrdinal("ProvidentFund")),
                                    Bonus = reader.GetDouble(reader.GetOrdinal("Bonus")),
                                    SalaryTier = reader.GetString(reader.GetOrdinal("SalaryTier")),
                                    GrossPay = reader.GetDouble(reader.GetOrdinal("GrossPay"))
                                };

                                salaries.Add(salary);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return salaries;
        }
    }
}
