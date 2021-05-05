using NUnit.Framework;
using UserRegistration;

namespace NUnitTest
{
    public class Tests
    {
        private UserValidation userValidation;
        [SetUp]
        public void Setup()
        {
            userValidation = new UserValidation();
        }

        [Test]
        public void IfGivenNameIsInCorrectFormat()
        {
            string firstName = "Bhu";
            bool result = userValidation.ValidateFirstName(firstName);
            Assert.IsTrue(result);
        }
        [Test]
        public void IfGivenNameIsInNotCorrectFormat()
        {
            string firstName = "Bh";
            bool result = userValidation.ValidateFirstName(firstName);
            Assert.IsFalse(result);
        }
        [Test]
        public void IfLastNameInCorrectFormat()
        {
            string lastName = "Kumar";
            bool result = userValidation.ValidateLastName(lastName);
            Assert.IsTrue(result);
        }
        [Test]
        public void IfLastNameInNotCorrectFormat()
        {
            string lastName = "kum";
            bool result = userValidation.ValidateLastName(lastName);
            Assert.IsFalse(result);
        }
        [Test]
        public void IfMobileNumberIsInCorrectFormat()
        {
            string mobileNumber = "91 9876558998";
            bool result = userValidation.ValidateMobileNumber(mobileNumber);
            Assert.IsTrue(result);
        }
        [Test]
        public void IfMobileNumberIsNotInCorrectFormat()
        {
            string mobileNumber = "919876558998";
            bool result = userValidation.ValidateMobileNumber(mobileNumber);
            Assert.IsFalse(result);
        }
        [Test]
        public void IfEmailIsInCorrectFormat()
        {
            string email = "bhu@bl.co.in";
            bool result = userValidation.ValidateEmail(email);
            Assert.IsTrue(result);
        }
        [Test]
        public void IfEmailIsNotInCorrectFormat()
        {
            string email = "bhu@bl";
            bool result = userValidation.ValidateEmail(email);
            Assert.IsFalse(result);
        }
        [Test]
        public void IfPasswordIsInCorrectFormat()
        {
            string password = "Bhush12345#";
            bool result = userValidation.ValidatePassword(password);
            Assert.IsTrue(result);
        }
        [Test]
        public void IfPasswordIsNotInCorrectFormat()
        {
            string password = "Bhush12345";
            bool result = userValidation.ValidatePassword(password);
            Assert.IsFalse(result);
        }
    }
}