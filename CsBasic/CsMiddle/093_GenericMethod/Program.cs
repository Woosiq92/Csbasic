using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _093_GenericMethod // 일반화 메소드(=제네릭 메소드) : 데이터 형식을 일반화하는 기법 
{
    // 094_GenericClass 
    class MyClass<T> // 객체 생성시에 그 멤버의 형 결정 
    {
        private T[] arr; // 배열형 
        private int count = 0; 

        public MyClass(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert(params T[] args) // param 같은 형이지만 숫자가 다른 매개변수 전달 가능 
        {
            for (int i = 0; i < args.Length; i++)
                arr[i] = args[i];
        }

        public void Print()
        {
            foreach (T i in arr)
                Console.Write(i + "");
            Console.WriteLine();
        }

        public T AddAll()
        {
            T sum = default(T); // 초기화 , T 가 어떤 형일지 모르기때문에 덧셈이 불가능 
            foreach (T item in arr)
                sum = sum + (dynamic)item; // dynamic : 숫자나 문자를 +로 연산가능 , 형 상관 없이 컴파일 
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
            {
                int[] a = { 1, 2, 3 };
                double[] d = { 0.1, 0.2, 0.3 };
                string[] s = { "tiger", "lion", "zebra" };

                PrintArray<int>(a);
                PrintArray<double>(d);
                PrintArray<string>(s);

                MyClass<int> a1 = new MyClass<int>(10);
                MyClass<string> s1 = new MyClass<string>(5);

                a1.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
                s1.Insert("Tiger", "Lion", "Zebra", "Monkey", "Cow");

                a1.Print();
                s1.Print();

                Console.WriteLine("a.AddAll() : " + a1.AddAll());
                Console.WriteLine("s.AddAll() : " + s1.AddAll()); 
            }

        // 일반화 메소드 
        private static void PrintArray<T>(T[] a) // T = type -> 형식 일반화 
        {
            foreach (var item in a)
                Console.Write("{0,8}", item);
            Console.WriteLine();
        }
    }
}
