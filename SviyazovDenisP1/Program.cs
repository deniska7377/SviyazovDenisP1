using System;
using System.Collections.Generic;
using System.Linq;

namespace SviyazovDenisP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нужную команду:");
            Console.WriteLine("Введите help для просмотра списка команд:");
            bool exitRequested = false;

            while (!exitRequested)
            {

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "help":
                        Console.WriteLine("Задание №1 = quest1");
                        Console.WriteLine("Задание №2 = quest2");
                        Console.WriteLine("Задание №3 = quest3");
                        Console.WriteLine("Задание №4 = quest4");
                        break;

                    case "quest1":
                        Console.WriteLine("Вы выбрали задание 1.");
                        Quest1();
                        break;

                    case "quest2":
                        Console.WriteLine("Вы выбрали задание 2.");
                        Quest2();
                        break;
                    case "quest3":
                        Console.WriteLine("Вы выбрали задание 3.");
                        Quest3();
                        break;
                    case "quest4":
                        Console.WriteLine("Вы выбрали задание 4.");
                        Quest4();
                        break;

                    case "exit":
                        exitRequested = true;
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
                Console.WriteLine("Введите команду:");
                Console.WriteLine("help для просмотра команд:");
            }

            static void Quest1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);
                }
            }

            static void Quest2()
            {
                int[] a = { 1, 4, 6 };
                int[] b = { 11, 33, 22 };

                List<int> sortedList = a.OrderBy(x => b.Contains(x) ? Array.IndexOf(b, x) : int.MaxValue).ToList();

                foreach (int num in sortedList)
                {
                    Console.WriteLine(num);
                }
            }

            static void Quest3()
            {
                List<string> strings = new List<string> { "bella", "label", "roller" };

                List<char> commonLetters = new List<char>();
                foreach (char letter in strings.First())
                {
                    bool isCommon = true;
                    foreach (string str in strings.Skip(1))
                    {
                        if (!str.Contains(letter))
                        {
                            isCommon = false;
                            break;
                        }
                    }
                    if (isCommon && !commonLetters.Contains(letter))
                    {
                        commonLetters.Add(letter);
                        Console.WriteLine(letter);
                    }
                }

            }

            static void Quest4()
            {
                string RimNumeral = "XXVII";

                Dictionary<char, int> RimValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

                int result = 0;
                int previousValue = 0;

                for (int i = RimNumeral.Length - 1; i >= 0; i--)
                {
                    int currentValue = RimValues[RimNumeral[i]];

                    if (currentValue >= previousValue)
                        result += currentValue;
                    else
                        result -= currentValue;

                    previousValue = currentValue;
                }

                Console.WriteLine(result);
            }
        }
    }
}
