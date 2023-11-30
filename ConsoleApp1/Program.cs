//using System.ComponentModel.DataAnnotations;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Часть 1:");
            Console.Write("Введите размер массива: ");

            int size = int.Parse(Console.ReadLine());

            var firstPart = new FirstPart(size);

            Console.WriteLine("Исходный массив: ");
            PrintVector(firstPart.Vector);

            Console.WriteLine();

            Console.WriteLine("Минимальный элемент массива: " + firstPart.GetMinimumElement());
            Console.WriteLine("Сумма между положительными: " + firstPart.GetSumBetweenPositiveElements());

            Console.WriteLine();

            firstPart.SortByZeros();
            Console.WriteLine("После сортировки:");
            PrintVector(firstPart.Vector);


            Console.WriteLine();



            Console.WriteLine("Часть 2:");
            Console.Write("Введите кол-во строк: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();

            var secondPart = new SecondPart(x, y); //создание массива и заполнение рандомом
            Console.WriteLine("Исходный массив: ");
            PrintMatrix(secondPart.Matrix);

            secondPart.GetSumInRows(x, y); //поиск суммы в строках с отриц эл-ми
            Console.WriteLine();

            secondPart.GetSedlPoints(x, y);
        }


        static void PrintVector(IEnumerable<double> vector) //для 1 части
        {
            Console.WriteLine(string.Join(" ", vector));
        }


        static void PrintMatrix(int[,] matrix) //для 2 части
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //вывод двумерного массива в прямоугольном виде
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }
    }
}

