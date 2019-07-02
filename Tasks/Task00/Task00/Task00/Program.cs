using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    class Program
    {
        static void Main(string[] args)
        {
            Task0 task = new Task0();
            Console.WriteLine("Задание 1 :");
            task.DoSequence();
            Console.WriteLine("Задание 2 :");
            task.DoSimpleNumber();
            Console.WriteLine("Задание 3 :");
            task.DoDrawSquare();

            Console.ReadKey();
        }       
    }

    class Task0
    {
        private String Sequence(int n) //  n - кол-во элементов последовательности
        {
            // Функция  возвращает строку вида 1, 2, 3, ... n
            String sequence = "";
            for (int i = 1; i < n; i++)
            {
                sequence += i + ", ";
            }
            sequence += n;
            return sequence;
        }

        private bool SimpleNumber(int n) // n - число проходящее проверку
        {
            // Функция проверяет является ли n простым числом
            List<int> listOfSimpleNumber = new List<int>();
            bool checkOfSimpleNumber = true;
            listOfSimpleNumber.Add(2);
            for (int i = 3; i <= n; i++)
            {
                checkOfSimpleNumber = true;
                foreach (int j in listOfSimpleNumber)
                {
                    if (i % j == 0)
                    {
                        checkOfSimpleNumber = false;
                    }
                }
                if (checkOfSimpleNumber)
                {
                    listOfSimpleNumber.Add(i);
                }
            }
            return checkOfSimpleNumber;
        }

        private void DrawSquare(int n) // n - сторона квадрата
        {
            // рисует квадрат из звёздочек со стороной n, 
            // центральная звёздочка должна отсутствовать
            if (n % 2 != 0)
            {
                String sideOfSquare = "";
                String centralSideOfSquare = "";
                while (sideOfSquare.Length < n)
                {
                    sideOfSquare += "*";
                    if (centralSideOfSquare.Length == (int)n / 2)
                    {
                        centralSideOfSquare += " ";
                    }
                    else
                    {
                        centralSideOfSquare += "*";
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (i != (int)n / 2)
                    {
                        Console.WriteLine(sideOfSquare);
                    }
                    else
                    {
                        Console.WriteLine(centralSideOfSquare);
                    }
                }
            }
            else if (n <= 0)
            {
                Console.WriteLine("Вы ввели неположительное число");
            }
            else
            {
                Console.WriteLine("Вы ввели чётное число");
            }
        }

        public void DoSequence()
        {
            int sizeOfSequence = 0;
            Console.WriteLine("Введите размер последовательности");
            if (Int32.TryParse(Console.ReadLine(), out sizeOfSequence))
            {
                if (sizeOfSequence > 0)
                {
                    Console.WriteLine(Sequence(sizeOfSequence));
                }
                else
                {
                    Console.WriteLine("Число не положительно");
                }
            }
            else
            {
                Console.WriteLine("Введено не число");
            }
        }

        public void DoDrawSquare()
        {
            int sizeOfSideSquare = 0;
            Console.WriteLine("Введите размер стороны квадрата из *");
            if (Int32.TryParse(Console.ReadLine(), out sizeOfSideSquare))
            {
                if(sizeOfSideSquare > 0)
                {
                    DrawSquare(sizeOfSideSquare);
                }
                else
                {
                    Console.WriteLine("Число не положительно");
                }
            }
            else
            {
                Console.WriteLine("Введено не число");
            }
        }

        public void DoSimpleNumber()
        {
            int number = 0;
            Console.WriteLine("Введите число");
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                if(number > 2)
                {
                    Console.WriteLine(SimpleNumber(number));
                }
                else if (number == 2)
                {
                    Console.WriteLine("true");
                }
            }
        }
    }

}
