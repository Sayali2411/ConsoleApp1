using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DictionaryHashTable
    {
        public void HashTableMethod()
        {
            HashTable myHT = new HashTable();
            myHT.Add("First", "c#");
            myHT.Add("Second", 3);
            myHT.Add("Third", "C++");
            myHT.Add("Fourth", "Two");
            myHT.Add("Fifth", "One");

            Console.WriteLine("Keys and Values:");
            // PrintKeysAndValues(myHT);

            Console.WriteLine("Values for key 'Second' is" + myHT["Second"]);
        }
        public void PrintKeysAndValues(Hashtable myList)
        {
            IDictionaryEnumerator myEnumerator = myList.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine("\t{0}:\t{1}", myEnumerator.Key, myEnumerator.Value);
            }
            Console.WriteLine();
        }
    }
    class DictionaryHashTableEx
    {
        public static void Main(string[] args)
        {
            DictionaryHashTable obj = new DictionaryHashTable();
            obj.HashTableMethod();
            Console.ReadKey();
        }
    }
}

        
    

            
        

