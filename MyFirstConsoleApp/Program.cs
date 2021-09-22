using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Today);

            GlazerApp.RunExample();
            Console.Write("\nPress any key to exit. ");
            Console.ReadKey();
        }

        /* Gets the user name and location */
        static private void GetUserNameAndLocation()
        {
            // Create new instance of the Person class.
            Person person = new Person();

            // prints it out on the console
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();

            Console.WriteLine("Hi {0}! Where are you from?", person.name);
            person.location = Console.ReadLine();

            Console.WriteLine("I have never been to {0}. I bet it is nice.", person.location);
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();

        }

        /* Calculates the number of days until christmas */
        static private void ChristmasCountdown(DateTime date)
        {
            DateTime dateToday = DateTime.Today;

            DateTime christmasDate = new DateTime(dateToday.Year, 12, 25);

            Console.WriteLine("\nToday is {0:d}", dateToday);

            int daysUntilChristmas = christmasDate.Subtract(date).Days;

            Console.WriteLine("\nThere are {0} days until Christmas", daysUntilChristmas);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }


    }
}