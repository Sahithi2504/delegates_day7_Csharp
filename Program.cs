using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract Result: {0}", a - b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply Result: {0}", a * b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Delegate Example****");
            MathOperations m = new MathOperations();

            SampleDelegate dlgt = m.Add;
            dlgt(100, 100);

            dlgt = m.Subtract;
            dlgt(100, 90);

            dlgt = m.Multiply;
            dlgt(10, 2);

            Console.ReadLine();

        }
    }






    //-----------multi-cast delegate-----------





    public delegate void rectDelegate(int height, int width);
    class rectangle
    {
        public void area(int height, int width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        public void perimeter(int height, int width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

        public static void Main(String[] args)
        {
            rectangle rect = new rectangle();
            rectDelegate rectdele = new rectDelegate(rect.area);
            rectdele += rect.perimeter;
            rectdele.Invoke(6, 4);
            rectdele.Invoke(3, 3);
            Console.ReadLine();
        }
    }





    //---------------Passing delegate as a parameter-------------

    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract Result: {0}", a - b);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Delegate Example****");
            MathOperations m = new MathOperations();
            SampleMethod(m.Add, 100, 90);
            SampleMethod(m.Subtract, 100, 90);
            Console.ReadLine();
        }
        static void SampleMethod(SampleDelegate dlgt, int a, int b)
        {
            dlgt(a, b);
        }
    }

}
