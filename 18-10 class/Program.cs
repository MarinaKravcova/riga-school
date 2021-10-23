using System;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "John";
            string surname = "Doe";
            string fromFunction = GetSentence (name, surname);

            Console.WriteLine(fromFunction);
            Console.ReadLine();

        }

        static string GetSentence(string name, string surname)
        {
            return $"My name is {name} and my surname is {surname}";
        }
    }
}