using ChallengeApp;

namespace Employe.Tests
{
    public class Tests
    {
        Employee employee = new Employee("marek", "kowalski", 54);

        [Test]
        public void EmployeeCollectGrade()
        {
            //arrange
            employee.AddGrade(4);
            employee.AddGrade(-10);
            employee.AddGrade(2);
            //act
            var result = employee.SumGrades;
            //assert
            Assert.AreEqual(-4, result);
        }
        [Test]
        public void EmployeeName()
        {
            //arrange
            var employee1 = new Employee("jan", "grzyb", 34);
            //act
            var result1 = employee1.LastName; ;
            //assert
            Assert.That("grzyb", Is.EqualTo(result1));
        }

    }
}