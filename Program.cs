﻿using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                EmailValidate e1 = new EmailValidate();
                e1.validate("sagar", "shahu", "shahu@gmail.com", "555666", "pass123");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}