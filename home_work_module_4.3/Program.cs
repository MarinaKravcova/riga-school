using System;

namespace home_work_module_4._3
{
    class Program
    {
        private static string cout;

        static void Main(string[] args)
        {
    {
        int[] arr = { 1, 2, 3, 8, 2, 6, 7 };
        int n = 6, sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
                cout << "The array sum is " << sum;
        return 0;
    }
    }
    }
}
