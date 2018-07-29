using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlgorithms
{
    class Recursion
    {
        public int Sum(LinkedList<int> mas)
        {
            int sum = 0;
            if (!mas.Any()) return sum; 
            else
            {
                sum += mas.First.Value;
                mas.RemoveFirst();
            }
            return sum + Sum(mas);
        }
    }
}
