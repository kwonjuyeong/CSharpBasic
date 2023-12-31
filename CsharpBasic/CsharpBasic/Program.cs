using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("첫 소스코드 입력");
            Console.WriteLine(args.Length);
            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();

        }
    }
} 
