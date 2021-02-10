using NUnit.Framework;
using UserRegistrationException;
namespace NUnitTestProject
{
    public class Tests
    {
        UserRegistrationTest userRegistrationTest;
         [SetUp]
        public void Setup()
        {
            userRegistrationTest = new UserRegistrationTest();
        }

        /// <summary>
        /// Act methodology- method calling 
        /// Assert methodology- here we can define the output 
        /// </summary>
        [Test]
        public void GivenFirstNameExpectingTrueResult()
        {
            string firstName ="dilip";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.FirstName(firstName);
            }
            catch(UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("first name is not valid",exception.Message);
            }
            
        }
        [Test]
        public void GivenLastNameExpectingTrueResult()
        {
            string lastName ="rathod";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.LastName(lastName);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("last name is not valid", exception.Message);
            }

        }
        [Test]
        public void GivenEmailExpectingTrueResult()
        {
            string emailid = "abc.xyz@yahoo.com";
            string actual = " "; 
            try
            {
                actual = userRegistrationTest.EmailId(emailid);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("emailid is not valid", exception.Message);
            }

        }
        [Test]
        public void MobileNumberExpectingTrueResult()
        {
            string mobileNumber ="91+ 9988776655";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.MobileNumber(mobileNumber);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("mobile number is not valid", exception.Message);
            }

        }
        [Test]
        public void PasswordRule1ExpectingTrueResult()//minimum 8 character
        {
            string PasswordRule1 ="login@1";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.PasswordRule1(PasswordRule1);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("password rule1 is not valid", exception.Message);
            }

        }
        [Test]
        public void PasswordRule2ExpectingTrueResult()//Atleast 1 upperCase character
        {
            string PasswordRule2 = "login@123";
            string actual = " ";
            try
            {
                actual = userRegistrationTest.PasswordRule2(PasswordRule2);
            }
            catch (UserRegistrationCustomeException exception)
            {
                Assert.AreEqual("password rule2 is not valid", exception.Message);
            }

        }
    }
}
