using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
     class EmailValidate
    {
        public string validate(string firstName, string lastName, String email, string mobile, string password)
        {
            if (firstName == "" && lastName == "" && email == "" && mobile == "" && password == "")
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
