using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _089_MethodArguments 
{
    class Program
    {
        // 090 _params , 매개변수의 개수만 다른 메소드를 여러개 만들어야 하는 경우 가변길이 매개변수를 사용하는 메소드 만들기 
        public static void PrintIntParams(params int[] arr)
        {
            for(int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine(); 
        }

        public static void PrintObjectParams(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine(); 
        }

        static int Mypower(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
                result *= x;
            return result; 
        }

        static int Area(int h, int w)
        {
            return h * w; 
        }

        // 메소드에 인수를 전달하는 세 가지 방법 
        static void Main(string[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintObjectParams();

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintObjectParams(myIntArray);

            object[] myObjArray = { 2, 2.345, 'b', "test", "again" };
            PrintObjectParams(myObjArray);

            PrintObjectParams(myIntArray); // int타입은 배열의 내용을 출력할 수 없고 object 타입의 매개변수 하나로 system.Int32[]출력 

            //091 선택적 인수와 명명된 인수 
            Console.WriteLine(Mypower(4, 2));
            Console.WriteLine(Mypower(4));
            Console.WriteLine(Mypower(3, 4));

            Console.WriteLine(Area(w: 5, h: 6));
            Console.WriteLine(Area(h: 6, w: 5));


            int a = 3;
            Sqr(a);
            Console.WriteLine("Value: {0}", a);

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref: {0}", b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out: {0} {1}", name, id);   
        }

        static void Sqr(int x) // 값에 의한 호출 
        {
            x = x * x; 
        }

        static void Sqr(ref int x) // 참조에 의한 호출 
        {
            x = x * x; 
        }

        static void GetName(out string name, out int id) // out 키워드 사용 : 호출한 곳으로 값을 내보내줌 , 메소드내에서는 사용되지 않음 , 여러개의 값 리턴 가능 
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter id: ");
            id = int.Parse(Console.ReadLine());

        }
    }
}
