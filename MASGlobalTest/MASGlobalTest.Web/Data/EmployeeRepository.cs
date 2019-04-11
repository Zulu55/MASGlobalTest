namespace MASGlobalTest.Web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Models;
    using Common.Services;

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApiService apiService;
        private List<Employee> employees;

        public EmployeeRepository()
        {
            this.apiService = new ApiService();
        }

        private async Task GetDataFromApi()
        {
            var response = await this.apiService.GetListAsync<Employee>(
                "http://masglobaltestapi.azurewebsites.net",
                "/api",
                "/Employees");
            if (!response.IsSuccess)
            {
                this.employees = new List<Employee>();
            }

            this.employees = (List<Employee>)response.Result;
        }

        public Employee GetEmployeeById(int id)
        {
            return this.employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        public async Task GetDataAsync()
        {
            await this.GetDataFromApi();
        }
    }
}