using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine((y + c)* h);

        }
    }
}
