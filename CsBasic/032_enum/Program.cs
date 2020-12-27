using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_enum
{
    class Program
    {
        // 열거형 : 서로 관련있는 상수들의 집합을 정의 , 메소드 밖( namespace, class 안에서 사용) 
        enum Size { Short, Tall, Grande, Venti };
        static int[] price = { 3300, 3800, 4300, 4800 }; // Size에 각각 해당하는 가격 
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 }; 
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 }; 

        //033 상수, const 와 readonly
        class ConstEx
        {
            public const int number = 3; 
        }
        class ReadonlyEx
        {
            public readonly int number = 10; 
            public ReadonlyEx()
            {
                number = 20; 
            }
            public ReadonlyEx(int n)
            {
                number = n; 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표"); 
            for(int i = 0; i<4; i++)
            {
                if (i == (int)Size.Short) // int 로 캐스팅하면 기호 상수에 해당사는 숫자 가져옴 
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, price[i]); 
                else if (i == (int)Size.Tall)
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, price[i]);
                else if (i == (int)Size.Grande)
                    Console.WriteLine("{0,10} : {1:C}", Size.Grande, price[i]);
                else if (i == (int)Size.Venti)
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, price[i]);
            }

            Console.WriteLine("\n 커피 가격표 (Enum uteration)"); 
            foreach ( var size in Enum.GetValues(typeof(Size))) // foreach 열거형의 각 요소를 반복문에서 사용 
            {
                Console.WriteLine("{0,10} : {1:C}", size, price[(int)size]); 
            }
            Console.WriteLine("\nColors Enum iteration"); 
            foreach ( var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine("{0,10} : {1}", color, Convert.ToInt32(color)); 
            }

            Console.WriteLine("\n 커피 가격표 (Enum iteration with value)"); 
            foreach ( var coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine("{0,10} : {1:C}", coffee, Convert.ToInt32(coffee)); 
            }

            //033 
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);

            //034 값 형식과 참조 형식, ref 키워드 
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s); // 로컬에서만 변화 
            Test(ref s);
            Console.WriteLine(s); // 참조 형식 

        }
        public static void Test(string s)
        {
            s = "after passing"; 
        }
        public static void Test(ref string s)
        {
            s = "after passing"; 
        }
    }
}
