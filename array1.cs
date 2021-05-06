# array1.cs
using System.Text;
using System.Threading.Tasks;

namespace arrayzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 26, 53, 43, 52, 954 };
            luckynumbers[1] = 940;
            Console.WriteLine( luckynumbers[1] );

            string[] friends = new string[5];
            friends[1] = "Jack";
            friends[2] = "Kevin";
            Console.WriteLine(friends[1]);


            Console.ReadLine();
        }
    }
}
