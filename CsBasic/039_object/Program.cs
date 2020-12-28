using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_object // C# 에서 모든 형식은 object로부터 상속된다. (모든 데이터의 조상) 
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // 값 형식의 변수(i)가 object 타입으로 변환되는 것 = 박싱 
            i = i + 10;
            int j = (int)o; // object 타입 변수(o)가 값 형식으로 변환되는 것 = 언박싱 

            // i의 값이 변해도 o에 저장된 값은 영향을 받지 않는다. 
            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The value-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;

            Console.WriteLine("The value-type value i = {0}", o);
            Console.WriteLine("The value-type value i = {0}", p);

            //040 Switch 문 
            Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            string grade = null;

            if (score >= 90)
                grade = "A"; 
            else if (score >= 80)
                grade = "B";
            else if (score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else 
                grade = "F";
            Console.WriteLine("학점은 {0}", grade);

            switch (score / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("학점은 {0}", grade);  // shift + 엔터로 줄 넘기기 


            }


        }
    }
}
