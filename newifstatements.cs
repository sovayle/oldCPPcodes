using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks;

namespace newifstates { class Program { static void Main(string[] args) {

          bool isMale = false;
          bool isTall = false;

          if (isMale && isTall)
          {
              Console.WriteLine("You are tall and male");
          }
          else if (isMale && !isTall)
          {
              Console.WriteLine("You are a short male");
          }
          else if (!isMale && isTall)
          {
              Console.WriteLine("You are not male but you are tall");
          }
          else
          {
              Console.WriteLine("You are neither male or tall");
          }

          Console.ReadLine();

      }
  }
}
