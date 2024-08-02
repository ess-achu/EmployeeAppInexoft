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
        public float BasicPay { get; set; }
        public float Allowence { get; set; }
        public float ProvidentFund { get; set; }
        public float Bonus { get; set; }
        public string SalaryTier { get; set; }
        public float GrossPay { get; set; }
    }

    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Salary Salary { get; set; }
    }
}
