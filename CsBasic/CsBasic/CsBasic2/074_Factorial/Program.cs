using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _074_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //074 Pyramid 
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);

            //075 Factorial 

            int sum = 0; 
            for (int i = 1; i <=10; i ++)
            {
                sum += Factorial(i);
                Console.WriteLine("{0,2}! : {1, 10:N0}", i, Factorial(i)); 
            }
            Console.WriteLine("1! ~ 10! 의 합 = {0, 8:N0}", sum);

            // 078 원의 면적을 계산  메소드
            for (double r = 1; r < 10; r++)
                Console.WriteLine("circle with radius {0, 2} = {1,7:F2}", r, AreaOfCircle(r));

            
        }

        private static double AreaOfCircle(double r)
        {
            return Math.PI * r * r; 
        }

        private static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact; 
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i ++)
            {
                for (int j = i; j < n; j++)
                    Console.Write("");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine(); 
            }
        }
    }
}
