using System;

namespace riga_school
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

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
=======
            Console.WriteLine("Hello World!" +
                "My name is Marina,\n spend 13 h per day on computer,\nthats why I can`t wright down the long text for my home work \n I have a dog, it is preatty. I have a masters degree in Publick relations and advertising.");
            Console.ReadLine();
            //comment
            //comment
            //comment one more one 
>>>>>>> c751eac294d29b43842e32921bb3503819d2c1c0
        }
    }
}
