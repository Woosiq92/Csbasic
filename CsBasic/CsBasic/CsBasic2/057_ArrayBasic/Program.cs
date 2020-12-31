using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_ArrayBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 }; // 정수 배열 a를 만들고 초기화 
            Console.Write("a[]: ");
            foreach (var value in a) // 배열의 각 요소를 출력 = a 컬렉션의 각 요소값 value에 대해서 
                Console.Write(value + " "); // 배열 값 + 한칸 뛰기 , var : 어떤 자료형이든 쓸 수 있는 키워드 

            int[] b = new int[] { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for (int i = 0; i < 3; i++)
                Console.Write(b[i] + " ");

            int[] c = new int[3] { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for (int i = 0; i < c.Length; i++)
                Console.Write(c[i] + " ");

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach (int value in d)
                Console.Write(value + " ");
            Console.WriteLine();

            // 058_ArrayClass 배열과 Array 클래스 

            int[] a1 = { 5, 25, 75, 35, 15 };
            PrintArray(a1);

            int[] b1;
            b1 = (int[])a1.Clone(); // 복사 
            PrintArray(b1);

            int[] c1 = new int[10];
            Array.Copy(a1, 0, c1, 1, 3); // 정적메소드 copy를 이용하여 a 배열 내용을 c로 복사 
            PrintArray(c1);              // 배열의 0번 인덱스부터 3개 요소를 c배열의 1번 인덱스 위치에 복사 

            a.CopyTo(c1, 3); // a배열 내용을 c배열의 3번 인덱스에 복사하고 출력 
            PrintArray(c1);

            Array.Sort(a1); // 오름차순 정렬 
            PrintArray(a1);

            Array.Reverse(a1); 
            PrintArray(a1);

            Array.Clear(a1, 0, a1.Length); // 모든 요소를 0으로 초기화 
            PrintArray(a1);

            //059_MultiDimensionArray 

            Console.WriteLine("\n2차원 배열 : arrA[2,3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // [,] 2차원 배열 선언 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", arrA[i, j]);
                Console.WriteLine(); 
            }
            Console.WriteLine("가변 배열: arrB[2][3]");

            int[][] arrB = new int[2][]; // 2차원 배열 선언 ( 가변 배열) 
            arrB[0] = new int[] { 1, 2 };
            arrB[1] = new int[] { 3, 4, 5 }; 

            for (int i = 0; i< 2; i++)
            {
                Console.Write("arrB[{0}] : ", i);
                for (int j = 0; j < arrB[i].Length; j++)
                    Console.WriteLine("{0} ", arrB[i][j]);
                Console.WriteLine(); 
            }

            //060_ArraySorting 이름을 배열에 저장하고 알파벳 순으로 정렬 

            string[] name = { "mouse", "cow", "Tiger", "Rabbit", "Dragon", "snake", "Horse" };
            PrintArray1("Before Sort: ", name);

            Array.Reverse(name);
            PrintArray1("After Reverse: ", name);

            Array.Sort(name); // 오름차순 
            PrintArray1("After Sort: ", name);

            Array.Reverse(name); // 내림차순 정렬 
            PrintArray1("After Reverse: ", name);

        }

        private static void PrintArray(int[] a) // 배열의 요소 출력 
        {
            foreach (var i in a)
                Console.Write(" {0,5}", i);
            Console.WriteLine(); 
        }

        private static void PrintArray1(string s, string[] name) // 배열의 요소 출력 
        {
            Console.WriteLine(s); 
            foreach (var i in name)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }
    }
   
}
