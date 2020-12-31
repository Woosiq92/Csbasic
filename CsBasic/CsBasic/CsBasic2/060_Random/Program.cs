using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); // Random 객체 r 생성 
            Console.Write("{0, -16}", "Random Bytes");
            Byte[] b = new byte[5]; //  상수  0 ~ 255 까지의 값을 가진 부호 없는 정수
            r.NextBytes(b); // 바이트 숫자로 배열을 채움 

            foreach (var x in b) // 5번 반복 
                Console.Write("{0, 12}", x); // 한 숫자당 12자리 차지하여 출력 
            Console.WriteLine();

            Console.Write("{0, -16}", "Random Double");
            double[] d = new double[5];

            for (int i = 0; i < 5; i++) // 5개 double 랜덤값 생성 저장 
                d[i] = r.NextDouble(); 

            foreach (var x in d)
                Console.Write("{0, 12:F8}", x); // 12자리, 소수점 아래 8자리로 출력 
            Console.WriteLine();

            Console.Write("{0, -16}", "Random Int32");
            int[] a = new int[5];

            for (int i = 0; i < 5; i++) // 5개 int 랜덤값 생성 저장 
                a[i] = r.Next();
            PrintArray(a);

            Console.Write("{0, -16}", "Random 0 ~ 99");
            int[] v = new int[5];

            for (int i = 0; i < 5; i++) // 5개 0~99의 랜덤값 생성 저장 
                v[i] = r.Next(100);
            PrintArray(v);

            // 062_ArrayAndRandom 배열에서 최소 최대 평균 계산 

            Random r1 = new Random();
            int[] v1 = new int[20];

            for (int i = 0; i < v1.Length; i++)
                v1[i] = r1.Next(100);
            PrintArray1(v1);

            int max = v1[0];
            for (int i = 1; i < v1.Length; i++)
                if (v1[i] > max)
                    max = v1[i];
            Console.WriteLine("최대값 : {0}", max);

            int min = v1[0];
            for (int i = 1; i < v1.Length; i++)
                if (v1[i] < min)
                    min = v1[i];
            Console.WriteLine("최소값 : {0}", min);

            int sum1 = 0;
            for (int i = 0; i < v1.Length; i++)
                sum1 += v1[i];
            Console.WriteLine("합계 : {0} \n 평균 : {1:F2}", sum1, (double)sum1 / v1.Length); 
        }

        private static void PrintArray(int[] v)
        {
            foreach (var value in v)
                Console.Write("{0,12}", value);
            Console.WriteLine(); 
        }
        private static void PrintArray1(int[] v1)
        {
            for (int i = 0; i < v1.Length; i++)
                Console.WriteLine("{0,5}{1}", v1[i], (i % 10 == 9) ? "\n" : ""); 
        }
    }
}
