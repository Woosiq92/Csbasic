using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";
            b = b + "ello";
            Console.WriteLine(a == b); // True 출력 
            Console.WriteLine(" b = " + b);
            int x = 10;
            string c = b + '!' + "" + x;
            Console.WriteLine("c = " + c);

        }
    }
}

// 코드 한줄씩 실행 F10