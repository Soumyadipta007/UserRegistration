using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Happy")]
        public void GivenHappyReturnSuccessfulForFirstName(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkFirstName();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenSadReturnUnSuccessfulForFirstName(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkFirstName();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenHappyReturnSuccessfulForLastName(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkLastName();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenSadReturnUnSuccessfulForLastName(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkFirstName();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenHappyReturnSuccessfulForEmail(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkEmail();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenSadReturnUnSuccessfulForEmail(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkEmail();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenHappyReturnSuccessfulForMobileNum(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkMobileNumber();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenSadReturnUnSuccessfulForMobileNum(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkMobileNumber();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenHappyReturnSuccessfulForPassword(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkPassword();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenSadReturnUnSuccessfulForPassword(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.checkPassword();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        public void GivenMultipleEmailsCheckIfSuccessful()
        {
            //Arrange
            UserRegister userRegister = new UserRegister();
            //Act
            var result = userRegister.checkmultipleEmails("abc@gmail.com","abc123@gmail.com");
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("soumya")]
        public void GivenFirstNameThrowInvalidFirstNameExceptionIfInvalid(string fname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.checkFirstName(fname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("First Name is Invalid", e.Message);
            }
        }
        [TestMethod]
        [DataRow("banerjee")]
        public void GivenLastNameThrowInvalidLastNameExceptionIfInvalid(string lname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.checkLastName(lname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Last Name is Invalid", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@gmail.123")]
        public void GivenEmailThrowInvalidEmailExceptionIfInvalid(string email)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.checkEmail(email);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Email is Invalid", e.Message);
            }
        }
        [TestMethod]
        [DataRow("91 95ab111111")]
        public void GivenMobileNumberThrowInvalidMobileNumberExceptionIfInvalid(string mobNumber)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.checkMobileNumber(mobNumber);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Mobile number is Invalid", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abcdefgh")]
        public void GivenPasswordThrowInvalidPasswordExceptionIfInvalid(string password)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.checkPassword(password);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Password is Invalid", e.Message);
            }
        }
    }
}
