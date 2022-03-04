using System;

namespace ConsoleApp1
{
    class StudentRank_IFelseExample
    {
        public void ElseIFLadder()
        {
            Console.WriteLine("Enter Mark 1:");
            int m1 = Convert.ToInt32(Console.ReadLine());

            if (m1 >= 40)
            {
                Console.WriteLine("\nResult: PASS");

                Console.WriteLine("\nTotal Marks: {0}", m1);

                double percentage = m1;
                Console.WriteLine("\nPercentage: {0}", percentage);

                String resultClass = string.Empty;
                if (percentage >= 40 && percentage <= 49.99)
                {
                    resultClass = "Third";
                }
                else if (percentage >= 50 && percentage <= 59.99)
                {
                    resultClass = "Second";
                }
                else if (percentage >= 60 && percentage <= 74.99)
                {
                    resultClass = "First";
                }
                else if (percentage >= 75)
                {
                    resultClass = "Distinction";
                }
                else
                {
                    Console.WriteLine("\nClass: {0}", resultClass);


                    Console.WriteLine("\nResult: FAIL");
                }
            }
        }

        public void switchcase()
        {
            int cashPrize = 0;
            string resultClass = "First";
            switch (resultClass)
            {
                case "Third":
                    cashPrize = 500;
                    break;

                case "Second":
                    cashPrize = 500;
                    break;

                case "First":
                    cashPrize = 500;
                    break;

                case "Distinction":
                    cashPrize = 500;
                    break;

                default:
                    Console.WriteLine("\nCash Prize: {0}", cashPrize);
                    break;
            }
        }
        public class Sayali
        {
            public static void Main(String[] Args)
            {
                StudentRank_IFelseExample obj = new StudentRank_IFelseExample();
                obj.ElseIFLadder();
                obj.switchcase();

                Console.ReadKey();
            }

        }
    }
}
                    

                
            




            

