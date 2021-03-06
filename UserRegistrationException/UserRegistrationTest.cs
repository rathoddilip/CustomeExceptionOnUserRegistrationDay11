﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationException
{
    public class UserRegistrationTest
    {
        string firstNamePattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
        
        public string FirstName(string firstName)
        {
            
            Regex regex = new Regex(firstNamePattern);
            var result = regex.Match(firstName);
            try
            {
                if(!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
                }
                return "first name is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.FIRST_NAME_MESSAGE, "first name is not valid");
            }
               
        }
        public string LastName(string lastName)
        {
            string lastNamePattern =@"^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex = new Regex(lastNamePattern);
            var result = regex.Match(lastName);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
                }
               return "last name is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.LAST_NAME_MESSAGE, "last name is not valid");
            }
            
        }
        public string EmailId(string emailid)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}(.[][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            var result = regex.Match(emailid);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.EMAIL_ID, "emailid is not valid");
                }
                return "emailid is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.EMAIL_ID, "emailid is not valid");
            }

        }
        public string MobileNumber(string mobileNumber)
        {
            string mobileNumberPattern = @"^[0-9]{2,}\s[0-9]{10,}$";
            Regex regex = new Regex(mobileNumberPattern);
            var result = regex.Match(mobileNumber);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.MOBILE_NUMBER, "mobile number is not valid");
                }
                return "mobile number is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.MOBILE_NUMBER, "mobile number is not valid");
            }

        }
        public string PasswordRule1(string passwordRule1)
        {
            string passwordRule1Pattern = @"^.{8,}$";
            Regex regex = new Regex(passwordRule1Pattern);
            var result = regex.Match(passwordRule1);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule1 is not valid");
                }
                return "password rule1 is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule1 is not valid");
            }

        }
        public string PasswordRule2(string passwordRule2)
        {
            string passwordRule2Pattern = @"^(?=.*[A-Z]).{8,}$";
            Regex regex = new Regex(passwordRule2Pattern);
            var result = regex.Match(passwordRule2);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule2 is not valid");
                }
                return "password rule2 is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule2 is not valid");
            }

        }
        public string PasswordRule3(string passwordRule3)
        {
            string passwordRule3Pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
            Regex regex = new Regex(passwordRule3Pattern);
            var result = regex.Match(passwordRule3);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule3 is not valid");
                }
                return "password rule3 is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule3 is not valid");
            }

        }
        public string PasswordRule4(string passwordRule4)
        {
            string passwordRule4Pattern = @"^(?=.{8,}$)(?=[^A-Z]*[A-Z][^A-Z]*$)\w*\W\w*$";
            Regex regex = new Regex(passwordRule4Pattern);
            var result = regex.Match(passwordRule4);
            try
            {
                if (!result.Success)
                {
                    throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule4 is not valid");
                }
                return "password rule4 is valid";
            }
            catch
            {
                throw new UserRegistrationCustomeException(UserRegistrationCustomeException.ExceptionType.PASSWORDRULES, "password rule4 is not valid");
            }

        }
    }
}
