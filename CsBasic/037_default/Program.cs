using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_default // C# 에서는 초기화 되지 않은 변수를 사용할 수 없음 
{
    class Program
    {
        enum E { Red, Green, Blue };

        static void Main(string[] args)
        {
            int a = default; // 0 
            string s = default; // 문자열은 null로 초기화 , 언어 버전 7.1 부터 (프로젝트 속성-> 빌드-> 고급) 
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s); // null 

            Console.WriteLine("E = " + default(E)); // enum 의 초기화 : 첫번째 값 
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList: " + iList.GetLast()); // GetLast : 마지막 노드의 데이터값 / Mylist가 비어있으면 data의 디폴트 = 0값 

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("istring: " + sList.GetLast()); // Mylist가 비어있으면 data의 디폴트 = null값 

        }
    }
    public class MyList<T> // 클래스 정의 
    {
        private class Node // 노드 생성 
        {
            public T data;
            public Node next; 
        }
        private Node head = default; 

        public void AddNode(T t) // data 를 t로 하는 노드를 만들어 맨 앞에 추가 
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode; 
        }
        public T GetLast()
        {
            T temp = default(T);

            Node current = head; 
            while (current != null)
            {
                temp = current.data;
                current = current.next; 
            }
            return temp; 
        }
    }
    

    
}
