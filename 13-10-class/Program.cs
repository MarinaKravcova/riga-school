using System;

namespace _13_10_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Math

            Console.WriteLine ("input number:");
            string inputString = Console.ReadLine();
            int integerVarable = int.Parse(inputString);
           decimal number = Convert.ToDecimal(inputString);

            // value % 2 != 0 Odd number
            // value % 2 != 0 Even number
            //sxpresion ? value_1 : value_2

            string truOrFalse = (number > 1) ? "It is grater then 1" : "it is not greater then one";
            Console.WriteLine(); 

            #endregion

        }
    }
}
