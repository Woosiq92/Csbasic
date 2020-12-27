using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_null
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다. ");
            do
            {
                LongNameAnimal(animal);
                Console.WriteLine(" 동물 이름 : ");
                break;
            } while ((animal = Console.ReadLine()) != "");

            //038 Nullabe : 값 형식의 변수에 null을 할당 할 수 있게 한다.
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault()); // i가 null 일떄 default인 0 출력 

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("NULL");

            int? x = null;
            int j = x ?? 0; // non-Nullable에 할당 , x가 null이 아니면 x값을, null일때는 0할당 
            Console.WriteLine("x = {0}, j = {1}", x, j); // null이면 아무값도 출력하지 않음 

            Console.WriteLine("x >= 10 ? {0}", x >= 10); // nullable 변수는 non-nullable 변수와 직접 비교할수 없어 false 출력 
            Console.WriteLine("x < 10 ? {0}", x < 10);

            if (Nullable.Compare<int>(i, j) < 0) // Nullable 변수를 비교할때는 Compare 메소드 사용 , null 값은 모든 숫자보다 낮다.
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i> j");
            else
                Console.WriteLine(" i = j");
        }
        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4) // 값이 null일때는 length 를 찾지 않는다. 
                Console.WriteLine(animal + " : " + animal.Length);
            
        }
    }
    
}
