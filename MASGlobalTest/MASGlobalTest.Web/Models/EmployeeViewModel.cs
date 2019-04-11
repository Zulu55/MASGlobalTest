namespace MASGlobalTest.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;

    public class EmployeeViewModel
    {
        [Display(Name = "Employee ID")]
        public int? EmployeeId { get; set; }

        public List<Employee> Employees { get; set; }
    }
}