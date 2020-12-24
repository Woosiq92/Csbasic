using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. int 로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
                Console.WriteLine("'{0}'은 int로 변환될 수 없습니다\n", input);
            else
                Console.WriteLine("'int '{0}'으로 변환되었습니다\n", value);

            Console.Write(" 2. double 로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();
            try // 예외 처리 문장 
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다. ", m);
            }
            catch (FormatException e) // 예외가 발생하면 실행 
            {
                Console.WriteLine(e.Message); 
            }

            // 015 Convert 클래스와 2진수, 8진수, 16진수 출력 
            int x, y;
            Console.Write("첫번째 숫자를 입력하세요:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            
            short v = short.MaxValue;  // Int16.MaxValue // 변환할 값 
            Console.WriteLine("2, 8, 10, 16 진수 출력");

            int BaseNum = 2;
            string s = Convert.ToString(v, BaseNum); // v를 BaseNum 진수로 변환 
            int i = Convert.ToInt32(s, BaseNum); // s를 BaseNum 진수로 변환 
            Console.WriteLine(" i = {0}, {1,2} 진수 = {2, 16}", i, BaseNum, s); // {0} = 첫번째 데이터인 i 값  

            BaseNum = 8;
            s = Convert.ToString(v, BaseNum);
            i = Convert.ToInt32(s, BaseNum);
            Console.WriteLine(" i = {0}, {1,2} 진수 = {2, 16}", i, BaseNum, s); // {1,2} = 두번째 데이터인 BaseNum을 2자리로 

            BaseNum = 10;
            s = Convert.ToString(v, BaseNum);
            i = Convert.ToInt32(s, BaseNum);
            Console.WriteLine(" i = {0}, {1,2} 진수 = {2, 16}", i, BaseNum, s); // {2, 16} = 세번째 데이터 s를 16자리로 

            BaseNum = 16;
            s = Convert.ToString(v, BaseNum);
            i = Convert.ToInt32(s, BaseNum);
            Console.WriteLine(" i = {0}, {1,2} 진수 = {2, 16}", i, BaseNum, s);


        }
    }
}
