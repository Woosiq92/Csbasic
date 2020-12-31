using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // 064_BubbleSort 버블 정렬 
            int[] v1 = { 3, 5, 2, 7, 1 };
            PrintArray1(v1);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < 1; j++)
                    if (v1[j] > v1[j + 1])
                    {
                        int t = v1[j];
                        v1[j] = v1[j + 1];
                        v1[j + 1] = t; 
                    }
            }

            Random r = new Random();
            int[] v = new int[30];

            for (int i = 0; i < 30; i++)
                v[i] = r.Next(1000);
            PrintArray("정렬 전", v);

            //(1) 정렬 
            Array.Sort(v);
            PrintArray("정렬 후", v);

            Console.Write("=> 검색할 숫자를 입력하세요 : ");
            int key = int.Parse(Console.ReadLine());
            int count = 0; // 비교 횟수 

            // (2) 선형 탐색 
            for (int i = 0; i < v.Length - 1; i++)
            {
                count++; 
                if (v[i] == key )
                {
                    Console.WriteLine("v[{0}] = {1}", i, key);
                    Console.WriteLine("선형탐색의 비교횟수는 {0}회입니다. ", count);
                    break; 
                }
            }

            // (3) 이진 탐색 
            count = 0;
            int low = 0;
            int high = v.Length - 1; 
            while (low <= high)
            {
                count++;
                int mid = (low + high) / 2;
                if (key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                    Console.WriteLine("이진 탐색의 비교횟수는 {0}회입니다.", count);
                    break;
                }
                else if (key > v[mid])
                    low = mid + 1;
                else
                    high = mid - 1; 
            }
        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : ""); 
        }
        private static void PrintArray1(int[] v1)
        {
            foreach (var i in v1)
                Console.Write("{0, 5}, i");
            Console.WriteLine(); 
        }
    }
}
