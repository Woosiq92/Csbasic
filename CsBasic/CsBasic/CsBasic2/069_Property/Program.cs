using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_Property
{
    class Rectangle // 속성을 사용하지 않은 정의 
    {
        private double width;
        private double height; 

        public double GetWidth()
        {
            return width; 
        }

        public double GetHeight()
        {
            return height; 
        }

        public void Setwidth (double width) // setter 
        {
            if (width > 0)
                this.width = width; // this 키워드 : 매개변수와 필드 이름이 같은 경우에 서로 구분하기 위해 사용 
        }

        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height; 
        }
    }

    class RectWithProp // prop 을 치고 tap 을 두번 누르면 나타내는 코드 조각을 바꾸어 만들어줌 
    {
        public double width { get; set; } // width 속성 
        public double Height { get; set; } // Height 속성 
    }

    class RectWithPropFull 
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }

        private double height;
        public double Height
        {
            get { return height;  }
            set { if (value >= 0) height = value; }
        }
    }
    
    class PropertyTest
{
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Setwidth(10.0);
            r.SetHeight(10.0);
            Console.WriteLine("r의 면적은 {0}", r.GetWidth() * r.GetHeight());

            RectWithProp r1 = new RectWithProp();
            r1.width = 10.0;
            r1.Height = 10.0;
            Console.WriteLine("r1의 면적은 {0}", r1.width * r1.Height);

            RectWithPropFull r2 = new RectWithPropFull();
            r2.Width = 10.0;
            r2.Height = 10.0;
            Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height);

            RectWithPropFull r3 = new RectWithPropFull();
            r3.Width = 10.0;
            r3.Height = -10.0;
            Console.WriteLine("r3의 면적은 {0}", r3.Width * r3.Height); 
        }
    }
}
