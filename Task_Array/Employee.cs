using System;
namespace Task_Array
{
    public class Employee
    {
        public string name = "Farid";
        public string surname = "Guliyev";
        public int age = 19;

        public void GetFullName()
        {
            Console.WriteLine("Musa Afandiyev");
        }

        public void GetFullDataAboutEmployee()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }
}

