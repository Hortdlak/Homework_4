using System;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Выход через ‘q’ или четную сумму

            //Напишите программу, которая бесконечно запрашивает целые числа с консоли.
            //Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

            //NumberRequest();

            #endregion

            #region Колличество чётных чисел в массиве

            //Задайте массив заполненный случайными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.

            Finding_Even_Numbers();

            #endregion

            Console.ReadKey();

        }

        private static void Finding_Even_Numbers()
        {
            Greetings("Привет. Давай найдем количество четных чисел, среди трехзначных");

            Center_window("Задайте размер массива");

            Console.Clear();

            int evenCount = 0;

            int size_array = Getting_number("количество трехзначных чисел");

            int[] array = new int[size_array];

            Random random = new Random();

            for (int i = 0; i < size_array; i++) 
            {
                array[i] = random.Next(100,1000);
            }

            for (int i = 0; i < size_array; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();

            Console.Clear();

            for (int i = 0;i < size_array; i++)
            {
                if (array[i] %2 == 0)
                {
                    evenCount++;
                }
            }

            Center_window($"Количество четных чисел равно: {evenCount}");

            Console.WriteLine();
        }

        private static void NumberRequest()
        {
            while (true)
            {
                Center_window($"Введите число или введите 'q' для выхода: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (UserInput == "p") break;

                else if (int.TryParse(UserInput, out int data)) // проверка числа
                {
                    int sum_of_numbers = 0;
                    while (data > 0)
                    {
                        sum_of_numbers += data % 10;
                        data /= 10;
                    }

                    if (sum_of_numbers % 2 == 0) break; 

                    Center_window ($"{sum_of_numbers}");

                    Console.ReadKey();
                }
                
            }
        }
        
        static int Getting_number(string pattern)
        {
            while (true)
            {
                Center_window($"Введите {pattern}: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (int.TryParse(UserInput, out int data)) // проверка числа
                {
                    return data; // выход числа из метода
                }
            }
        }

        static void Center_window(string pattern)
        {
            int center_x = (Console.WindowWidth / 2) - (pattern.Length / 2);//установка расположения по ширине

            int center_y = (Console.WindowHeight / 2 - 1);// установка расположения по высоте

            Console.SetCursorPosition(center_x, center_y);//установка курсора

            Console.Write(pattern);
        }
        private static void Greetings(string pattern)
        {
            Center_window(pattern);

            Console.ReadKey();

            Console.Clear();
        }

    }
}
