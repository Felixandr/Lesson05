using System;

namespace Task01
{
    class Program
    {
        /// <summary>
        /// Метод возвращает массив слов из строки
        /// </summary>
        /// <param name="str">Строка предложение</param>
        /// <param name="symbol">Символ разбития</param>
        /// <returns></returns>
        static string[] StringSplit(string str, char symbol)
        {
            return str.Split(symbol);
        }
        
        /// <summary>
        /// Метод выводит все слова построчно
        /// </summary>
        /// <param name="words">Массив слов</param> 
        static void WordsOutput(string[] words)
        {
            foreach(string str in words)
            {
                Console.WriteLine(str);
            }
        }

        static void Main(string[] args)
        {

            // Пользователь вводит в консольном приложении длинное предложение.Каждое слово в этом предложении отделено одним пробелом. 
            // Необходимо создать метод, который в качестве входного параметра принимает строковую переменную, а в качестве возвращаемого 
            // значения — массив слов. После вызова данного метода программа вызывает второй метод, который выводит каждое слово в отдельной строке.

            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();

            string[] words = StringSplit(str, ' ');

            Console.WriteLine("\nРезультат: ");
            WordsOutput(words);

            Console.ReadKey();
        }
    }
}
