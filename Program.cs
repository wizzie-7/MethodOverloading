using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadingMethod OM = new OverloadingMethod();
            OM.add(20, 30);
            OM.add(20, 30, 40);
            OM.add(20, 15.7f);
            OM.add(20.5f, 30.5f);
        }
    }
    public class OverloadingMethod
    {
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("1st Sum is :" + sum);
        }
        public void add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("2nd Sum is :" + sum);
        }
        public void add(int a, float b)
        {
            float sum = a + b;
            Console.WriteLine("2rd Sum is :" + sum);
        }
        public void add(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine("4th Sum is :" + sum);
        }
    }
}
