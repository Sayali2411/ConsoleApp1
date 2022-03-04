using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IListArrayList
    {
        public void ArrayListMethod()
        {
            ArrayList myAL = new ArrayList();

            myAL.Add("ONE");
            myAL.Add("TWO");
            myAL.Add("!");
            myAL.Add(1);
            // myAL.Add(true);

            myAL.Insert(3, false);
            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }

            Console.Write("\t Value at 0 : {0}", myAL[0], ToString());
            Console.WriteLine();

            Console.Write("\t Value at 0 : {0}", myAL[1]);
            Console.WriteLine();

            Console.Write("\t Value at 0 : {0}", myAL[2]);
            Console.WriteLine();
            myAL.RemoveAt(0);
            myAL.Remove("Two");

            myAL.Sort();
            Console.Write("\t value at 3 : {0}", myAL[3]);
            Console.WriteLine();
        }
        class iListArrayEx
        {
            public static void Main()
            {
                IListArrayList obj = new IListArrayList();
                obj.ArrayListMethod();
                Console.ReadKey();
            }
        }
    }
}





