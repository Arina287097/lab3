using System;

namespace Student.SharpInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажмите Enter:");
                Console.WriteLine("1 - IF ELSE");
                Console.WriteLine("2 - WHILE");
                Console.WriteLine("3 - DO WHILE");
                Console.WriteLine("4 - FOR");
                Console.WriteLine("5 - FOREACH");
                Console.WriteLine("6 - SWITCH");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ExecuteIfElse();
                        break;
                    case "2":
                        ExecuteWhile();
                        break;
                    case "3":
                        ExecuteDoWhile();
                        break;
                    case "4":
                        ExecuteFor();
                        break;
                    case "5":
                        ExecuteForeach();
                        break;
                    case "6":
                        ExecuteSwitch();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }

        static void ExecuteIfElse()
        {
            Console.Clear();
            Console.WriteLine("Введите число (1 или 2): ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
                Console.WriteLine("Вы ввели 1.");
            else if (number == 2)
                Console.WriteLine("Вы ввели 2.");
            else
                Console.WriteLine("Вы ввели неверное значение.");
            WaitToContinue();
        }

        static void ExecuteWhile()
        {
            Console.Clear();
            Console.WriteLine("Счетчик от 1 до 5: ");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine(count);
                count++;
            }
            WaitToContinue();
        }

        static void ExecuteDoWhile()
        {
            Console.Clear();
            Console.WriteLine("Введите количество повторений: ");
            int repetitions = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count <= repetitions);
            WaitToContinue();
        }

        static void ExecuteFor()
        {
            Console.Clear();
            Console.WriteLine("Для выполнения подпрограммы FOR введите начальное число и количество повторений последовательно через Enter, для возврата к списку подпрограмм нажмите Esc:");
            Console.WriteLine("Начальное число:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество повторений:");
            int repeats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат:");
            for (int i = start; i < start + repeats; i++)
            {
                Console.WriteLine(i);
            }
            WaitToContinue();
        }

        static void ExecuteForeach()
        {
            Console.Clear();
            string[] items = { "Первый", "Второй", "Третий" };
            Console.WriteLine("Элементы массива:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            WaitToContinue();
        }

        static void ExecuteSwitch()
        {
            Console.Clear();
            Console.WriteLine("Введите номер от 1 до 3: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Вы выбрали 1.");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали 2.");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали 3.");
                    break;
                default:
                    Console.WriteLine("Неверный номер.");
                    break;
            }
            WaitToContinue();
        }

        static void WaitToContinue()
        {
            Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}
