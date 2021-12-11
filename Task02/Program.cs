using System;

namespace Task02
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
        /// Метод инвертирует входящую строку
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string ReverseString(String str)
        {
            string resultStr = "";
            string[] words = StringSplit(str, ' ');

            for(int i = words.Length - 1; i >= 0; i--)
            {
                resultStr += words[i] + " ";
            }
            return resultStr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();

            Console.WriteLine("\nИнвертированая строка: ");
            Console.WriteLine(ReverseString(str));

            Console.ReadKey();
        }
    }
}
