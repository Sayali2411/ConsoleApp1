using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DictnrySortedLst
    {
        public void SortedLstMethod()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Second", "Two");
            mySL.Add("First", "One");
            mySL.Add("Thirdh", "!");
            mySL.Add("Forth", "Two");

            Console.WriteLine("Keys and Values:");

            IDictionaryEnumerator myEnumerator = mySL.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine("\t{0}:", myEnumerator.Key, myEnumerator.Value);
                Console.WriteLine();
            }
            Console.WriteLine("Value for Key 'Third' is" + mySL["Third"].ToString());
            Console.ReadKey();
        }

        class DictnrySortedEx
        {
            public static void Main(string[] args)
            {
                DictnrySortedLst obj = new DictnrySortedLst();
                obj.SortedLstMethod();
                Console.ReadKey();
            }
        }
    }
}

        