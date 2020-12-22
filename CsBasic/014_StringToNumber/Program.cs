using System;

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
            catch (FormatException e)
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
