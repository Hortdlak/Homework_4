using System;
using System.Runtime.InteropServices;

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

            //Finding_Even_Numbers();

            #endregion

            #region Реверс одномерного массива

            //Напишите программу, которая перевернёт одномерный массив
            //(первый элемент станет последним, второй – предпоследним и т.д.)

            Revers_array();

            #endregion

        }

        private static void Revers_array()
        {
            Greetings("Привет. Давай перевернем одномерный массив");

            int[] array = Fill_array(0, 10);

            Read_array(array);

            int[] revers_array = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                revers_array[array.Length - i - 1] = array[i];
            }

            Read_array(revers_array);

        }

        private static void Finding_Even_Numbers()
        {
            Greetings("Привет. Давай найдем количество четных чисел, среди трехзначных");

            Center_window("Задайте размер массива");

            Console.Clear();

            int evenCount = 0;

            int[] array = Fill_array("трехзначных", 100,1000);

            Read_array(array);

            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] %2 == 0)
                {
                    evenCount++;
                }
            }

            Center_window($"Количество четных чисел: {evenCount}");

            Console.WriteLine();
        }

        private static void Read_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();

            Console.Clear();

        }

        private static int[] Fill_array(string pattern,int head, int tail)
        {
            int size_array = Getting_size_array(pattern);

            int[] array = new int[size_array];

            Random random = new Random();

            for (int i = 0; i < size_array; i++)
            {
                array[i] = random.Next(head, tail);
            }

            return array;
        }

        private static int[] Fill_array( int head, int tail)
        {

            int[] array = new int[Getting_size_array("")];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(head, tail);
            }

            return array;
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
        
        static int Getting_size_array(string pattern)
        {
            while (true)
            {
                Center_window($"Введите количество {pattern} чисел: ");

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
