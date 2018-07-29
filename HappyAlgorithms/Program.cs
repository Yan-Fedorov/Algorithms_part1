using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            int n = 1024;
            int[] mas = new int[n];
            for(int i = 0; i< n; i++)
            {
                mas[i] = i;
            }
            int x = binarySearch.BinarySearchAlgo(75, mas);

            List<int> choiceSortMas = new List<int>{ 3, 7, 5, 34, 1 };
            ChoiceSort choiceSort = new ChoiceSort();
            var res = choiceSort.ChoiceSortAlgo(choiceSortMas);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(2);
            linkedList.AddFirst(4);
            linkedList.AddFirst(32);
            linkedList.AddFirst(32);

            Recursion recursionAdd = new Recursion();
            var recursion = recursionAdd.Sum(linkedList);

            QuickSort quickSort = new QuickSort();
            int[] quickSortList = new int[] { 3, 7, 5, 34, 1 };
            quickSort.Sort(quickSortList, 0, quickSortList.Length -1);

            int[] bubbleSort = new int[] { 3, 7, 5, 34, 1 };
            var b = choiceSort.BubbleSort(bubbleSort);



            Dictionary<string, string[]> graph = new Dictionary<string, string[]>();
            graph["you"] = new string[] { "alice", "bob", "claire" };
            graph["bob"] = new string[] { "anuj", "peggy" };
            graph["alice"] = new string[] { "peggy" };
            graph["claire"] = new string[] { "thom", "jonny" };
            graph["anuj"] = new string[] { };
            graph["peggy"] = new string[] { };
            graph["thom"] = new string[] { };
            graph["jonny"] = new string[] { };

            WideWidthSearch wideWidthSearch = new WideWidthSearch();
            var c = wideWidthSearch.SearchQueue(graph);
        }
    }
}
