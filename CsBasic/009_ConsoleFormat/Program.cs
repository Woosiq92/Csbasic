using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ConsoleFormat
{
    class Program
    {
        static void Main(string[] args)  // 함수 - 외부와 소통하기 위해 ( 값을 전달하고 받고) 
                                         // 리턴값 : 자신의 상태를 외부로 알려줌 , 함수가 종료됨 
        {
            int v1 = 100;
            double v2 = 1.234; 
            //Console.WriteLine(v1, v2) -> 두 변수를 출력하는 메소드 정의가 없기 때문에 에러 
            // 두 변수를 출력하는 방법 
            // 1. 두개 변수의 값을 각각 문자열로 바꾸어 연결해서 하나의 문자열로 출력하는 방법 

            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);

            //2. 형식 정보를 사용하여 여러개의 변수나 값을 출력하는 방법 

            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);

            //3. 형식문자열 앞에 $ 기호를 사용하는 문자열 보간 방법(string interpolation) 

            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); 

        }
    }
}
