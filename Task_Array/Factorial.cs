using System;
namespace Task_Array
{
    public class Factorial
    {
        int res = 1;
        public Factorial(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
        }
    }
}

