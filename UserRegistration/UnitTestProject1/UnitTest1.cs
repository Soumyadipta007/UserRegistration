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
    }
}
