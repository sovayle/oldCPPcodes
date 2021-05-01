# luckynumbers.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luckynumbahs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 5, 42, 72, 94, 49, 32 };

            for (int i = 0; i < luckynumbers.Length; i++)
            {
                Console.WriteLine(luckynumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
