using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAY34_TSQL_Transaction;
namespace EmployeeManagmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalarydetails_AbleToUpdateSalaryDetails()
        {
            Salary salary = new Salary();
            SalaryUpdateModel salaryUpdateModel = new SalaryUpdateModel()
            {
                SalaryId = 2,
                Month = "Jan",
                EmployeeSalary = 1300,
                EmployeeId = 1
            };

            int EmpSalary = salary.UpdateEmployeeSalary(salaryUpdateModel);
            Assert.AreEqual(salaryUpdateModel.EmployeeSalary, EmpSalary);
        }
    }
}