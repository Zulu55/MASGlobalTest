namespace MASGlobalTest.Web.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common.Models;

    public interface IEmployeeRepository
    {
        Task GetDataAsync();

        Employee GetEmployeeById(int id);

        List<Employee> GetEmployees();
    }
}