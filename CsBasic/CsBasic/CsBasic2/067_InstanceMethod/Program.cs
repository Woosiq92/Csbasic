using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_InstanceMethod
{
    //067_InstanceMethod 인스턴스 메소드와 스태틱 메소드 
    class Date
    {
        public int year, month, day;

        public static bool IsLeapYear(int year) // 윤년이면 true 를 리턴하는 메소드 ( 함수 x) 
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DayOfYear() // 1월 1일부터 며칠째 되는 날인지 리턴하는 메소드 
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }

    class InstanceMethod
    {
        static void Main()
        {
            Date xmas = new Date();

            xmas.year = 2018;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2} 는 {3}일째 되는 날입니다", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());

            if (Date.IsLeapYear(2018) == true)
                Console.WriteLine("2018년은 윤년이다.");
            else
                Console.WriteLine("2018년은 평년이다.");
        }
    }

}
