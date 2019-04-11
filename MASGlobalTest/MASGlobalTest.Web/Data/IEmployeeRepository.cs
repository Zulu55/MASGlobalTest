namespace MASGlobalTest.Web.Data
{
    using System.Collections.Generic;
    using Common.Models;

    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);

        List<Employee> GetEmployees();
    }
}