using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 043 1부터 100까지 더하는 프로그램 
            int sum = 0; 
            for (int i =1 ; i <=100; i++)
            {
                sum += i; 
            }
            Console.WriteLine("1부터 100까지의 합 {0}", sum);

            // 홀수의 합 
            int sum1 = 0; 
            for (int i = 1; i <= 100; i ++)
            {
                if (i % 2 == 1)
                    sum1 += i; 
            }
            Console.WriteLine("1부터 100까지 홀수 합 {0}", sum1);

            // 1+ 1/2 + 1/3 + 1/4  + ... + 1/ 100  
            double sum2 = 0; 
            for (int i = 1; i <= 100; i ++)
            {
                sum2 += 1.0 / i; 
            }
            Console.WriteLine("1부터 100까지 분수 합 {0}", sum2);

            // 2진수, 8진수, 16진수 

            Console.WriteLine("{0,5} {1,8} {2,3} {3,4}", "10진수", "2진수", "8진수", "16진수");

            for (int i = 1; i <=128; i ++)
            {
                Console.WriteLine("{0,7} {1,10} {2,5} {3,6}", i, Convert.ToString(i, 2).PadLeft(8, '0'), Convert.ToString(i, 8), Convert.ToString(i, 16));
                // padLeft 메소드로 2진수의 왼쪽을 0으로 채움 
            }

            // 045 , 054 구구단 
           
            for (int i = 1; i <= 9; i ++)
            {
                for(int j = 2; j <10; j ++)
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                Console.WriteLine(); 
            }

            //056 이중 루프와 피라미드 출력 

            // (1)
            for (int i = 1; i<= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine(); 
            }
            Console.WriteLine();

            // (2)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 2*i -1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (3)
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // (4)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
           
            // (5)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2*i-1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            //(6) 
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }


            // 046 평균, 최소, 최대값 구하기 

            double max = double.MinValue;
            double min = double.MaxValue;
            double sum3 = 0; 

            for (int i = 0 ; i < 5; i ++)
            {
                Console.Write("키를 입력하세요 (단위 : cm) : ");
                double h = double.Parse(Console.ReadLine());
                if (h > max)
                    max = h;
                if (h < min)
                    min = h;
                sum3 += h; 
            }
            Console.WriteLine("평균 : {0}cm , 최대: {1}cm, 최소 : {2} cm ", sum3 / 5, max, min); 

        }
    }
}
