using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newnewnewnewnewneewewe
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "pyrocinical";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool OutofGuessses = false;

            while (guess != secretWord && !OutofGuessses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    OutofGuessses = true;
                }
                

            }
            if (OutofGuessses)
            {
                Console.WriteLine("u lose");
            }
            else
            {
                Console.Write("Grats u win!");
            }
            

            Console.ReadLine();

        }
    }
}
