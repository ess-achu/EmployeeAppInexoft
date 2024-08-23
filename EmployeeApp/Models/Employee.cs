using System.ComponentModel;

namespace EmployeeApp.Models
{
    public class Employee
    {
        [DisplayName("Emlpoyee Id")]
        public int EmployeeId { get; set; }
        [DisplayName("Name")]
        public string EmployeeName { get; set; }
        [DisplayName("Manager Name")]
        public string Manager {  get; set; }
        [DisplayName("Department")]
        public string Department {  get; set; }
        [DisplayName("Date of Joining")]
        public string JoiningDate {  get; set; }
        [DisplayName("Mobile")]
        public string PhoneNumber { get; set; }
        [DisplayName("nationality")]
        public string Nationality { get; set; }
    }

    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public double BasicPay { get; set; }
        public double Allowence { get; set; }
        public double ProvidentFund { get; set; }
        public double Bonus { get; set; }
        public string SalaryTier { get; set; }
        public double GrossPay { get; set; }
    }

    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Salary Salary { get; set; }
    }
}
