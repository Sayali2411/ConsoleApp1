using System;


namespace ConsoleApp1
{
    class ArrayAssignment
    {
        public void AssigningArray()
        {
            int[] arr = new int[5];

            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            int[] copyarray = new int[] { 1, 3, 5, 7, 9 };

            arr = copyarray;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}

class TwoDIMArray
{
    public void TwoDimensnArray()
    {
        int[,] a = new int[5, 2]
        {
                    { 0, 0 }, { 1,2 },{ 2, 4 },{ 3, 6},{ 4,8 }
        };

        int i, j;

        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 2; j++)
            {

                Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
            }
            Console.WriteLine();
        }
    }
}








            
        
        
        