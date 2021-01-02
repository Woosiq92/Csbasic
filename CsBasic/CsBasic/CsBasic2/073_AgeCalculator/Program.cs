using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_AgeCalculator // 생일을 입력하면 오늘까지 살아온 날짜 수를 계산 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("생일을 입력하세요(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split('/');

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            totalDays += DayOfYear(tYear, tMonth, tDay); // 올해의 1월 1일부터 오늘까지의 날짜 수 

            // 태어난 해의 생일부터 마지막 날까지의 날짜 수 
            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay); // 올해 일수 

            for (int year = bYear + 1; year < tYear; year++) // 년도 *365 
            {
                if (IsLeapYear(year))
                    totalDays += 366;
                else
                    totalDays += 365; 
            }
            Console.WriteLine("total days from birth day : {0}일", totalDays);
        }

        // 평년을 기준으로 각 월의 누적 날짜 수 
        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0); // 3월 이후이고 윤년이면 하루를 더한다. 
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0); // 윤년이면 true, 평년이면 false 리턴 
        }
    }
}
