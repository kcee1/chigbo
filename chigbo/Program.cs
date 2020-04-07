using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chigbo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[3];
            number[0] = 1;
            number[1] = 2;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);


            var flags = new bool[3];
            flags[0] = true;
            flags[1] = true;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            var names = new string[3] { "jack", "jude", "job" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);


            Console.ReadLine();
        }
    }
}
