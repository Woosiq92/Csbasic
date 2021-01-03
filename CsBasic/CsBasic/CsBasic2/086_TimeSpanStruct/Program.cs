using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_TimeSpanStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime christmas = new DateTime(2018, 12, 25);
            DateTime newYearsDay = new DateTime(2019, 1, 1);

            TimeSpan span = newYearsDay - christmas;
            Console.WriteLine("크리스마스와 1월 1일의 시간 간격");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.Days);
            Console.WriteLine("{0,14} hours", span.Hours);
            Console.WriteLine("{0,14} minutes", span.Minutes);
            Console.WriteLine("{0,14} seconds", span.Seconds);
            Console.WriteLine("{0,14} milliseconds", span.Milliseconds);

            Console.WriteLine("또는");
            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.TotalDays);
            Console.WriteLine("{0,14} hours", span.TotalHours);
            Console.WriteLine("{0,14} minutes", span.TotalMinutes);
            Console.WriteLine("{0,14} seconds", span.TotalSeconds);
            Console.WriteLine("{0,14} milliseconds", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);

            //087 생애계산기 

            Console.Write("생년월일 시분초를 입력하세요 : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Now;

            TimeSpan interval = date2 - date1;
            Console.WriteLine("탄생시간 : {0}", date1);
            Console.WriteLine("현재시간 : {0}", date2);
            Console.WriteLine("생존 시간: {0}", interval.ToString());
            Console.WriteLine(" 당신은 지금까지 {0}일 {1}시간" + "{2}분 {3}초를 살았습니다", interval.Days, interval.Hours, interval.Minutes, interval.Seconds);


        }
    }
}
