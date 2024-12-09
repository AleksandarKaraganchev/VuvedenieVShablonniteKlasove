using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutiqST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("a");
            box.Add("b");
            box.Add("c");
            box.Add("d");
            Console.WriteLine(box.Remove());
            box.Add("e");
            box.Add("f");
            Console.WriteLine(box.Remove());
        }
    }
}
