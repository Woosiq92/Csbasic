using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // Stopwatch 사용하기 위한 네임스페이스 추가 

namespace _031_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // string 객체의 값은 한번 만들면 변경할 수 없다. (immutable) 
            // 객체가 변경될 때마다 새로운 string을 만들어서 변수명에 할당해 주어야 한다. 
            // 따라서 string 값을 자주 변경하는 경우에 쓸데 없이 스트링이 많이 만들어지고 실행속도와 메모리 사용이 많아진다. 

            //stringbuilder 는 변경 가능하다. (mutable) -> 동적 조정을 통해 효율적 사용 가능 

            string buffer = "The numbers are: ";
            for (int i = 0; i < 3; i++)
            {
                buffer += i.ToString();  // string이 변경될때 마다 새로운 7개의 string 생성(i와 string 3번) but 1개만 필요 
            }

            StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length); // 내용과 길이 출력 

            sb.Clear(); // 메소드 초기화 
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string. ");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz ", 2); // sb의 5번째 위치에 xyz를 2번 삽입 
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4); //sb의 5번째 위치에서 4개의 문자 삭제 
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz", "abc"); // 메소드는 sb에서 "xyz"를 "abc"로 대치한다. 
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start(); 
            for (int i = 0; i < 100000; i ++)
            {
                test += i; 
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + " ms"); // String 사용했을때 시간 

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start(); 
            for (int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + "ms"); // StringBuilder 사용했을 때 시간 

        }
    }
}
