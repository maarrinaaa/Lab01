using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SecondPart
    {

        //public SecondPart(int[][] myArray) //конструктор для теста 
        //{
        //    matrix = new int[myArray.GetLength(0), myArray.GetLength(1)];//нужного размера массив создали
        //    for (int i = 0; i < myArray.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < myArray.GetLength(1); j++)
        //            matrix[i, j] = myArray[i, j];
        //    }
        //}



        private readonly int[,] matrix;

        public SecondPart(int rows, int cols) //конструктор заполнения массива
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows) + " or " + nameof(cols));
            }

            matrix = new int[rows, cols];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
        }

        public int[,] Matrix
        {
            get
            {
                return matrix;
            }
        }

        public void GetSumInRows(int rows, int cols)
        {

            for (int i = 0; i < rows; i++)
            {
                bool hasNegative = false;
                int sumInRow = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                    }
                    sumInRow += matrix[i, j];
                }

                if (hasNegative)
                {
                    Console.WriteLine($"Сумма в строке {i}: {sumInRow}");
                }
            }
        }


        public void GetSedlPoints(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                int minInRow = matrix[i, 0]; // Минимальный элемент в i-й строке изначально в 1ом столбце
                int columnOfMin = 0; // Столбец минимального элемента в i-й строке сначала самый первый 

                for (int j = 1; j < cols; j++) //идем по столбцам
                {
                    if (matrix[i, j] < minInRow) //если нашелся меньше предыдущего
                    {
                        minInRow = matrix[i, j]; //минимальный элемент в строке новый
                        columnOfMin = j; //в конкретном столбце
                    }
                }

                bool isMaxInColumn = true; // Флаг, отвечающий за проверку, является ли минимальный элемент в i-й строке максимальным в столбце columnOfMin

                for (int k = 0; k < rows; k++) //смотрим все строки в конкртеном столбце (в том, где нашли минимум строки)
                {
                    if (matrix[k, columnOfMin] > minInRow)//если в этом столбце в другой строке есть эл-т больше - не подходит
                    {
                        isMaxInColumn = false;
                        break;
                    }
                }

                if (isMaxInColumn) //если не нарушились 2 условия
                {
                    Console.WriteLine("Седловая точка: [{0}, {1}]", i, columnOfMin);
                }
            }

        }
    }
}

