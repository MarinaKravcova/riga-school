using System;

namespace riga_school
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Casting

            int integerVariable = 1;
            long decimalVariable = 12222;
            decimal decimalVariable = 1;
            string stringVariable = " 100 "; 

            #endregion

            #region Mynumbers
            int number1 = 100;
            int number2 = 1;
            int result = number1 + number2;

            string number3 = "100";
            string number4 = "1";

            string stringResult = number3 + number4; //What is the result?

            Console.WriteLine($"int result: {result}");
            Console.WriteLine($"string result: {stringResult}");
            #endregion

            #region MyWorld


            string helloWorldVariable = "Hello World! line 1.";

            string helloWorldVariableNumber2 = "Hello World! line 2.";

         // Line1
         Console.WriteLine("Line 1: " + helloWorldVariable);
            Console.WriteLine(Environment.NewLine);

         // Line2
         Console.WriteLine("Line 2: " + helloWorldVariableNumber2);
            Console.WriteLine(Environment.NewLine);

        // Line3
         Console.WriteLine("Line 3: " + helloWorldVariableNumber2);
            Console.WriteLine(Environment.NewLine);

         #endregion MyWorld
        }
    }
}
