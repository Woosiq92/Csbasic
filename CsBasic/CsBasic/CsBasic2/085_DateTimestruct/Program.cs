using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace _085_DateTimestruct
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(1992, 7, 4, 8, 44, 0); // 1992년 7월 4일 8시 44분 생성 
            DateTime date2 = new DateTime(1990, 1, 27, 12, 6, 0);

            Console.WriteLine(date1);
            Console.WriteLine(date2);

            Console.WriteLine("{0}과 {1}의 차이는 {2}일입니다. ", date1.ToString("yyyy년 m월 d일"), date2.ToString("yyyy년 m월 d일"), date1.Subtract(date2).Days); // 두 날짜 사이의 차이 
            Console.WriteLine("\n오늘 : {0}", DateTime.Today); // 시간이 0:00 분인 오늘 날짜 

            DateTime y = DateTime.Today.AddDays(-1); // 어제 날짜 
            Console.WriteLine("어제: {0}", y.ToShortDateString()); // 날짜를 간단하게 표시 

            DateTime t = DateTime.Today.AddDays(1); // 내일 날짜 
            Console.WriteLine("내일: {0}", t.ToShortDateString());

            Console.WriteLine("\n2020년은 {0}입니다", DateTime.IsLeapYear(2020) ? "윤년" : "평년");
            Console.WriteLine("2020년 2월은 {0}일입니다. \n", DateTime.DaysInMonth(2020, 2)); // 2월의 날짜 수를 출력 

            // Parse and TryParse 
            string date = "1990-1-27 12:6";
            DateTime aDay = DateTime.Parse(date);
            Console.WriteLine(aDay);

            string input = "1992/7/4 8:44";
            DateTime bDay; 
            if (DateTime.TryParse(input, out bDay))
            {
                Console.WriteLine(bDay);
            }
            Console.WriteLine();

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //088 _DateTimeFormat 
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy년 MM월 dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 mm월 dd일}", today));
            Console.WriteLine(today.ToString("mmmm dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-Us")));

            Console.WriteLine("d: " + today.ToString("d")); // d : 축약된 날짜 형식 
            Console.WriteLine("D: " + string.Format("{0:D}", today)); // D : 긴 날짜형식  
            Console.WriteLine("t: " + string.Format("{0:t}", today)); // t : 축약된 시간  
            Console.WriteLine("T: " + string.Format("{0:T}", today)); // T : 긴 시간 형식  
            Console.WriteLine("g: " + string.Format("{0:g}", today)); // g : 일반 날짜 및 시간 (초 생략) 
            Console.WriteLine("G: " + string.Format("{0:G}", today)); // G : 일반 날짜 및 시간 
            Console.WriteLine("f: " + string.Format("{0:f}", today)); // f : Full 날짜 및 시간 (초생략) 
            Console.WriteLine("F: " + string.Format("{0:F}", today)); // F : Full 날짜 및 시간 
            Console.WriteLine("s: " + string.Format("{0:s}", today)); // s : ISO 8601 표준 ( 밀리초 생략 )  
            Console.WriteLine("o: " + string.Format("{0:o}", today)); // o : ISO 8601 표준
            Console.WriteLine("r: " + string.Format("{0:r}", today)); // r : UTC로 표시  
            Console.WriteLine("u: " + string.Format("{0:u}", today));// u : UTC로 출력  



        }
    }
}
