using EmployeeApp.Models;

namespace EmployeeApp.Services
{
    public class EmployeeServices
    {
        public List<Employee> GetEmployees()
        {
            return AllEmployees();
        }

        public EmployeeViewModel GetEmployeeAndSalary(int empId)
        {
            Employee employee = AllEmployees().FirstOrDefault(s => s.EmployeeId == empId);

            if(employee == null)
            {
                return null;
            }

            Salary salary = AllSalaries().FirstOrDefault(s => s.EmployeeId == empId);

            if (salary == null)
            {
                return null;
            }

            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                Employee = employee,
                Salary = salary,
            };
            return employeeViewModel;
        }

        private List<Employee> AllEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 101,
                    EmployeeName = "Alice Johnson",
                    Manager = "Robert Smith",
                    Department = "IT",
                    JoiningDate = "2021-05-20",
                    PhoneNumber = "1234567890",
                    Nationality = "American"
                },
                new Employee
                {
                    EmployeeId = 102,
                    EmployeeName = "Bob Brown",
                    Manager = "Linda White",
                    Department = "HR",
                    JoiningDate = "2019-03-14",
                    PhoneNumber = "2345678901",
                    Nationality = "Canadian"
                },
                new Employee
                {
                    EmployeeId = 103,
                    EmployeeName = "Charlie Davis",
                    Manager = "John Doe",
                    Department = "Finance",
                    JoiningDate = "2020-11-01",
                    PhoneNumber = "3456789012",
                    Nationality = "British"
                },
                new Employee
                {
                    EmployeeId = 104,
                    EmployeeName = "David Evans",
                    Manager = "Mary Johnson",
                    Department = "Marketing",
                    JoiningDate = "2018-07-23",
                    PhoneNumber = "4567890123",
                    Nationality = "Australian"
                },
                new Employee
                {
                    EmployeeId = 105,
                    EmployeeName = "Emma Green",
                    Manager = "James Brown",
                    Department = "Sales",
                    JoiningDate = "2017-01-16",
                    PhoneNumber = "5678901234",
                    Nationality = "New Zealander"
                }
            };
            return employees;
        }
        private List<Salary> AllSalaries()
        {
            List<Salary> salaries = new List<Salary>
            {
                new Salary
                {
                    Id = 1,
                    EmployeeId = 101,
                    BasicPay = 5000,
                    Allowence = 1500,
                    ProvidentFund = 500,
                    Bonus = 1000,
                    SalaryTier = "Tier 1",
                    GrossPay = 8000
                },
                new Salary
                {
                    Id = 2,
                    EmployeeId = 102,
                    BasicPay = 6000,
                    Allowence = 2000,
                    ProvidentFund = 600,
                    Bonus = 1200,
                    SalaryTier = "Tier 2",
                    GrossPay = 9800
                },
                new Salary
                {
                    Id = 3,
                    EmployeeId = 103,
                    BasicPay = 5500,
                    Allowence = 1800,
                    ProvidentFund = 550,
                    Bonus = 1100,
                    SalaryTier = "Tier 1",
                    GrossPay = 8950
                },
                new Salary
                {
                    Id = 4,
                    EmployeeId = 104,
                    BasicPay = 6200,
                    Allowence = 2200,
                    ProvidentFund = 620,
                    Bonus = 1300,
                    SalaryTier = "Tier 3",
                    GrossPay = 10320
                },
                new Salary
                {
                    Id = 5,
                    EmployeeId = 105,
                    BasicPay = 5800,
                    Allowence = 1900,
                    ProvidentFund = 580,
                    Bonus = 1150,
                    SalaryTier = "Tier 2",
                    GrossPay = 9430
                }
            };
            return salaries;
        }
    }
}
