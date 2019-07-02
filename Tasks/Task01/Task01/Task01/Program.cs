using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {        
        static void Main(string[] args)
        {
            CS_Run run = new CS_Run();
            {
                Console.WriteLine("Выберете одну из 12 задач");
                int chooseTask = run.ParseInt();
                switch (chooseTask) {
                    case 1:                      
                run.Task1_1();
                        break;
                    case 2:
                run.Task1_2();
                        break;
                    case 3:
                run.Task1_3();
                        break;
                    case 4:
                run.Task1_4();
                        break;
                    case 5:
                run.Task1_5();
                        break;
                    case 6:
                run.Task1_6();
                        break;
                    case 7:
                run.Task1_7();
                        break;
                    case 8:
                run.Task1_8();
                        break;
                    case 9:
                run.Task1_9();
                        break;
                    case 10:
                run.Task1_10();
                        break;
                    case 11:
                run.Task1_11();
                        break;
                    case 12:
                run.Task1_12();
                        break;
            }
                Console.ReadKey();
            }
                   
        }
    }

    class CS_Basics
    {

        private int Rechtangle(int a, int b) // a & b - стороны прямоугольника
            => a * b;
        
        /// <summary>
        /// Метод принимает с клавиатуры значения сторон прямоугольника и возвращает его площадь.
        /// </summary>
        public void DoRechtangle()
        {
            int a, b; // Стороны прямоугольника
            Console.WriteLine("Введите стороны пямоугольника");

            if(Int32.TryParse(Console.ReadLine(), out a) && Int32.TryParse(Console.ReadLine(), out b))
            {

                if(a > 0 && b > 0)
                {
                    Console.WriteLine("Площадь вашего прямоугольника : " + Rechtangle(a,b));
                }
                else
                {
                    Console.WriteLine("Ошибка: вы ввели неположительные значения сторон прямоугольника");
                }
            }
        }

        private void DrawTriangle(int SizeOfTriangle)
        {
            // Метод выводит треугольник из звёздочек
            String triangle = "*";

            for (int i = 0; i < SizeOfTriangle; i++)
            {
                Console.WriteLine(triangle);
                triangle += "*";
            }
        }

        /// <summary>
        /// Метод принимает с клавиатуры размер основания треугольника
        /// В условных единицах(*), затем выводит на экран псевдографику:
        /// Прямоугольный треугольник
        /// </summary>
        public void DoDrawTriangle()
        {
            int SizeOfTriangle;
            Console.WriteLine("Введите размер треугольника :");

            if(Int32.TryParse(Console.ReadLine(), out SizeOfTriangle))
            {

                if (SizeOfTriangle > 0)
                {
                    DrawTriangle(SizeOfTriangle);
                }
                else
                {
                    Console.WriteLine("Вы ввели неположительное число");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }
        }

        private void DrawAnotherTriangle(int SizeOfTriangle)
        {
            // Треугольник, но другой
            int positionOfFirstStar = SizeOfTriangle;
            String triangle = "*";
            String position;

            for(int i = 0; i < SizeOfTriangle; i++)
            {
                position = "";

                for(int j = 0; j < positionOfFirstStar; j++)
                {
                    position += " ";
                    
                }
                positionOfFirstStar--;

                Console.WriteLine(position + triangle);

                triangle += "**";
            }
        }
        /// <summary>
        /// Метод принимает с клавиатуры размер основания треугольника
        /// В условных единицах(*), затем выводит на экран псевдографику:
        /// Равностороний треугольник
        /// </summary>
        public void DoDrawAnotherTriangle()
        {
            int SizeOfTriangle;
            Console.WriteLine("Введите размер треугольника : ");

            if(Int32.TryParse(Console.ReadLine(), out SizeOfTriangle))
            {

                if(SizeOfTriangle > 0)
                {
                    DrawAnotherTriangle(SizeOfTriangle);
                }
                else
                {
                    Console.WriteLine("Вы ввели неположительное число");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не целочисленное число");
            }
        }

        private void DrawXMasTree(int SizeOfTriangle)
        {
            // Делаем "Ёлочку"
            int positionOfTheFirstStar = SizeOfTriangle;
            int levelOfTriangel = 1;
            String position;
            String triangle = "*";
            for(int i = 0; i < SizeOfTriangle; i++)
            {
                
                for(int j = 0; j < levelOfTriangel ; j++)
                {
                    position = "";
                    for (int k = 0; k < positionOfTheFirstStar; k++)
                    {
                        position += " ";
                    }
                    positionOfTheFirstStar--;
                    Console.WriteLine(position + triangle);
                    triangle += "**";
                }
                levelOfTriangel++;
                positionOfTheFirstStar = SizeOfTriangle;
                triangle = "*";
            }
        }
        /// <summary>
        /// Метод принимает с клавиатуры размер основания треугольника
        /// В условных единицах(*), затем выводит на экран псевдографику:
        /// Дерево треугольников
        /// </summary>
        public void DoDrawXMasTree()
        {
            int SizeOfTriangle;
            Console.WriteLine("Введите размер последнего0 треугольника : ");

            if (Int32.TryParse(Console.ReadLine(), out SizeOfTriangle))
            {

                if (SizeOfTriangle > 0)
                {
                    DrawXMasTree(SizeOfTriangle);
                }
                else
                {
                    Console.WriteLine("Вы ввели неположительное число");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не целочисленное число");
            }
        }
        /// <summary>
        /// Метод высчитывает сумму чисел кратных 3 и 5 меньше 1000
        /// </summary>
        /// <returns></returns>
        public int SumOfNumbers()
        {            
            int sum = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }        
    }

    class CS_Language
    {
        /// <summary>
        /// Сортирует одномерный массив целочисленных элементов
        /// </summary>
        /// <param name="array">массив целочисленных элементов</param>
        public static void ArraySort(int[] array)
        {            
            int varRecombination;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(array[j] > array[i])
                    {
                        varRecombination = array[j]; array[j] = array[i]; array[i] = varRecombination;
                    }
                }
            }        
        }
        /// <summary>
        /// Сортирует одномерный массив чисел с плавующей точкой
        /// </summary>
        /// <param name="array">массив чисел с плавающей точкой</param>
        public static void ArraySort(double[] array)
        {
            double varRecombination;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[i])
                    {
                        varRecombination = array[j]; array[j] = array[i]; array[i] = varRecombination;
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает последний элемент отсортированого по возрастанию массива
        /// </summary>
        /// <param name="array">массив целочисленных элементов</param>
        /// <returns>последний элемент массива</returns>
        public static int MaxElementSortArray(int[] array)
        {            
            return array[array.Length-1];
        }
        /// <summary>
        /// Возвращает последний элемент отсортированого по возрастанию массива
        /// </summary>
        /// <param name="array">массив чисел с плавающей точкой</param>
        /// <returns>последний элемент массива</returns>
        public static double MaxElementSortArray(double[] array)
        {
            // Возвращает максимальное значение отсортированного массива
            return array[array.Length - 1];
        }
        /// <summary>
        /// Возвращает первый элемент отсортированого по возрастанию массива
        /// </summary>
        /// <param name="array">массив целочисленных элементов</param>
        /// <returns>первый элемент массива</returns>
        public static int MinElementSortArray(int[] array)
        {
            return array[0];
        }

        /// <summary>
        /// Возвращает первый элемент отсортированого по возрастанию массива
        /// </summary>
        /// <param name="array">массив чиселс плавающей точкой</param>
        /// <returns>первый элемент массива</returns>
        public static double MinElementSortArray(double[] array)
        {
            return array[0];
        }
        /// <summary>
        /// Возвращает максимальное значение неотсортированого массива
        /// </summary>
        /// <param name="array">Массив целых чисел</param>
        /// <returns>Максимальное значение массива</returns>
        public static int MaxElementArray(int[] array)
        { 
            int maxElement = array[0];
            foreach(int i in array)
            {
                if(maxElement < i)
                {
                    maxElement = i;
                }
            }
            return maxElement;
        }
        /// <summary>
        /// Возвращает максимальное значение неотсортированого массива
        /// </summary>
        /// <param name="array">Массив чисел с плавающей точкой</param>
        /// <returns>Максимальное значение массива</returns>
        public static double MaxElementArray(double[] array)
        {
            double maxElement = array[0];
            foreach (int i in array)
            {
                if (maxElement < i)
                {
                    maxElement = i;
                }
            }
            return maxElement;
        }
        /// <summary>
        /// Возвращает минимальное значение неотсортированого массива
        /// </summary>
        /// <param name="array">Массив целых чисел</param>
        /// <returns>Минимальное значение массива</returns>
        public static int MinElementArray(int[] array)
        {
            int minElement = array[0];
            foreach (int i in array)
            {
                if (minElement > i)
                {
                    minElement = i;
                }
            }
            return minElement;
        }
        /// <summary>
        /// Возвращает минимальное значение неотсортированого массива
        /// </summary>
        /// <param name="array">Массив чисел с плавающей точкой</param>
        /// <returns>Минимальное значение массива</returns>
        public static double MinElementArray(double[] array)
        {
            double minElement = array[0];
            foreach (int i in array)
            {
                if (minElement > i)
                {
                    minElement = i;
                }
            }
            return minElement;
        }
        /// <summary>
        ///  Замняет в трёхмерном массиве все положительные значения на нули
        /// </summary>
        /// <param name="array">Трёхмерный массив целых чисел</param>
        public static void NoPositiveArray(int[,,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for(int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j,k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Замняет в трёхмерном массиве все положительные значения на нули
        /// </summary>
        /// <param name="array">Трёхмерный массив чисел с плавающей точкой</param>
        public static void NoPositiveArray(double[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает сумму неотрицательных элементов массива
        /// </summary>
        /// <param name="array">Массив целых чисел</param>
        /// <returns>Сумма неотрицательных элементов массива</returns>
        public static int SumOfNonNegativeElementArray(int[] array)
        {
            // 
            int sum = 0;
            foreach(int i in array)
            {
                if(i >= 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        /// <summary>
        /// Возвращает сумму неотрицательных элементов массива
        /// </summary>
        /// <param name="array">Массив чисел с плавающей точкой</param>
        /// <returns>Сумма неотрицательных элементов массива</returns>
        public static double SumOfNonNegativeElementArray(double[] array)
        {
            double sum = 0;
            foreach (int i in array)
            {
                if (i >= 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        /// <summary>
        /// Метод возвращает сумму чётных элементов двумерного массива
        /// </summary>
        /// <param name="array">Двумерный массив целых чисел</param>
        /// <returns>Сумма чётных элементов двумерного массива</returns>
        public static int SumOfEvenPosition2DArray(int[,] array)
        {
            // 
            int sum = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {

                        sum += array[i, j];
                    }                                    
                }
            }
            sum -= array[0, 0];
            return sum;
        }
        /// <summary>
        /// Метод возвращает сумму чётных элементов двумерного массива
        /// </summary>
        /// <param name="array">Двумерный массив чисел с плавающей точкой</param>
        /// <returns>Сумма чётных элементов двумерного массива</returns>
        public static double SumOfEvenPosition2DArray(double[,] array)
        {
            // Метод возвращает сумму чётных элементов двумерного массива
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {                    
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }                    
                }
            }
            sum -= array[0, 0];
            return sum;
        }

    }

    class CS_Strings
    {
        /// <summary>
        /// Метод возвращает среднюю длину слова во введёной строке
        /// </summary>
        /// <param name="s">Строка на проверку длины слов</param>
        /// <returns>Средняя длина слова</returns>
        public static int AverageStringLength(String s)
        {
            int StringLength = 0;
            char[] separator = new char[] { '.', ' ', ',', ':', ';', '!', '?', '\'', '\"' };
            String[] SeparateStrings = s.Split(separator);
            String SeparateString = "";
            for(int i = 0; i < SeparateStrings.Length-1; i++)
            {
                if (!SeparateStrings[i].Equals("") || !!SeparateStrings[i].Equals(" "))
                {
                    SeparateString += SeparateStrings[i] + " ";
                }
            }
            SeparateString += SeparateStrings[SeparateStrings.Length - 1];
            var _SeparateStrings = SeparateString.Split();
            foreach (String S in _SeparateStrings)
            {
                StringLength += S.Length;
            }
            return StringLength/_SeparateStrings.Length;
        }
        /// <summary>
        /// Метод возвращает строку с удвоенными символами в строке, введёными пользователем
        /// </summary>
        /// <param name="InputString">Строка введёная пользователем в которой будет удвоение</param>
        /// <param name="StringDoubler">Строка символы которой удваивают символы InputString</param>
        /// <returns>Возвращает строку с выборочно удвоеными символами</returns>
        public static String CharDoubler(String InputString, String StringDoubler)
        {
            var charArrayInputString = InputString.ToCharArray();
            var charArrayDoublerString = StringDoubler.ToCharArray();
            var charListOutputString = new List<char>();
            char[] charArrayOutputString; 
            String OutputString = "";

            foreach(char charInputString in charArrayInputString)
            {
                foreach(char charDoublerString in charArrayDoublerString)
                {
                    if(charInputString == charDoublerString)
                    {
                        charListOutputString.Add(charDoublerString);
                        break;
                    }
                }
                charListOutputString.Add(charInputString);
            }

            charArrayOutputString = new char[charListOutputString.Count];
            charListOutputString.CopyTo(charArrayOutputString);

            foreach (char charOutputString in charArrayOutputString)
            {
                OutputString += charOutputString;
            }

            return OutputString;
        }
    }

    class CS_Font
    {
        private bool statusItalic = false;
        private bool statusBold = false;
        private bool statusUnderLine = false;

        private String status = "";

        public bool GetStatusItalic()
            => statusItalic;

        public bool GetStatusBold()
            => statusBold;

        public bool GetStatusUnderLine()
            => statusUnderLine;

        public String GetStatus()
            => status;


        private bool checkStatusItalic()
        {
            if (statusItalic)
            {                
                return statusItalic = false;
            }
            else
            {             
                return statusItalic = true;
            }
        }

        private bool checkStatusBold()
        {
            if (statusBold)
            {
                return statusBold = false;
            }
            else
            {
                return statusBold = true;
            }
        }

        private bool checkStatusUnderLine()
        {
            if (statusUnderLine)
            {
                return statusUnderLine = false;
            }
            else
            {
                return statusUnderLine = true;
            }
        }
        /// <summary>
        /// Метод возвращает статус стиля текста.
        /// </summary>
        public String checkStatus(int checkStatusVariable)
        {
            changeStatus(checkStatusVariable);
            if(statusItalic && statusBold && statusUnderLine)
            {
                status = "Italic Bold UnderLine";
            }else if(statusItalic && statusBold)
            {
                status = "Italic Bold";
            }else if(statusItalic && statusUnderLine)
            {
                status = "Italic UnderLine";
            }else if(statusBold && statusUnderLine)
            {
                status = "Bold UnderLine";
            }else if (statusItalic)
            {
                status = "Italic";
            }else if (statusBold)
            {
                status = "Bold";
            }else if (statusUnderLine)
            {
                status = "UnderLine";
            }
            else
            {
                status = "";
            }
            return status;
        }

        private void changeStatus(int checkStatusVariable)
        {
            switch (checkStatusVariable)
            {
                case 1:
                    checkStatusItalic();
                    break;
                case 2:
                    checkStatusBold();
                    break;
                case 3:
                    checkStatusUnderLine();
                    break;
                default:
                    Console.WriteLine("К сожалению такой операции не существует");
                    break;
            }
        }


    }

    class CS_Run {

        Random rnd = new Random();
        CS_Basics basics = new CS_Basics();
        CS_Font cs_font = new CS_Font();

        public int[] DoIntArray(int n) // n - размерность массива
        { // Возвращает массив int
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
            return array;
        }

        public double[] DoDoubleArray(int n) // n - размерность массива
        {
            // Возвращает массив double
            double[] array = new double[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 20 - 10;
            }
            return array;
        }

        public int[,,] DoThreeDimensionalArray(int I, int J, int K)
        {
            // метод возвращает трёхмерный массив типа int
            int[,,] array = new int[I, J, K];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = rnd.Next(-10, 10);
                    }
                }
            }
            return array;
        }
        public double[,,] DoThreeDimensionalDoubleArray(int I, int J, int K)
        {
            // метод возвращает трёхмерный массив типа double
            double[,,] array = new double[I, J, K];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = rnd.Next(-10, 10);
                    }
                }
            }
            return array;
        }

        public int[,] DoTwoDimensialIntArray(int I, int J)
        {
            // метод возвращает двумерный массив типа int
            int[,] array = new int[I, J];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }
            return array;
        }

        public void WriteArray(int[] array)
        {
            // Выводит элементы массива на экран
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void WriteArray(double[] array)
        {
            // Выводит элементы массива на экран
            foreach (double d in array)
            {
                Console.WriteLine(d);
            }
        }

        public void WriteArray(int[,] array)
        {
            // Выводит элементы двумерного массива на экран
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("[{0}, {1}]\t{2}", i, j, array[i, j]);
                }
            }
        }

        public void WriteArray(double[,] array)
        {
            // Выводит элементы двумерного массива на экран
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("[{0}, {1}]\t{2}", i, j, array[i, j]);
                }
            }
        }

        public void WriteArray(int[,,] array)
        {
            // Выводит на экран элементы трёхмерного массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine("[{0}, {1}, {2}]\t{3}", i, j, k, array[i, j, k]);
                    }
                }
            }
        }

        public void WriteArray(double[,,] array)
        {
            // Выводит на экран элементы трёхмерного массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine("[{0}, {1}, {2}]\t{3}", i, j, k, array[i, j, k]);
                    }
                }
            }
        }

        public int ParseInt()
        {
            int i;
            Int32.TryParse(Console.ReadLine(), out i);
            return i;
        }

        public double ParseDouble()
        {
            double i;
            Double.TryParse(Console.ReadLine(), out i);
            return i;
        }

        private void WriteSeparate()
        {
            Console.WriteLine("*_*-*_*-*_*-*_*-*_*-*_*-*_*-*_*");
        }

        public void Task1_1() {
            WriteSeparate();
            Console.WriteLine("Задание 1.1 :");
            basics.DoRechtangle();
            WriteSeparate();
        }

        public void Task1_2()
        {
            WriteSeparate();
            Console.WriteLine("Задание 1.2 :");
            basics.DoDrawTriangle();
            WriteSeparate();
        }

        public void Task1_3()
        {
            WriteSeparate();
            Console.WriteLine("Задание 1.3 :");
            basics.DoDrawAnotherTriangle();
            WriteSeparate();
        }

        public void Task1_4()
        {
            Console.WriteLine("Задание 1.4 :");
            WriteSeparate();
            basics.DoDrawXMasTree();
            WriteSeparate();
        }

        public void Task1_5()
        {
            Console.WriteLine("Задание 1.5 :");
            WriteSeparate();
            Console.WriteLine("Сумма чисел кратных 3 и 5 до 1000 :{0}",basics.SumOfNumbers());
            WriteSeparate();
        }

        public void Task1_6()
        {
            Console.WriteLine("Задание 1.6 :");

            WriteSeparate();

            int checkStatus;
            while (true)
            {
                Console.WriteLine("Текущий статус :\t{0}",cs_font.GetStatus());
                checkStatus = ParseInt();
                if (checkStatus == 0) { break; }
                cs_font.checkStatus(checkStatus);
            }

            WriteSeparate();
        }

        public void Task1_7()
        {

            Console.WriteLine("Задание 1.7 :");

            WriteSeparate();

            Console.WriteLine("Введите размер массива");
            int n = ParseInt();
            var array = DoIntArray(n);
            WriteArray(array);

            Console.WriteLine("Минимальный элемент массива\t{0}", CS_Language.MinElementArray(array));
            Console.WriteLine("Максимальный элемент массива\t{0}", CS_Language.MaxElementArray(array));
            CS_Language.ArraySort(array);
            Console.WriteLine("Отсортированный массив : ");
            WriteArray(array);

            WriteSeparate();
        }

        public void Task1_8()
        {
            Console.WriteLine("Задание 1.8 :");

            WriteSeparate();

            Console.WriteLine("Введите размеры массива");
            int i = ParseInt();
            int j = ParseInt();
            int k = ParseInt();
            var threeDimensialArray = DoThreeDimensionalArray(i, j, k);
            Console.WriteLine("Было :");
            WriteArray(threeDimensialArray);
            CS_Language.NoPositiveArray(threeDimensialArray);
            Console.WriteLine("Стало :");
            WriteArray(threeDimensialArray);
            WriteSeparate();
        }

        public void Task1_9()
        {
            WriteSeparate();

            Console.WriteLine("Задание 1.9 :");

            Console.WriteLine("Введите размер массива");
            int N = ParseInt();
            var array = DoIntArray(N);
            WriteArray(array);

            Console.WriteLine("Сумма неотрицательных элементов массива\t{0}"
                ,CS_Language.SumOfNonNegativeElementArray(array));

            WriteSeparate();
        }

        public void Task1_10()
        {
            WriteSeparate();

            Console.WriteLine("Задание 1.10 :");
            Console.WriteLine("Введите размер массива");
            int I = ParseInt();
            int J = ParseInt();
            var array = DoTwoDimensialIntArray(I, J);
            WriteArray(array);

            Console.WriteLine("Сумма элементов на чётных позициях\t{0}"
                ,CS_Language.SumOfEvenPosition2DArray(array));

            WriteSeparate();
        }

        public void Task1_11()
        {
            WriteSeparate();

            Console.WriteLine("Задание 1.11 :");
            Console.WriteLine("Введите строку");
            var StringAvarageLength = CS_Strings.AverageStringLength(Console.ReadLine());
            Console.WriteLine("Средняя длина слова\t{0}",StringAvarageLength);

            WriteSeparate();
        }

        public void Task1_12()
        {
            WriteSeparate();
            Console.WriteLine("Задание 1.12 :");

            Console.WriteLine("Введите строку");
            String InputString = Console.ReadLine();
            Console.WriteLine("Введите строку");
            String DoublerString = Console.ReadLine();
            var StringOutput = CS_Strings.CharDoubler(InputString, DoublerString);
            Console.WriteLine(StringOutput);

            WriteSeparate();

        }
    }

}

