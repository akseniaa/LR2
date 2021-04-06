using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class MargeSort
    {
        public static int number = 0;
        public static int[] Sort(int[] result)
        {
            if (result.Length > 1)
            {                
                var left = new int[result.Length / 2];                
                var right = new int[result.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = result[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = result[left.Length + i];
                }

                if (left.Length > 1) left = Sort(left);
                if (right.Length > 1) right = Sort(right);
                result = MergeSort(left, right);
            }
            return result;
        }

        private static int[] MergeSort(int[] left, int[] right)
        {
            var arr = new int[left.Length + right.Length];
           
            var a = 0;  
            var b = 0;  
            var c = 0;  
                       
            for (; a < arr.Length; a++)
            {
                
                if (c >= right.Length)
                {
                    arr[a] = left[b];
                    b++;
                }                
                else if (b < left.Length && left[b] < right[c])
                {
                    arr[a] = left[b];
                    b++;
                }                
                else
                {
                    arr[a] = right[c];
                    c++;
                    
                    if (b < left.Length)
                        number += left.Length - b;
                }
            }
            return arr;            
        }
    }
}
