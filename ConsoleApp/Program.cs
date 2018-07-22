using System;
using static ConsoleApp.Email;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            var email = 
                new Person("John", "Doe")
                .AbbreviateName()
                .AppendDomain();
            
            Console.WriteLine(email);
        }
    }
}