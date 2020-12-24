using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_TryCatch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* 
            int x = 10, y = 0;

            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            finally
            {
                Console.WriteLine("무조건 출력됨");            
             }
             */
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;

            checked // 오버플로 예외 발생시킴 / checked를 사용하지 않으면 디폴프로 unchecked 상태로 되어 결과의 MSB가 무시되고 실행이 계속된다. 
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("int.MaxValue + 10 = {0}", y); // 오버플로우 발생하면 0으로 출력  
            }
        }
    }
}
