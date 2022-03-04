using System;
using System.Collections;


namespace ConsoleApp1
{
    class CollectionStack
    {
        public void StackMethod()
        {
            Stack st = new Stack();
            st.Push("A");
            st.Push(1);
            st.Push(2);

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******END LOOP*******");
            Console.WriteLine(st.Pop());
            Console.WriteLine("**********Deleted Element*******");
            foreach (var item in st)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("*********END LOOP******");

            Console.WriteLine("Top most item to be delete" + st.Peek());
        }
    }
    class StackEx
    {
        public static void Main()
        {
            CollectionStack obj = new CollectionStack();
            obj.StackMethod();
            Console.ReadKey();

        }
    }
}

    

