using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutiqZaVsichko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input in int: ");
            int inputInt = int.Parse(Console.ReadLine());
            Box<int> boxInt = new Box<int>(inputInt);
            Console.Write("Enter input in string: ");
            string inputString = Console.ReadLine();
            Box<string> boxString = new Box<string>(inputString);
            Console.WriteLine(boxInt);
            Console.WriteLine(boxString);
        }
    }
}
