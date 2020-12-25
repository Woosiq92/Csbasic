using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World!";
            string t;

            Console.WriteLine(s.Length); // 문자열의 길이 출력 
            Console.WriteLine(s[8]); // 인덱스 값으로 출력 
            Console.WriteLine(s.Insert(8, "C#")); // 특정 위치에 문자열 삽입 
            Console.WriteLine(s.PadLeft(20, '.')); // 특정 문자를 넣어서 문자열의 길이를 맞춤 
            Console.WriteLine(s.PadRight(20, '.')); // 특정 문자를 넣어서 문자열의 길이를 맞춤 
            Console.WriteLine(s.Remove(6)); // 6번째부터 끝까지 지워줌 
            Console.WriteLine(s.Remove(6, 7)); // 6번째부터 7개의 문자를 지워줌 
            Console.WriteLine(s.Replace('l', 'm')); // l 을 m 으로 바꾸어 줌 
            Console.WriteLine(s.ToLower()); // 소문자로 
            Console.WriteLine(s.ToUpper()); // 대문자로 
            Console.WriteLine('/' + s.Trim() + '/');  // 앞뒤의 공백 문자를 없애고 
            Console.WriteLine('/' + s.TrimStart() + '/'); // 앞쪽의 공백문자를 없앰 
            Console.WriteLine('/' + s.TrimEnd() + '/'); // 뒤쪽의 공백 문자를 없앰 

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/'); 

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6); // Copyto : string의 일부분을 문자 배열로 저장, 8번째 인덱스로부터 destination[] 배열의 0번 인덱스로 6개의 문자를 복사 
            Console.WriteLine(destination);
            Console.WriteLine('/' + s.Substring(8) + '/'); // 8번째 인덱스부터 맨 뒤까지 문자열을 리턴
            Console.WriteLine('/' + s.Substring(8, 5) + '/'); // 8번째 인덱스부터 5개 문자열을 리턴

            Console.WriteLine(s.Contains("ll")); // ll 라는 문자열이 있으면 true 리턴 
            Console.WriteLine(s.IndexOf('o')); // 처음 나오는 o의 위치 리턴
            Console.WriteLine(s.LastIndexOf('o')); // 마지먹 나오는 o의 위치 리턴 
            Console.WriteLine(s.CompareTo("abc")); // s가 abc 보다 앞에 나오면 - 값,  같으면 0, 뒤에나오면 + 값 리턴 

            Console.WriteLine(String.Concat("Hi~", s)); // 정적 메소드(String 사용 ) , 두개의 string 합침 
            Console.WriteLine(String.Compare("abc", s)); // a가 빈칸보다 뒤에 나오므로 +1 출력 
            Console.WriteLine(t = String.Copy(s)); // 35번 줄 

            String[] val = { "apple", "orrange", "grape", "pear" }; // 배열 var를 선언하고 초기화 
            String result = String.Join(", ", val); // 배열 각 요소를 "," 으로 연결하여 리턴 
            Console.WriteLine(result); 
        }
    }
}
