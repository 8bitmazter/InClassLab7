using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = nameValidation();
            Console.WriteLine("Thanks, " + userName + " What's your email?"); //see below nameValidation Method for more
            string userEmail = emailValidation();
            Console.WriteLine("Thank you. Please also enter a valid phone number in this format xxx-xxx-xxxx"); //see below emailValidation for more
            string userPhone = phoneValidation();
            Console.WriteLine("Also please put in the date, in this format xx/xx/xxxx"); //see below phoneValidation Method for more
            string userDate = dateValidation();
            Console.WriteLine("To confirm " + userName + " your email is " + userEmail + " and your phone number is " + userPhone + " and Today's date is " + userDate); //information should be correct
            Console.WriteLine("Thank you for your information. The FBI is greatly appreciated"); //HAHA Burt Macklin got your info!
            Console.ReadKey();

        }
        public static string nameValidation()
        {
            Console.WriteLine("What is your name?");
            //input
            string userName = Console.ReadLine();

            //processing
            while(!Regex.IsMatch(userName, @"[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("I'm sorry! That's not a name.");
                userName = Console.ReadLine();
            }

            //output
            return userName;
        }
        public static string emailValidation()
        {
            //input
            string userEmail = Console.ReadLine();

            //processing
            while(!Regex.IsMatch(userEmail, @"^([A-z0-9]{5,30})@([A-z0-9]{1,10}).([A-z0-9]{1,3})$"))
            {
                Console.WriteLine("Please provide a real email");
                userEmail = Console.ReadLine();
            }

            //output
            return userEmail;
        }
        public static string phoneValidation()
        {
            //input
            string userPhone = Console.ReadLine();

            //processing
            while(!Regex.IsMatch(userPhone, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                Console.WriteLine("Please provide a real phone number");
                userPhone = Console.ReadLine();
            }
            //output
            return userPhone;
        }
        public static string dateValidation()
        {
            //input
            string userDate = Console.ReadLine();

            //processing
            while(!Regex.IsMatch(userDate, @"^(0?[1-9]|1[0-2])[\/](0?[1-9]|[12]\d|3[01])[\/](19|20)\d{2}$"))
            {
                Console.WriteLine("Please put in a valid date for the format of xx/xx/xxxx");
                userDate = Console.ReadLine();
            }
            //output
            return userDate;
        }
    }
}
