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

            NumberRequest();

            #endregion

            
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

        static int Getting_number()
        {
            while (true)
            {
                Center_window($"Введите число: ");

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

    }
}
