using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationReflection
{
    public class Validation
    {
        public string RegexName = "^[A-Z]{1}[a-z]{3,}$";
        public void FirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, RegexName) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");
        }
    }
}
