using System;
namespace Student.SharpInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите действие");
            Console.WriteLine("1: IF ELSE");
            Console.WriteLine("2: WHILE");
            Console.WriteLine("3: DO WHILE");
            Console.WriteLine("4: FOR");
            Console.WriteLine("5: FOREACH");
            Console.WriteLine("6: SWITCH");

            string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Введите число:");
                        int number = int.Parse(Console.ReadLine());
                        if (number > 0)
                        {
                            Console.WriteLine("Число положительное");
                        }
                        else
                        {
                            Console.WriteLine("Число не положительное");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Введите число:");
                        int count = int.Parse(Console.ReadLine());
                        while (count < 20)
                        {
                            Console.WriteLine("Операция выполняется:" + count);
                            count++;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите число:");
                        int DOcount = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Операция выполняеться:" + DOcount);
                            DOcount++;
                        } while (DOcount < 20);
                        break;
                    case "4":
                        for (int i=0; i<20; i++)
                        {
                            Console.WriteLine("Операция выполняеться:"+i)
                        }
                        break;

                }            
            }
        }
    }
}