using System;

namespace Task_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1_ArraysClasstask
            ////Task_1

            //int[] num = new int[5];
            //num[0] = 1;
            //num[1] = 2;
            //num[2] = 3;
            //num[3] = 4;

            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task_2

            //int[] arr = { 1, 5, 3, 8, 2, 9, 2, 5, 7 };
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task_3

            //int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(arr2.Rank);

            ////Task_4

            //Console.WriteLine(arr.Length);

            ////Task_5

            //Console.WriteLine(arr.ToString());
            //int a = 5;
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(a.ToString().GetType());

            ////Task_6

            //string model1 = "Iphone";
            //string modelNum1 = "11 pro";
            //int storage1 = 64;
            //bool isNew1 = false;

            //string model2 = "Iphone";
            //string modelNum2 = "14 pro max";
            //int storage2 = 256;
            //bool isNew2 = true;

            //string model3 = "Samsung";
            //string modelNum3 = "S22 Ultra";
            //int storage3 = 128;
            //bool isNew3 = true;

            //string model4 = "Samsung";
            //string modelNum4 = "S8 plus";
            //int storage4 = 64;
            //bool isNew4 = false;

            //Console.WriteLine($"{model1} {modelNum1} {storage1} {isNew1}");

            ////Task_7

            //var mod1 = new
            //{
            //    model = "Iphone",
            //    modelNum = "11 pro",
            //    modelStorage = 64,
            //    modelIsNew = true
            //};

            //var mod2 = new
            //{
            //    model = "Iphone",
            //    modelNum = "14 pro max",
            //    modelStorage = 256,
            //    modelIsNew = true
            //};

            //var mod3 = new
            //{
            //    model = "Samsung",
            //    modelNum = "S8 plus",
            //    modelStorage = 64,
            //    modelIsNew = false
            //};

            //var mod4 = new
            //{
            //    model = "Iphone",
            //    modelNum = "11 pro",
            //    modelStorage = 64,
            //    modelIsNew = true
            //};

            //Console.WriteLine($"{mod1.model} {mod1.modelNum} {mod1.modelStorage} {mod1.modelIsNew}");

            ////Task_8

            //object[] models = { mod1, mod2, mod3, mod4 };
            //foreach (var item in models)
            //{
            //    Console.WriteLine(item);
            //}






            #endregion

            #region Task1_Classes


            //Phones phone1 = new Phones();
            //phone1.name = "Samsung";
            //phone1.storage = 128;
            //phone1.price = 1250;

            //Phones phone2 = new Phones
            //{
            //    name = "Iphone",
            //    storage = 128,
            //    price = 1780,
            //};

            //Console.WriteLine(phone1.name + " " + phone1.price);
            //Console.WriteLine(phone2.name + " " + phone2.price);

            //Employee emp1 = new Employee();

            //Console.WriteLine(emp1.name);

            //emp1.GetFullName();

            //emp1.GetFullDataAboutEmployee();


            //Student student1 = new Student("Musa", "Afandiyev", 19);
            //Console.WriteLine(student1.name);

            //Console.WriteLine(student1.name);

            //Console.WriteLine(student1.GetFullName());
            //Console.WriteLine(student1.GetFullData());

            #endregion

            //Task_2_Account
            Account account1 = new Account();
            Console.WriteLine(account1.Login("cavid123", "Cavid1993"));

            //Task_3_Factorial
            Factorial numFactorial = new Factorial(5);

            //Task_4_Calculator
            Calculator calc1 = new Calculator();

            Console.WriteLine("Please, enter first variable: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter second variable: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the operation: ");

            Console.WriteLine(calc1.CalculatorMethod(a, b));



        }
    }
}

