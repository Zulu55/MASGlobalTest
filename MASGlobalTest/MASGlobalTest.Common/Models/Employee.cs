namespace MASGlobalTest.Common.Models
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contractTypeName")]
        [Display(Name = "Contract Type Name")]
        public string ContractTypeName { get; set; }

        [JsonProperty("roleId")]
        [Display(Name = "Role Id")]
        public int RoleId { get; set; }

        [JsonProperty("roleName")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        [JsonProperty("roleDescription")]
        [Display(Name = "Role Description")]
        public object RoleDescription { get; set; }

        [JsonProperty("hourlySalary")]
        [Display(Name = "Hourly Salary")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal HourlySalary { get; set; }

        [JsonProperty("monthlySalary")]
        [Display(Name = "Monthly Salary")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal MonthlySalary { get; set; }

        [Display(Name = "Annual Salary")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal AnnualSalary
        {
            get
            {
                if (this.ContractTypeName.Equals("MonthlySalaryEmployee"))
                {
                    return this.MonthlySalary * 12;
                }

                return 120 * this.HourlySalary * 12;
            }
        }
    }
}