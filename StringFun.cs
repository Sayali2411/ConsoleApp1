using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringFun
    {
        public static void Main(string[] args)
        {
            string firstname = "John Williams";
            string lastname = "Williams";
            string Lastname = "Williams";
            Console.WriteLine(lastname.CompareTo(lastname));

            Console.WriteLine(firstname.Contains("ohn"));
            Console.WriteLine(firstname.EndsWith("n"));
            Console.WriteLine(firstname.Equals(lastname));

            Console.WriteLine(firstname.IndexOf("n"));
            Console.WriteLine(firstname.ToLower());
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(firstname.Insert(0, "Hello "));

            Console.WriteLine(firstname.Length);
            Console.WriteLine(firstname.Remove(3));
            Console.WriteLine(firstname.Replace('1', 'x'));

            string[] split = firstname.Split(new char[] { 'i' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("j"));
            Console.WriteLine(firstname.Substring(2, 5));

            string details = "Employee Details";
            int salary = 20000;
            DateTime doj = new DateTime(2010, 1, 12);
            string result = string.Format("{0}: {1:0,0} - {2:yyyy}", details, salary, doj);
            Console.WriteLine(result);
            Console.WriteLine(firstname.ToCharArray());
            Console.WriteLine(firstname.Trim());
            Console.ReadKey();
        }
    }
}





    

