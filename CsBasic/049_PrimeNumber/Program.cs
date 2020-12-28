using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 50 원주율 계산 

            bool sign = false;
            double pi = 0; 

            for (int i = 1; i < 10; i +=2) // 덧셈과 뺄셈 번갈아 수행 
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true; 
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false; 
                }
                Console.WriteLine(" i = {0}, PI = {1}", i, 4 * pi);
            }
            // 049 소수 판단하기 
            /*
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int index;
                 for (index = 2; index < num; index++) 
            {
                if (num % index == 0)
                {
                    Console.WriteLine("{0}는 소수가 아닙니다.", num);
                    break; 
                }
            }
            if (index == num)
                Console.WriteLine("{0} 는 소수입니다. ", num); 
            */

            // 055 소수 출력하고 몇개인지 찾기 

            int index;
            int primes = 0; // 소수 개수 

            for (int i = 2; i < 1000; i++)
            {
                for (index = 2; index < i; index++)
                {
                    if (i % index == 0) // 나눠지면 탈출 
                        break;
                }
                if (index == i) // i 가 소수라면 
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n" : ""); // i를 5자리로 출력, 15개 마다 줄바꿈 
                }
            }
            Console.WriteLine("\n 2부터 1000사이의 소수의 개수 : {0}개", primes); 

            
        }

    }
}
