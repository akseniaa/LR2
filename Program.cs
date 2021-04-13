using DocumentFormat.OpenXml.CustomProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LR2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите необходимую задачу");
            Console.WriteLine("1. Сортировка строки");
            Console.WriteLine("2. Исследование сложности алгоритма");

            var flag = Convert.ToInt32(Console.ReadLine());
            if (flag == 1)
            {
                Console.WriteLine("Введите числа для сортировки через пробел");
                var str = Console.ReadLine().Split();
                var arr = new int[str.Length];            
            
                for (var i = 0; i < arr.Length; i++)
                    arr[i] = Convert.ToInt32(str[i]);

                Console.Write("Строка до сортировки:  ");
                foreach (var item in arr)
                    Console.Write(item.ToString() + " ");
                Console.WriteLine("\n");

                arr = Merge.Sort(arr);
                Console.WriteLine("Инверсий:" + Merge.number.ToString() + "\n");               

                Console.Write("Строка после сортировки:  ");
                foreach (var item in arr)
                    Console.Write(item + " ");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Перетащите файл в строку программы");
                var file = Parse(Console.ReadLine());
                foreach(var length in file)
                    Do(length);                
            }
            Console.Read();
            
        }

        static List<int> Parse(string input)
        {
            var doc = new XmlDocument();
            doc.Load(input);
            var element = doc.DocumentElement;
           
            var result = new List<int>();
            
            foreach(XmlNode item in element)
            {
                result.Add(Convert.ToInt32(item.Attributes.GetNamedItem("length").Value));
            }           
            return result;
        }

        static int[] Generate(int length)
        {
            var arr = new int[length];
            var r = new Random();
            for (var i = 0; i < length; i++)
            {
                arr[i] = r.Next();
            }
            return arr;
        }

        static int a = 0;
        static void Do(int length)
        {
            var count = 0;            
            for (var i = 0; i < 8; i++)
            {
                Merge.Sort(Generate(length));
                count += Merge.num;
            }            
            Console.WriteLine($"length = {length}, iteration = {(Merge.num / 8)- a}");
            a = Merge.num / 8;
        }
    }
}
