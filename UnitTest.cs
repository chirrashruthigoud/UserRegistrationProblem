
using UserRegistrationProblem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string firstName = "shruthi";
            string lastName = "chirra";
            string email = "siri@gmail.com";
            string mobile = "624752";
            string password = "sunny678";
            string expectedOutput = "SAD";
            EmailValidate e1 = new EmailValidate();

            //Act
            string actualOutput = e1.validate(firstName, lastName, email, mobile, password);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}