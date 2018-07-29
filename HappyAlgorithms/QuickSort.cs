using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlgorithms
{
    class QuickSort
    {
        public void Sort(int[] arr, int left, int right)
        {
            //i и j нужны для цикла
            int l = left;
            int r = right;
            int x = arr[(left + right) / 2]; //Опорная
            //Цикл сортировка
            while (l <= r)
            {
                //Деление на меньше и больше опорного
                while (arr[l] < x) l++;
                while (arr[r] > x) r--;
                //Если i<=j:
                if (l <= r)
                {
                    //меняем значение элемонтов
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }
            }
            //Рекурсия
            if (left < r) Sort(arr, left, r);
            if (l < right) Sort(arr, l, right);
        }
    }
}
