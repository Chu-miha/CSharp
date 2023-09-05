using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDelegate
{
   // public delegate int ObjectCompare<T>(T x, T y);
    public class DelegatesWithSortArray
    {
        /// <summary>
        /// Алгоритм сортировки пузырьком
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <param name="compare">Пока делегат</param>
        public static void SortStrings<T>(T[] array, Func<T, T, int> compare)
        {
            for (int i = array.Length - 1; i > 0; i--) 
            {
                for (int j = 1; j <= i; j++)
                {
                    T element1 = array[j - 1];
                    T element2 = array[j];
                    if (compare(element1, element2) < 0)
                    {
                        T tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }
        }

       public static int CompareStringLength(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }

    }
}
