namespace MASGlobalTest.UnitTest.Mocks
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Models;
    using Web.Data;

    public class EmployeeRepositoryMock : IEmployeeRepository
    {
        private readonly List<Employee> employees;

        public EmployeeRepositoryMock()
        {
            this.employees = new List<Employee>();
            this.GetDataAsync().Wait();
        }

        public async Task GetDataAsync()
        {
            this.employees.Add(new Employee
            {
                ContractTypeName = "HourlySalaryEmployee",
                HourlySalary = 60000,
                Id = 1,
                MonthlySalary = 80000,
                Name = "Juan",
                RoleDescription = "Developer",
                RoleId = 1,
                RoleName = "Developer"
            });

            this.employees.Add(new Employee
            {
                ContractTypeName = "MonthlySalaryEmployee",
                HourlySalary = 60000,
                Id = 2,
                MonthlySalary = 80000,
                Name = "Pedro",
                RoleDescription = "Developer",
                RoleId = 1,
                RoleName = "Developer"
            });

            this.employees.Add(new Employee
            {
                ContractTypeName = "MonthlySalaryEmployee",
                HourlySalary = 60000,
                Id = 2,
                MonthlySalary = 80000,
                Name = "Maria",
                RoleDescription = "Developer",
                RoleId = 1,
                RoleName = "Developer"
            });
        }

        public Employee GetEmployeeById(int id)
        {
            return this.employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
    }
}
