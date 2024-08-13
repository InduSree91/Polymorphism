using System;
// Method Overloading
namespace Polymorphism
{
    class Program
    {
        public void Add()
        {   
            int a = 12;
            int b = 13;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(string a, string b)
        {
            string c = a + b;
            Console.WriteLine(c);
        }

        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
                        
            p.Add();
            p.Add(2, 4);
            p.Add("Hello", " World!");
            p.Add(2.34F, 9.36F);
        }
    }
}