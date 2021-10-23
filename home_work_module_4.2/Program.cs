using System;

namespace home_work_module_4._2
{
    class Area
    {
        public void Func1()
        {

            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }

        public void Func2()
        {

            Console.WriteLine("Enter the Side of Square: ");
            int Side = Convert.ToInt32(Console.ReadLine());
            int Area = Side * Side;
            Console.WriteLine($"Area of Square with side {Side} is {Area}");
            Console.ReadKey();

        }
    }
}
