using KutiqZaVsichko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversalnaKutiqZaNizove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> listBox = new List<Box<string>>();
            Console.Write("How many strings you want to add?: ");
            short n = short.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                Box<string> box = new Box<string>(inputString);
                listBox.Add(box);
            }
            foreach (Box<string> box in listBox) 
            {
                Console.WriteLine(box);
            }
        }
    }
}
