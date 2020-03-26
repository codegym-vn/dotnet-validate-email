using System;

namespace ValidateEmail
{
    public class EmailExampleTest
    {
        static EmailExample emailExample;
        static string[] validEmail = new string[] { "a@gmail.com", "ab@yahoo.com", "abc@hotmail.com" };
        static string[] invalidEmail = new string[] { "@gmail.com", "ab@gmail.", "@#abc@gmail.com" };

        public static void Main(string[] args)
        {
            emailExample = new EmailExample();
            foreach (var email in validEmail)
            {
                bool isvalid = emailExample.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
            foreach (var email in invalidEmail)
            {
                bool isvalid = emailExample.Validate(email);
                Console.WriteLine("Email is " + email + " is valid: " + isvalid);
            }
        }
    }
}
