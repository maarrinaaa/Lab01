
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class FirstPart
    {
        //5 вариант
        //Ctrl+K,C — закомментировать выделенные строки в коде. Ctrl+K,U — раскомментировать выделенные строки в коде.

        public FirstPart(double[] myArray) //конструктор для теста 
        {
            array = new double[myArray.Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = myArray[i];
        }



        private readonly double[] array;

        public FirstPart(int length) //конструктор заполнения массива
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            var random = new Random();

            array = new double[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1, 3) + random.NextDouble();
            }
        }

        public IReadOnlyList<double> Vector
        {
            get
            {
                return array;
            }
        }


        public double GetMinimumElement() //метод поиска минимального элемента
        {
            double minimum = 1000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimum)
                    minimum = array[i];
            }


            return minimum;
        }


        public double GetSumBetweenPositiveElements()
        {
            int first = -1, last = -1; //индексы первого и последнего положительного
            double sum = 0; //сумма между положительными
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    first = i; //первый встретившийся >0 подходит
                    break;
                }
            }

            if (first == -1) //так и не встретили положительный
            {
                Console.WriteLine("We have no elements > 0");
                return sum;
            }


            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0) //первый с конца положительный - последний
                {
                    last = i;
                    break;
                }
            }
            if (first == last)
            {
                Console.WriteLine("\nWe have only one >0 element");
                return sum;
            }


            for (int i = first + 1; i < last; i++) //подсчет суммы между положительными
            {
                sum += array[i];
            }

            return sum;
        }

        public IEnumerable<double> SortByZeros()
        {

            for (int i = 0, j = 0; i < array.Length; i++)
                if (array[i] <= 1)
                    if (array[i] > -1) //если в пределах 0 с обеих сторон от 0
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        j++;
                    }
            return array;
        }
    }
}




