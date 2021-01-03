using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _079_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            // 082_HanoiTower 

            for (int i = 1; i <=50; i ++)
            {
                double m1 = Mersenne(i); // 메르센 수 = 하노이탑의 이동 횟수 ( 2의 n승 -1)  
                Console.WriteLine("메르센 수({0}) = {1:N0} = {2:N1}일 = {3:N1}년", i, m1, m1 / 3600 / 24, m1 / 3600 / 24 / 365); 
            }
            //하노이 탑 문제 
            Console.WriteLine("\nHanoi Tower: {0}, {1} -> {2} -> {3}", 4, 'A', 'B', 'C');
            Hanoi(4, 'A', 'C', 'B'); // 4개의 원반을 A에서 C를 이용해 B로 이동 

            //83 _재귀 이진 탐색 
            Random r = new Random();
            int[] v = new int[30];

            for (int i = 0; i < 30; i++)
                v[i] = r.Next(1000); //  0 ~ 999까지의 사이의 랜덤 값 저장 
            PrintArray("정렬 전 ", v);

            Array.Sort(v);
            PrintArray("정렬 후 ", v);

            Console.Write(" => 검색할 숫자를 입력하세요 : ");

            int key = int.Parse(Console.ReadLine());
            int index = RecBinarySearch(v, 0, v.Length - 1, key);
            if (index == -1)
                Console.WriteLine("찾는 값이 배열에 없습니다. ");
            else
                Console.WriteLine("v[{0}] = {1}", index, key);

            //80_RecursiveFac 
            Console.Write("m! 을 계산합니다. m을 입력하세요: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", m, Fact(m)); 

            // 079 _ Recursive 제곱 
            Console.WriteLine("Power(x,y)를 계산합니다. ");
            Console.Write("x를 입력하세요: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" y를 입력하세요 : ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2}", x, y, Power(x, y));

            //81_RecusiveSumOfReciprocal , 역수합 
            Console.Write("1~n 까지의 역수의 합을 구합니다. n을 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1 ~ {0} 까지의 역수의 합 : {1}", n, SumOfReci(n));
         }

        private static double Power(double x, double y)
        {
            if (y == 0)
                return 1;
            else
                return x * Power(x, y - 1); 
        }

        private static double Fact(double x)
        {
            if (x == 1)
                return 1;
            else
                return x * Fact(x - 1);
        }

        private static double SumOfReci(int n)
        {
            if (n == 1)
                return 1;
            else
                return 1.0 / n + SumOfReci(n - 1); 
        }

        private static double Mersenne(int n)
        {
            return Math.Pow(2, n) - 1; 
        }

        // n개의 원반을 from 에서 by를 이용하여 to로 이동하는 알고리즘 
        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1)
                Console.WriteLine("Move : {0} -> {1}", from, to); 
            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine("Move : {0} -> {1}", from, to);
                Hanoi(n - 1, by, to, from); 
            }
        }

        private static int RecBinarySearch(int[] v, int low, int high, int key) // 인덱스와 key 값 
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;
                if (key == v[mid])
                    return mid;
                else if (key > v[mid])
                    return RecBinarySearch(v, mid + 1, high, key);
                else
                    return RecBinarySearch(v, low, mid - 1, key);

            }
            return -1; // 찾는 값이 배열 안에 없는 경우 
        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0, 5}{1}", v[i], (i % 10 == 9) ? "\n" : "");  // 10개씩 나누어 줄바꿈 
        }
    }
}
