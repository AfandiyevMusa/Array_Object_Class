using System;
namespace Task_Array
{
    public class Calculator
    {
        public int CalculatorMethod(int a, int b)
        {
            int res = 0;
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    break;
                default:
                    return res;
            }
            return res;
        }
    }
}