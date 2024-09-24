using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Fibonacci()
        {
            Console.WriteLine();
            //Выводит первые 10 чисел Фиббоначи
            var first = 0;
            var second = 1;
            Console.Write("первые 10 чисел Фиббоначи: 0, 1");
            for (int i = 0; i < 8; i++)
            {
                var result = first + second;
                Console.Write(", " + result);
                first = second;
                second = result;
            }
        }
        static void EvenNumbers()
        {
            Console.WriteLine();
            //Используя цикл for, выведите все чётные числа от 2 до 20
            Console.Write("Чётные числа от 2 до 20: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i*2 + " ");
            }
        }
        static void MultiplicationTable()
        {
            //С помощью вложенных циклов for выведите таблицу умножения от 1 до 5. Каждая строка таблицы должна быть выведена в отдельной строке.
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
                Console.WriteLine("--------");
            }
        }
        static void CheckPassword()
        {
            /*
             * Дана строка string password = “qwerty”;
             * Напишите программу для ввода пароля, которая считывает пользовательский ввод Console.ReadLine.
             * Подсказка: используйте do-while
             */
            string pass;
            Console.WriteLine("Введите пароль!");
            pass = Console.ReadLine();
            if (!String.Equals(pass, "qwerty"))
            {
                do
                {
                    Console.WriteLine("Неверный пароль, введите пароль еще раз!");
                    pass = Console.ReadLine();
                } while (!String.Equals(pass, "qwerty"));
            }
            Console.WriteLine("МЕГАТРОН АКТИВИРОВАН!");
        }
        
        public static void Main(string[] args)
        {
            Fibonacci();
            EvenNumbers();
            MultiplicationTable();
            CheckPassword();
        }
    }
}