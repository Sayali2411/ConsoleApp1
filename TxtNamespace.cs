using System;
using System.Text;



namespace ConsoleApp1
{
    class TxtNamespace
    {
        public static void Main()
        {
            StringBuilder builder = new StringBuilder("Hello Welcome to ATS School!", 30);
            // StringBuilder ds = new StringBuilder("String value", int capacity)

            int cap = builder.EnsureCapacity(55);
            Console.WriteLine(cap);
            builder.Append("This is a sample test");
            Console.WriteLine(builder.ToString());
            builder.Remove(6, 21);
            Console.WriteLine(builder.ToString());
            builder.Replace('!', '?');
            Console.WriteLine(builder.ToString());
            Console.WriteLine("Length of string is:" + builder.Length.ToString());
            Console.WriteLine("Capacity of string is:" + builder.Capacity.ToString());
            Console.ReadKey();
        }
    }
}



        
       
    

