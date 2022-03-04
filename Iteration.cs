using System;


namespace ConsoleApp1
{
    class Iteration
    {
        public void WhileLoop()
        {
            Console.WriteLine("\nWhile Exmple");
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine("****END****");
            Console.ReadLine();
        }

        public void DoWhileLoop()
        {
            Console.WriteLine("\nDo-While Example");
            int b = 1;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b <= 10);
            Console.WriteLine("****END****");
            Console.ReadLine();
         }
        public void ForLoop()
        {
            Console.WriteLine("For Loop Example");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****END****");
            Console.ReadLine();
            }
        public static void main(String[] Args)
        {
            Iteration obj = new Iteration();
            obj.WhileLoop();
            obj.DoWhileLoop();
            obj.ForLoop();
            Console.ReadKey();
        }
     }
}
