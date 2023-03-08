using UserRegistrationProblem;
namespace CustomUnitTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string email = "example@gmail.com";

            bool expectOutput = true;
            EmailValidate vali = new EmailValidate();

            // Act
            bool actualOutput = vali.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectOutput, actualOutput);
        }

        [TestMethod]
        public void InValidation()
        {
            // Arrange
            string email = "example@gmail";

            bool expectOutput = false;
            EmailValidate vali = new EmailValidate();

            // Act
            bool actualOutput = vali.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectOutput, actualOutput);
        }
    }
    
}