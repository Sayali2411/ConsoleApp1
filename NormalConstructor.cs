using System;


namespace ConsoleApp1
{
    class NormalConstructor
    {
        public int x = 10;

        public NormalConstructor()
        {
            Console.WriteLine(++x);
            Console.WriteLine(x++);
        }

        public NormalConstructor(int a, int b)
        {
            a = 20;
            b = 20;
            Console.WriteLine("Value of a and b is " + a, + b);
        }
        public void Test()
        {

        }
        public void Test1(int a, int b)
        {
            a = 10;
            b = 20;
            int res = a + b;
        }
        public int Display()
        {
            Console.WriteLine(++x);
            Console.WriteLine(x++);
            return x;
            //Console.ReadLine();
        }
    }
    class NormalConstructorProgram
    {
         public static void Main(String[] Args)
        {
            NormalConstructor obj = new NormalConstructor();
            NormalConstructor obj1 = new NormalConstructor(2, 3);
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            obj.Test1(a, b);
            obj.Display();
            //obj.Display();
            Console.ReadKey();
        }
    }
}

       




        
    

