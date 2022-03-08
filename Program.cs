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





    public delegate void rectDelegate(int l, int b);
    class rectangle
    {
        public void area(int l, int b)
        {
            Console.WriteLine("Area is: {0}", (b * l));
        }
        public void perimeter(int l, int b)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (b + l));
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
