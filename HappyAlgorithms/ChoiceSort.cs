using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlgorithms
{
    class ChoiceSort
    {
        public int[] ChoiceSortAlgo(List<int> mas)
        {
            int smallest;
            int[] sortMas = new int[mas.Count];
            for (int i = 0; i < sortMas.Length; i++)
            {
                smallest = FindSmalllest(mas);
                sortMas[i] = mas[smallest];
                mas.RemoveAt(smallest);
            }
            return sortMas;
        }

        public int FindSmalllest(List<int> mas)
        {
            int smallestIndex = 0;
            int smallest = mas[0];
            for (int i = 0; i < mas.Count; i++)
            {
                if (smallest > mas[i])
                {
                    smallest = mas[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public int[] BubbleSort(int[] arr)
        {
            int indexOfMax = 0;
            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                        indexOfMax = j;
                    }
                }
            }
            return arr;
        }
    }
}
//Память компьютера напоминает огромный шкаф с ящиками.
//1:1 Если вам потребуется сохранить набор элементов, воспользуйтесь мас
//сивом или списком.
//Q В массиве все элементы хранятся в памяти рядом друг с другом.
//Q В списке элементы распределяются в произвольных местах памяти, при
//этом в одном элементе хранится адрес следующего элемента.
//1:1 Массивы обеспечивают быстрое чтение. 
//1:1 Списки обеспечивают быструю вставку и выполнение. 
//Q Все элементы массива должны быть однотипными (только целые числа, только вещественные числа и т.д.). 
