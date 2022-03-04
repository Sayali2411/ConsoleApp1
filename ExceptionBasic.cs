using System;

namespace ConsoleApp1
{
    class ExceptionBasic
    {
        int result;
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
                Console.WriteLine("final block will definitely execute even catch is present or not");
            }
        }
        static void Main(String[] Args)
        {
            ExceptionBasic obj = new ExceptionBasic();
            obj.division(25, 0);
            Console.ReadKey();
        }

        }
    }

