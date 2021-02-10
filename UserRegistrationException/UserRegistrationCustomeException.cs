using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationException
{
    public class UserRegistrationCustomeException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIRST_NAME_MESSAGE,LAST_NAME_MESSAGE,EMAIL_ID,
        }
        public UserRegistrationCustomeException(ExceptionType type,string message):base(message)
        {
            this.type =type;
            
        }
    }
}
