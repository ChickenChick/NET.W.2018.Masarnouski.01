using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Masarnouski._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 3, 5, 1, 4, 6, 3};
            foreach (var n in mass)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            //   QuickSort.Sort(mass, 0, 5);
            MergeSort.Sort(mass);
            foreach (var n in mass)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
