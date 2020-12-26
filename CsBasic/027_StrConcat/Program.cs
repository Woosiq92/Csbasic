using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_StrConcat
{
    /* 문자열 연결하는 4가지 방법 
    * 1. + 연산자 사용 
    * 2. 문자열 보간 (string Interpolation) : $ 로 값 표현 
    * 3. String.Format 메소드 사용 
    * 4. String.Concat 과 String.Join() 사용      */

    class Program
    {
        static void Main(string[] args)
        {
            // 027 StringConcat 
            string username = "biking";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "hello " + username + ". Today is " + date + "."; // 1번 
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}.", username, date); // 3번 
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {username}. Today is {date}."; // 2번 
            Console.WriteLine(strInterpolation);

            string strConcat = String.Concat("Hello ", username, ". Today is ", date, "."); // 4번 - 문자열 결합 
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(",", animals); // 구분 기호 사용하여 연결 
            Console.WriteLine(s);

            // 028 문자열 검색 
            /* 1. Contains() 
             * 2. IndexOf() 
             * 3. StringComparison : 대소문자 구분 x 
             * 4. String.StartsWith() 와 String.EndsWith() */

            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the sting ' {1}' : {2}", s2, s1, b); // Cow는 포함하고 있지 않기 때문에 false / cow면 True

            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index); // 포함된 문자열이 몇번째 인덱스에 위치하는지 출력 
            }

            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0) // 대소문자 구분 x : -1 이면 값 존재하지 않음 
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1); 
            }

            //029 날짜와 시간 형식 지정 

            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue); // 16진수, 지수형, 구분자가 있는 숫자형으로 변환하여 max에 할당 
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s3 = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s3); 

            s3 = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate); // C : 통화 형식 (\) , 3자리 마다 콤마 
            Console.WriteLine(s3);

            s3 = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t} 입니다.", DateTime.Now);
            Console.WriteLine(s3);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62); // 구조체 변수 선언 TimeSpan 
            string output = String.Format("소요시간: {0:c}", duration); // c 형식 
            Console.WriteLine(output);


            // 030 그룹 분리자를 넣는 방법 - 161장 표준 계산기에서 사용 

            double v1 = 1234.5678;
            string v2 = string.Format("{0:N}", v1);
            Console.WriteLine(v2);
            string v3 = string.Format("{0:N0}", v1);
            Console.WriteLine(v3);
            string v4 = string.Format("{0:N3}", v1);
            Console.WriteLine(v4);

            while (true)
            {
                Console.Write("표시할 숫자를 입력하세요(종료:-1) : ");
                string s5 = Console.ReadLine();
                double v = double.Parse(s5);
                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s5)); // 사용자 정의 함수 
            }  
        }

        private static string NumberWithGroupSeparator(string s5)
        {
            int pos = 0;
            double v = Double.Parse(s5);

            if (s5.Contains(".")) // 소수점이 있는지 검사 
            {
                pos = s5.Length - s5.IndexOf('.'); // 문자열 길이에서 소수점이 있는 인덱스를 뺌 => pos는 소수점 자릿수 보다 1이 큰수  
                string formatStr = "{0:N" + (pos - 1) + "}"; // (pos -1) = 소수점 아래 자릿수 
                s5 = string.Format(formatStr, v); 
            }
            else
                s5 = string.Format("{0:N0}", v); // 소수점이 없는 경우 
            return s5;
        }
    }
}
