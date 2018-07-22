using System;
using static ConsoleApp.Email;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            var john = new Person("John", "Doe");
            string EmailFor(Person person) => AppendDomain(AbbreviateName(person));
            
            var email = EmailFor(john);
            
            Console.WriteLine(email);
        }
    }
}