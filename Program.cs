using System;

namespace Student.SharpInstructions
{
    class Program
    {
        public static event Action OnSubProgramCompleted;
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
        // IF and ELSE Рботает
        static void ExecuteIfElse()
        {
            Console.Clear();
            Console.WriteLine("Введите число для проверки четности:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число четное.");
            else
                Console.WriteLine("Число нечетное.");
            WaitForKey();
        }
        // WHILE Работает
        static void ExecuteWhile()
        {
            Console.Clear();
            Console.WriteLine("Введите положительное число для подсчета:");
            int count = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < count)
            {
                Console.WriteLine(i + 1);
                i++;
            }
            WaitForKey();
        }
        // DO...WHILE Работает
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
            WaitForKey();
        }
        // FOR Работает
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
            WaitForKey();
        }
        // FOREACH Работает
        static void ExecuteForeach()
        {
            Console.Clear();
            Console.WriteLine("Введите несколько чисел, разделенных пробелом:");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("Результат:");
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            WaitForKey();
        }
        //SWITCH Работает
        static void ExecuteSwitch()
        {
            Console.Clear();
            Console.WriteLine("Введите номер от 1 до 3: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Вы выбрали один.");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали два.");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали три.");
                    break;
                default:
                    Console.WriteLine("Неверный номер.");
                    break;
            }
            WaitForKey();
        }

        static void WaitForKey()
        {
            Console.WriteLine("Нажмите Enter, чтобы повторить, или Esc, чтобы вернуться в главное меню.");
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter)
                {
                    break; // Возврат к подпрограмме
                }
                else if (key == ConsoleKey.Escape)
                {
                    Environment.Exit(0); // Возврат в главное меню или выход из программы
                }
            }
        }

    }
}
