using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void DisplayLastName()
        {
            Console.WriteLine("Enter your email Like : -abc.xyz@bl.co.in : ");
            string email = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*\.(co\.in|in)$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }


        }

        public static void Main(string[] args)
        {
            Program.DisplayLastName();
        }
    }
}