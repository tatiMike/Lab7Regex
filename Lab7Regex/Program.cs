using System;
using System.Text.RegularExpressions;

namespace Lab7Regex
{
    class Program
    {
        public static string GiveDate()
        {
            string date = Console.ReadLine();

            Match temp = Regex.Match(date, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$");

            while (!Regex.IsMatch(date, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"))
            {
                Console.WriteLine("Sorry, date is not valid.");
                date = Console.ReadLine();
            }
            if ((Regex.IsMatch(date, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$")))

                Console.WriteLine("Date is valid!");
                return date;
        }
        public static string GivePhone()
        {
            string phone = Console.ReadLine();

            Match temp = Regex.Match(phone, @"([2-9]{1}[0-9]{2}\-[2-9]{1}[0-9]{2}\-[1-9]{4})");

            while (!Regex.IsMatch(phone, @"([2-9]{1}[0-9]{2}\-[2-9]{1}[0-9]{2}\-[1-9]{4})"))
            {
                Console.WriteLine("Sorry, number is not valid. Please enter in XXX-XXX-XXXX format.");
                phone = Console.ReadLine();
            }
            if ((Regex.IsMatch(phone, @"([2-9]{1}[0-9]{2}\-[2-9]{1}[0-9]{2}\-[0-9]{4})")))

                Console.WriteLine("Number is valid!");
                return phone;
        }
        public static string GiveName()
        {
            string name = Console.ReadLine();

            Match temp = Regex.Match(name, @"(^[A-Z]{1}[a-z]{1,30}$)");

            while (!Regex.IsMatch(name, @"(^[A-Z]{1}[a-z]{1,30}$)"))
            {
                Console.WriteLine("Sorry, name is not valid.");
                name = Console.ReadLine();
            }
            if ((Regex.IsMatch(name, @"(^[A-Z]{1}[a-z]{1,30}$)")))

                Console.WriteLine("Name is valid!");
                return name; 

        }
        public static string GiveEmail()
        {
            string email = Console.ReadLine();

            Match temp = Regex.Match(email, @"^[a-zA-Z0-9]{5,30}\@{1}[a-zA-Z0-9]{5,10}\.[a-z]{2,3}");

            while (!Regex.IsMatch(email, @"^[a-zA-Z0-9]{5,30}\@{1}[a-zA-Z0-9]{5,10}\.[a-z]{2,3}"))
            {
                Console.WriteLine("This is the wrong format. Please try again.");
                email = Console.ReadLine();
            }
            if ((Regex.IsMatch(email, @"^[a-zA-Z0-9]{5,30}\@{1}[a-zA-Z0-9]{5,10}\.[a-z]{2,3}")))

                Console.WriteLine("Email is valid!");
                return email;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            GiveName();
            
            Console.WriteLine("\nEnter an email.");
            GiveEmail();

            Console.WriteLine("\nEnter a phone number.");
            GivePhone();

            Console.WriteLine("\nEnter a date.");
            GiveDate();

            Console.WriteLine("Good bye!");
        
        }
    }
}
