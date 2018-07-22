namespace ConsoleApp
{
    public static class Email
    {
        public static string AbbreviateName(Person person)
            => Abbreviate(person.FirstName) + Abbreviate(person.LastName);

        public static string AppendDomain(string localPart) => $"{localPart}@gmail.com";
        private static string Abbreviate(string s) => s.Substring(0, 2).ToLower();
    }
}