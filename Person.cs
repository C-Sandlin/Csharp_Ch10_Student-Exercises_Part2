using System;

namespace NSSFolks
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public double MonthsAtNSS { get; set; }


        public void SayYourInfo()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}, I'm a {Title} at NSS, and I've been here for {MonthsAtNSS} months");
        }
    }
}
