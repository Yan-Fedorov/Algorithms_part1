using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlgorithms
{
    class BinarySearch
    {
        public int BinarySearchAlgo(int number, int[] mas)
        {
            int low = 0;
            int high = mas.Length - 1;
            int steps = 0;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                steps++;
                int guess = mas[mid];
                if (number == guess) return steps;
                else if (number < guess)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            };
            return 0;
        }
    }
}
/*
 * Бинарный поиск работает намного быстрее простого. 
 Время выполнения O(log п) быстрее О(п), а с увеличением размера списка, в котором ищется значение, оно становится намного быстрее. 
Скорость алгоритмов не измеряется в секундах. 
 Время выполнения алгоритма описывается ростом количества операций. 
Время выполнения алгоритмов выражается как «О-большое~. 
*/