using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_ClassAndStruct
{
    struct DateStruct
    {
        public int year, month, day; 
    }

    class DateClass
    {
        public int year, month, day; 
    }

    class Program
    {
        static void Main(string[] args) // static은 객체를 생성하지 않고 바로 사용 
                                       // static 키워드가 있는 메소드를 스태틱 메소드, 클래식 메소드 
                                       // static이 아닌 메소드를 인스턴스 메소드 -> 
        {
            DateStruct sDay; // 구조체는 값형이어서 new 키워드 필요없음 
            sDay.year = 2018;
            sDay.month = 11;
            sDay.day = 22;
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);

            DateClass cDay = new DateClass(); // 참조형인 클래스 객체이므로 반드시 new 키워드 사용 
            cDay.year = 2018;
            cDay.month = 11;
            cDay.day = 22; 
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

            DateStruct sDay2 = new DateStruct();
            Console.WriteLine("sDay2: {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day);
            DateClass cDay2 = new DateClass();
            Console.WriteLine("cDay2: {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day);

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("s:{0}/{1}/{2}", c.year, s.month, s.day);
            Console.WriteLine("c: {0}/{1}/{2}", c.year, c.month, c.day);
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);
            
        }
    }
}
