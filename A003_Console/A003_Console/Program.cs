using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 콘솔에서 읽고 쓰기 
namespace A003_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello");
            Console.WriteLine("World");
            Console.Write("이름을 입력하세요");

            string name = Console.ReadLine(); // 이름을 입력받습니다. 
            Console.Write("안녕하세요");
            Console.Write(name);
            Console.WriteLine("님!"); // line - 줄바꿈 
        }
    }
}
