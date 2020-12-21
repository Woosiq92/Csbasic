using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_string_Assignment 
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            int i = 5;
            double j = 3.14 ;

            b = b + "ello";
            Console.WriteLine(a == b); // True 출력 
            Console.WriteLine(" b = " + b);
            int x = 10;
            string c = b + '!' + "" + x;
            Console.WriteLine("c = " + c);

            j = i;        // 암시적 형변환 : int 형은 4바이트 double 형은 8바이트기 때문에 값손실 없음 
            i = (int)j; // 캐스트 : 더 큰 자료형을 더 작은 자료형으로 변환할 때 

            bool b1 = true;
            char c1 = 'A';
            decimal d = 1.234m; // m은 decimal 형 의 접미사 ( 소수) 
            float e = 1.234f; // f는 float 형의 접미사 
            Console.WriteLine(b1); 
            Console.WriteLine(c1);
            Console.WriteLine(d);
            Console.WriteLine(e);

            // console.WriteLine 메소드로 여러 개의 값을 출력 
            Console.Write("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); // 문자열에 있는 서식 지정 항목을 지정된 개체들의 문자열 표현으로 바꿉니다.
        }
    }
}

// 코드 한줄씩 실행 F10