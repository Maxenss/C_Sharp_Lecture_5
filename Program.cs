using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Многомерные массивы в C#. 
            // Прямоугольные и зубчатые массивы.
            // Обработка многомерных массивов.
            // Сортировка многомерных массивов. 
            // Локальная область видимости переменных.

            // Lecture_3_Task_4_Example();
            // Lecture_3_Task_5_Example();
            // Lecture();
            // Example1();

            // Задержка времени выполнения (Delay)
            Console.ReadKey();
        }
        static void Lecture_3_Task_4_Example()
        {
            Console.WriteLine("Лекция 3, задание 4");

            // Значение функции
            double z = 0;
            // Значение аргумента функции
            double x = 0;
            // Переменная, в которой хранится значение факториала
            double factorial = 1;
            // Сумма 
            double sum = 0;
            // Предел, для второй суммы
            double n = 0;
            // Объект, для генерации случайных чисел
            Random random = new Random();

            Console.Write("Введите значение переменной n : ");
            n = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    // Генерирует случайное целое число, в диапазоне
                    // (0,10]. От 0, включая 0, до 10, исключая 10
                    x = random.Next(10);

                    // Считаем значение функции 
                    z = Math.Pow(x, k) / Factorial(k);

                    // Выводим значение функции z
                    Console.WriteLine("i = {0}, k = {1}," +
                     "x = {2}, z = {3}", i, k, x, z);

                    sum += z;
                }
            }

            Console.WriteLine("Конечная сумма : {0}", sum);
        }

        static void Lecture_3_Task_5_Example()
        {
            Console.WriteLine("Лекция 3, задание 5");

            // Значение функции
            double z = 0;
            // Значение аргумента функции
            double x = 0;
            // Переменная, в которой хранится значение факториала
            double factorial = 1;
            // Сумма для 15 значений аргумента
            double sum = 0;

            #region Сноска про факториал
            // !3 = 1*2*3;

            //int fact = 1;
            //for (int i = 1; i <=3; i++)
            //{
            //    fact *= i;
            //}
            #endregion

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Итерация {0}. Введите значение переменной x : ", i);

                x = Convert.ToDouble(Console.ReadLine());

                // "Обнуляем значение факториала"
                factorial = 1;

                // Цикл, который будет считать значение факториала
                for (int j = 1; j <= i; j++)
                {
                    // Считаем факториал
                    factorial *= j;
                }

                // Считаем значение функции
                z = (i + x) / factorial;

                // Выводим на экран результат
                Console.WriteLine("x = {0}, z = {1}", x, z);

                // Конечная сумма
                sum += z;
            }

            // Выводим сумму
            Console.WriteLine("Конечная сумма для 15 разных значений аргумента равна {0}", sum);

        }

        static void Lecture()
        {
            #region Многомерные массивы
            // Многомерные массивы - это массивы, количество измерений
            // которого, больше одного.
            // Нюанс
            // Все многомерные массивы, хранятся в памяти,
            // как одномерные, т.е. последовательно.

            // Двумерный массив - состоит из двух измерений. 
            // И, фактически, представляет собой таблицу, 
            // где элементы массива расположены по строкам и столбцам.

            // Трехмерный массив - состоит из трех измерений.
            // И, представляет собой, книгу Excel.
            // Где : 
            // Первое измерение(первый индекс) - номер таблицы.
            // Второе измерение(второй индекс) - строка в таблице.
            // Третье измерение(третий индекс) - столбец в таблице.
            #endregion

            #region Двумерные массивы
            // Пример объявления и инициализация массива 3x5.
            // Строк - 3
            // Столбцов - 5
            // В массиве хранится 15 элементов типа int
            int[,] Matrix = new int[3, 5];

            // Обращение к элементу массива
            Matrix[0, 0] = 1;
            Matrix[0, 1] = 2;

            // Вывод на экран элемента массива (чтение)
            Console.WriteLine(Matrix[0, 0]);
            Console.WriteLine(Matrix[0, 1]);

            // Переменная Length массива,
            // хранит полное количество элементов массива
            // Matrix.GetLenght(0) - получить количество строк.
            // Matrix.GetLenght(1) - получить количество столбцов.
            // В цикле присваиваем элементам массива значения
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = i + j;
                }
            }

            // Вывод на экран двумерного массива
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    // \t - табуляция
                    Console.Write("{0}\t", Matrix[i, j]);
                }
                // Перенос строки
                Console.WriteLine();
            }

            #endregion

        }

        // Таблица умножения
        static void Example1()
        {
            Console.WriteLine("Таблица умножения");
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }

        }

        // Функция, которая считает факториал
        static double Factorial(double num)
        {
            double factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= num;
            }

            return factorial;
        }
    }
}
