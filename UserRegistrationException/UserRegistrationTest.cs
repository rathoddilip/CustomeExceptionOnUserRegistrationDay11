using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationException
{
    public class UserRegistrationTest
    {
        string firstNamePattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string FirstName(string firstNamePattern)
        {
            
            Regex regex = new Regex(firstNamePattern);
            var result = regex.Match(firstNamePattern);
            try
            {
                if(!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "First name is not valid");
                }
                return "First name is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "First name is not valid");
            }
            return "First Name is valid";
        }
    }
}
