using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime today = System.DateTime.Today;
            DateTime tomorrow = DateTime.Now;
            Console.WriteLine(today);
            DateTime now = DateTime.UtcNow;
            Console.WriteLine($"Now: {tomorrow}, Utc Now: {now}");

            DateTime dateOfBirth = new DateTime(1993, 06, 05);
            double age = DateTime.Today.Subtract(dateOfBirth).TotalDays;
            WriteLine(age / 365);

            //1 Month
            int durationInDays = 7; //Week

            DateTime subscriptionDate = DateTime.Now, expiresOn = subscriptionDate.AddDays(durationInDays);
            string msg = $"Welcome to MTN Data Plan for {durationInDays} days";
            SendSmsSubscription(msg, expiresOn);
            
            ReadKey();
        }

        private static void SendSmsSubscription(string msg, DateTime expiresOn)
        {
            WriteLine(msg);
        }
    }
}
