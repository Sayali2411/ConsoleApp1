using System;


namespace ConsoleApp1
{
    class ArrayAddition
    {
        public void matrixAddition()
        {
            int[,] a = new int[3, 3];
            int[,] c = new int[3, 3];

            Console.WriteLine("Enter Element into the first array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] b = new int[3, 3];
            Console.WriteLine("Enter Element into second array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Sum of two matrices");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + "/n");
                }
                Console.WriteLine();
            }
        }
        public static void Main(String[] Args)
        {
            ArrayAddition obj = new ArrayAddition();
            obj.matrixAddition();
            Console.ReadKey();
        }
    }
}



        







        