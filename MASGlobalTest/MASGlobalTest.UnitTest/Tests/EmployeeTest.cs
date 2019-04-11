using MASGlobalTest.UnitTest.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MASGlobalTest.UnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        private EmployeeRepositoryMock employeeRepository;

        public EmployeeTest()
        {
            this.employeeRepository = new EmployeeRepositoryMock();
        }

        [TestMethod]
        public void ShouldPassWhenTheEmployeeExists()
        {
            // Arrange
            var employeeId = 1;

            // Act
            var employee = this.employeeRepository.GetEmployeeById(employeeId);

            // Assert
            Assert.IsNotNull(employee);
        }

        [TestMethod]
        public void ShouldPassWhenTheEmployeeNoExists()
        {
            // Arrange
            var employeeId = 111;

            // Act
            var employee = this.employeeRepository.GetEmployeeById(employeeId);

            // Assert
            Assert.IsNull(employee);
        }

        [TestMethod]
        public void ShouldPassWhenEmployeeCountIsCorrect()
        {
            // Arrange

            // Act
            var employees = this.employeeRepository.GetEmployees();

            // Assert
            Assert.AreEqual(employees.Count, 3);
        }
    }
}
