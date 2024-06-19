
using ChallengeApp;

namespace Employe.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoIntigersCompare()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;
            //assert
            Assert.AreEqual(number2, number1);
        }
        [Test]
        public void TwoFloatsCompare()
        {
            //arrange
            float number1 = 3.54F;
            float number2 = 3.54F;
            //assert
            Assert.AreEqual(number2, number1);
        }
        [Test]
        public void TwoStringsCompare()
        {
            //arrange
            var employee1 = GetEmployee("marek", "ddd");
            var employee2 = GetEmployee("marek", "ddd"); 
            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreEqual(employee1.LastName, employee2.LastName);
        }
      private Employee GetEmployee(string name, string lastname)
        {
            return new Employee(name, lastname, 44);
        }

    }
}
