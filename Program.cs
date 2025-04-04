using System;

namespace Student.SharpInstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1: IF ELSE");
            Console.WriteLine("2: WHILE");
            Console.WriteLine("3: DO WHILE");
            Console.WriteLine("4: FOR");
            Console.WriteLine("5: FOREACH");
            Console.WriteLine("6: SWITCH");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Пример IF ELSE
                    Console.WriteLine("Введите число:");
                    int number = int.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        Console.WriteLine("Число положительное.");
                    }
                    else
                    {
                        Console.WriteLine("Число неположительное.");
                    }
                    break;

                case "2":
                    // Пример WHILE
                    int count = 0;
                    while (count < 5)
                    {
                        Console.WriteLine("Count is: " + count);
                        count++;
                    }
                    break;

                case "3":
                    // Пример DO WHILE
                    int doCount = 0;
                    do
                    {
                        Console.WriteLine("Do Count is: " + doCount);
                        doCount++;
                    } while (doCount < 5);
                    break;

                case "4":
                    // Пример FOR
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("For Loop Count is: " + i);
                    }
                    break;

                case "5":
                    // Пример FOREACH
                    string[] colors = { "Red", "Green", "Blue" };
                    foreach (string color in colors)
                    {
                        Console.WriteLine("Color: " + color);
                    }
                    break;

                case "6":
                    // Пример SWITCH
                    Console.WriteLine("Введите номер дня (1-7):");
                    int day = int.Parse(Console.ReadLine());
                    switch (day)
                    {
                        case 1:
                            Console.WriteLine("Пн");
                            break;
                        case 2:
                            Console.WriteLine("Вт");
                            break;
                        case 3:
                            Console.WriteLine("Ср");
                            break;
                        case 4:
                            Console.WriteLine("Чт");
                            break;
                        case 5:
                            Console.WriteLine("Пт");
                            break;
                        case 6:
                            Console.WriteLine("Сб");
                            break;
                        case 7:
                            Console.WriteLine("Вс");
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}