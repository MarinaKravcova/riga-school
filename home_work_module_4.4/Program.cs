using System;

namespace home_work_module_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] {
    "Marakuja",
    "Lemon Juice",
    "Gin",
    "Orange Sirup",
    "Sparkling water"
}; 
           
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }
        }
    }
}
