using System;
namespace Task_Array
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public bool isGraduated;

        public Student()
        {
            Console.WriteLine("Let's start from here!");
        }

        public Student(string stuName, string stuSurname, int stuAge):this(19)
        {
            name = stuName;
            surname = stuSurname;
            age = stuAge;
            Console.WriteLine(name + " " + surname + " " + age + "-");
        }

        public Student(int age):this(false)
        {
            Console.WriteLine(age);
        }

        public Student(string stuAdress):this()
        {
            address = stuAdress;
            Console.WriteLine(address);
        }

        public Student(bool stuIsGraduated):this("Sahil")
        {
            isGraduated = stuIsGraduated;
            Console.WriteLine(isGraduated);
        }

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullData()
        {
            return GetFullName() + " " + age;
        }
    }
}

