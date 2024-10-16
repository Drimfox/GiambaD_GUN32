using System;
using System.Text;

namespace HomeWork7
{
    internal class Program
    {
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }
        public static string GreetUser(string userName, int age)
        {
            return $"Hello, {userName}.\nYou are {age} years old.";
        }
        public static string SymbolCountUpperLower(string str)
        {
            return str.Length + "; " + str.ToUpper() + "; " + str.ToLower();
        }
        
        public static string FirstFiveLetterNumber(string str)
        {
            return str.Substring(0, 5);
        }
        public static StringBuilder ConcatenateStringsInArray(string[] strs)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var str in strs)
            {
                stringBuilder.Append(str).Append(" ");
            }
            return stringBuilder;
        }
        
        public static string ReplaceWord(string input, string wordToFind, string wordToReplace)
        {
            return input.Replace(wordToFind, wordToReplace);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Выберете номер задания для проверки от 1 до 6. Для выхода нажмите любую другую цифру.");
            int taskNumber = int.Parse(Console.ReadLine());
            string userName = "Nagibator2000";
            int age = 30;
            string str1 = "Hello";
            string str2 = "World";
            string[] strArray = {"Строка 1", "Строка 2", "Строка 3", "Строка 4"};
            do
            {
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("First string: " + str1 + ", Second string: " + str2);
                        Console.WriteLine( "Result: " + ConcatenateStrings(str1, str2));
                        break;
                    case 2:
                        Console.WriteLine("User's name: " + userName + ", age: " + age);
                        Console.WriteLine( "Result: " + GreetUser(userName, age));
                        break;
                    case 3:
                        Console.WriteLine( "Result: " + SymbolCountUpperLower(ConcatenateStrings(str1, str2)));
                        break;
                    case 4:
                        Console.WriteLine( "Result: " + FirstFiveLetterNumber(ConcatenateStrings(str1, str2)));
                        break;
                    case 5:
                        Console.WriteLine( "Result: " + ConcatenateStringsInArray(strArray));
                        break;
                    case 6:
                        Console.WriteLine( "Result: " + ReplaceWord(ConcatenateStrings(str1, str2), str1, str2));
                        break;
                    default:
                        break;
                }
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Выберете номер задания для проверки от 1 до 6. Для выхода нажмите любую другую цифру.");
                taskNumber = int.Parse(Console.ReadLine());
            } while (taskNumber <= 6 && taskNumber >= 1);
        }
    }

  
}