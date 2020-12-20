using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasic
{
    class console 
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");   // 출력한다. 
            Console.WriteLine("World"); // 출력하고 줄을 바꾼다. 
            Console.Write("이름을 입력하세요: "); 
             // Console.Read() : 콘솔에서 한 글자를 읽는다. 
            string name = Console.ReadLine(); // 콘솔에서 한 줄을 읽는다. 
            Console.Write("안녕하세요, "); 
            Console.Write(name);
            Console.WriteLine("님 ! ");
        }
    }
}

