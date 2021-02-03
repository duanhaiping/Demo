using System.ComponentModel.DataAnnotations;

namespace Demo.ViewModels
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        [Range(0,100)]
        public string SalaryColor { get; set; }
        public string UserName { get; set; }
    }
}