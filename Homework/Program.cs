using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        #region Task01

        /// <summary>
        /// Метод выводит массив n,m в консоль
        /// </summary>
        /// <param name="array"></param>
        static void MatrixOutput(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j], 2} ");
                }

                Console.WriteLine("|");
            }
        }

        /// <summary>
        /// Метод заполняет матрицу случайными числами
        /// </summary>
        /// <param name="n">Количество строк</param>
        /// <param name="m">Количество столбцов</param>
        /// <returns></returns>
        static int[,] GenerationMatrix(Random rand, int n, int m)
        {
            int[,] result = new int[n, m];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = rand.Next(9);
                }
            }

            return result;
        }

        /// <summary>
        /// Метод описывает работу пользователя по созданию матрицы
        /// </summary>
        /// <returns></returns>
        static int[,] UserInputMatrix(Random rand)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество колонок: ");
            int m = int.Parse(Console.ReadLine());

            return GenerationMatrix(rand, n, m);
        }

        /// <summary>
        /// Метод умножает матрицу на число
        /// </summary>
        /// <param name="array">Матрица</param>
        /// <param name="number">Число</param>
        /// <returns></returns>
        static int[,] MatrixMultiplicationByNumber(int[,] array, int number)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[i, j] = array[i, j] * number;
                }
            }

            return result;
        }
        
        /// <summary>
        /// Метод перемножает 2 матрицы
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        static int[,] MatrixMultiplication(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

            if (array1.GetLength(1) != array2.GetLength(0))
            {
                Console.WriteLine($"\nКоличество колонок в матрице 1 (array1.GetLength(1)) не равно количеству строк в матрице 2 (array2.GetLength(0)).\nУмножение невозможно!");
            }
            else
            {

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {

                        //matrixRes[i, j] = 0;
                        for (int k = 0; k < array1.GetLength(1); k++)
                        {
                            result[i, j] = result[i, j] + array1[i, k] * array2[k, j];

                        }
                    }

                }
            }
            
            return result;
        }

        /// <summary>
        /// Метод складывает 2 матрицы
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        static int[,] MatrixAddition(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    result[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Метод Вычитает из первой матрицы вторую
        /// </summary>
        /// <param name="array1">Первая матрица</param>
        /// <param name="array2">Вторая матрица</param>
        /// <returns></returns>
        static int[,] MatrixSubtraction(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    result[i, j] = array1[i, j] - array2[i, j];
                }
            }

            return result;
        }
        
        /// <summary>
        /// Метод описывает Задачи 1
        /// </summary>
        static void Task01()
        {
            Console.Clear();
            Console.WriteLine("Действия с матрицами из модуля 4");
            Console.WriteLine("1 - Умножение матрицы на число");
            Console.WriteLine("2 - Сложение и вычитание матриц");
            Console.WriteLine("3 - Умножение матриц");
            Console.WriteLine("Другой - Выйти");
            char tmp = Console.ReadKey().KeyChar;

            switch (tmp)
            {
                case '1': Task011(); break;
                case '2': Task012(); break;
                case '3': Task013(); break;
                default: break;
            }

        }

        /// <summary>
        /// Метод описывает задание 1.1
        /// </summary>
        static void Task011()
        {
            Console.Clear();
            Console.WriteLine("Умножение матрицы на число");
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество колонок: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите число на которое необходимо умножить матрицу: ");
            int number = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[,] matrix = GenerationMatrix(rand, n, m);

            Console.WriteLine("Сгенерированая матрица:");
            MatrixOutput(matrix);

            int[,] matrixRes = MatrixMultiplicationByNumber(matrix, number);

            Console.WriteLine($"Матрица умноженная на число {number}");
            MatrixOutput(matrixRes);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод описывает задание 1.2
        /// </summary>
        static void Task012()
        {
            Console.Clear();
            Console.WriteLine("Сложение(вычитание) матриц");
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество колонок: ");
            int m = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[,] matrix1 = GenerationMatrix(rand, n, m);

            Console.WriteLine("Сгенерированая матрица 1:");
            MatrixOutput(matrix1);

            int[,] matrix2 = GenerationMatrix(rand, n, m); 

            Console.WriteLine("Сгенерированая матрица 2:");
            MatrixOutput(matrix2);

            Console.WriteLine("\nСложение матриц:");
            MatrixOutput(MatrixAddition(matrix1, matrix2));

            Console.WriteLine("\nВычитание матриц:");
            MatrixOutput(MatrixSubtraction(matrix1, matrix2));

            Console.ReadKey();
        }

        /// <summary>
        /// Метод описывает задание 1.3
        /// </summary>
        static void Task013()
        {
            Console.Clear();
            Console.WriteLine("Умножение матрицы на число\n");

            Random rand = new Random();
            Console.WriteLine("Матрица 1: ");
            int[,] matrix1 = UserInputMatrix(rand);
            Console.WriteLine("Сгенерированая матрица:");
            MatrixOutput(matrix1);

            Console.WriteLine("Матрица 2: ");
            int[,] matrix2 = UserInputMatrix(rand);
            Console.WriteLine("Сгенерированая матрица:");
            MatrixOutput(matrix2);

            int[,] matrixRes = MatrixMultiplication(matrix1, matrix2);
            Console.WriteLine("\nУмножение матриц:");
            MatrixOutput(matrixRes);

            Console.ReadKey();
        }

        #endregion

        #region Task02

        /// <summary>
        /// Возвращает первое слово с минимальной длиной из строки разделенной символами ' ', '.', ','
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string MinWord(string str)
        {
            string result = "";
            string[] words = str.Split(' ', '.', ',');

            foreach(string word in words)
            {
                result = (result.Length > word.Length || result == "") ? word : result;
            }
            return result;
        }

        /// <summary>
        /// Возвращает все слова с максимальной длиной из строки разделенной символами ' ', '.', ','
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string MaxWords(string str)
        {
            string result = "";
            int MaxLenght = 0;
            string[] words = str.Split(' ', '.', ',');

            foreach (string word in words)
            {
                MaxLenght = (MaxLenght < word.Length) ? word.Length : MaxLenght;
            }

            foreach (string word in words)
            {
                if (MaxLenght == word.Length) result += word + " ";
            }

            return result;
        }

        /// <summary>
        /// Метод описывает работу с пользователем в задаче 2
        /// </summary>
        static void Task02()
        {
            Console.Clear();
            Console.WriteLine("Работа со словами: ");
            Console.WriteLine("Введите предложение: ");

            string str = Console.ReadLine();

            Console.WriteLine("Слово минимальной длины: " + MinWord(str));
            Console.WriteLine("Слово(слова) максимальной длины: " + MaxWords(str));

            Console.ReadKey();
        }

        #endregion

        #region Task03
        /// <summary>
        /// Метод объединяет одинаковые символы, которые идут подряд
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string ReductionString(string str)
        {
            char tmp = str[0];              // временный символ
            string result = tmp.ToString(); // первый символ
            
            for(int i=1; i < str.Length; i++) 
            {
                if (str[i] != tmp) //Добавляем новый символ, если он не равен предыдущему
                {
                    tmp = str[i];
                    result += tmp.ToString();
                }
            }
            return result;
        }

        /// <summary>
        /// Метод описывает работу с пользователем в задаче 3
        /// </summary>
        static void Task03()
        {
            Console.Clear();
            Console.WriteLine("Удаление кратных символов: ");
            Console.WriteLine("Введите предложение: ");

            string str = Console.ReadLine();
            Console.WriteLine("Предложение: " + ReductionString(str));

            Console.ReadKey();

        }

        #endregion

        #region Task04

        /// <summary>
        /// Проверка массива на арифметическую прогрессию
        /// true  - арифметическая
        /// false - не арифметическая
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static bool isArithmeticProgression(int[] array)
        {
            for(int i = 1; i < array.Length - 1; i++)
            {
                if(array[i] - array[i-1] != array[i+1] - array[i])
                {
                    return false;
                }
            }
            return true;    
        }

        /// <summary>
        /// Проверка массива на геометрическую прогрессию
        /// true  - геометрическая 
        /// false - не геометрическая 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static bool isGeometricProgression(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((double)array[i] / array[i - 1] != (double)array[i + 1] / array[i])  
                {
                    return false;
                }
            }
            return true;
        }

        static void Task04()
        {
            Console.Clear();
            Console.WriteLine("Проверка последовательности на прогрессию");

            //Заполнение данных пользователем
            Console.WriteLine("Введите количество чисел в последовательности: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Введите число {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Проверка прогрессии
            if (isArithmeticProgression(array)) Console.WriteLine("Последовательность является арифметической");
            else if (isGeometricProgression(array)) Console.WriteLine("Последовательность является геометрической");
            else Console.WriteLine("Последовательность не является ни арифметической ни геометрической");

            Console.ReadKey();
        }

        #endregion

        #region Task05
        
        /// <summary>
        /// Метод вычисляет значение по функции Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static uint AckermannFucntion(uint n, uint m)
        {
            if (n == 0) return m + 1;
            else
            {
                if (n != 0 && m == 0) return AckermannFucntion(n - 1, 1);
                else return AckermannFucntion(n - 1, AckermannFucntion(n, m - 1));
            }
        }

        /// <summary>
        /// Метод описывает работу с пользователем в задаче 5
        /// </summary>
        static void Task05()
        {
            Console.Clear();
            Console.WriteLine("Функция Аккермана\n");
            
            Console.WriteLine($"A(2,5) = {AckermannFucntion(2, 5)}");
            Console.WriteLine($"A(1,2) = {AckermannFucntion(1, 2)}");

            Console.ReadKey();
        }

        #endregion 

        static void Main(string[] args)
        {
            #region Information
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован

            #endregion

            Console.WriteLine("Приветствуем в дополнительном задании по 5 уроку!");
            Console.WriteLine("1 - Задание 1 (Действия с матрицами из модуля 4)");
            Console.WriteLine("2 - Задание 2 (Слова с мин/макс количеством букв)");
            Console.WriteLine("3 - Задание 3 (Сокращение строк: ПППОООГГГООООДДДААА >>> ПОГОДА)");
            Console.WriteLine("4 - Задание 4 (Арифметическая/Геометрическая прогрессии");
            Console.WriteLine("5 - Задание 5 (Функция Аккермана)");
            Console.WriteLine("Другой - Выйти");

            char tmp = Console.ReadKey().KeyChar;

            switch (tmp)
            {
                case '1': Task01(); break;
                case '2': Task02(); break;
                case '3': Task03(); break;
                case '4': Task04(); break;
                case '5': Task05(); break;
                default: break;
            }

            
        }
    }
}
