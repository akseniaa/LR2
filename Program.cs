using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Program
    {
        static void Main()
        {            
            Console.WriteLine("Введите числа для сортировки через пробел");
            var str = Console.ReadLine().Split();
            var arr = new int[str.Length];            
            
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(str[i]);
            }
            Console.Write("Строка до сортировки:  ");

            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("\n");

            arr = MargeSort.Sort(arr);
            Console.WriteLine("Инверсий:" + MargeSort.number.ToString() + "\n");

            Console.Write("Строка после сортировки:  ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
