using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _004_Variable // 네임스페이스 : 하나의 이름이 하나의 개체(의미)를 가질수 있도록 하는 공간(범위) 
{
    class Variable
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());  //parse 메서드 : 입력받은 문자열을 정수형으로 변환하여 할당 
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine()); //parse 메서드 : 입력받은 문자열을 실수형으로 변환하여 할당 

            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는");
            Console.Write(height);
            Console.WriteLine("cm 이군요!"); 
        }
    }
}
