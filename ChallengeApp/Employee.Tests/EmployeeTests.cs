
using ChallengeApp;
using Microsoft.VisualBasic;

namespace Employe.Tests
{
    public class EmployeeTests
    {
        Employee emp = new Employee("Jan", "duda");
        //employee.AddGrade(2);

        [Test]
        public void checkAverage()
        {
            //arrange
            emp.AddGrade(4);
            emp.AddGrade(2);
            emp.AddGrade(6);
            //act
            var stats = emp.GetStatistics();
            //assert
            Assert.AreEqual(stats.Average, 4.0F);
        }
        [Test]
        public void checkMax()
        {
            //arrange
            emp.AddGrade(4);
            emp.AddGrade(5);
            //act
            var stats1=emp.GetStatistics();
            //assert
            Assert.AreEqual(stats1.Max, 5.0F);
        }
        [Test]
        public void checkMin()
        {
            //arrrange
            emp.AddGrade(2);
            emp.AddGrade(2);
            emp.AddGrade(3);
            //act
            var stats2=emp.GetStatistics();
            //assert
            Assert.AreEqual(stats2.Min, 2.0F);
        }
    }
}
