# entername.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string myname = Console.ReadLine();
            Console.WriteLine("Hello " + myname);

            Console.ReadLine();
        }
    }
}
