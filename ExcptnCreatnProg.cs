using System;


namespace ConsoleApp1
{
    class ExcptnCreatnProg
    {
        public void nullArrayExcptn()
        {
            try
            {
                int x = 15 / Convert.ToInt32("0");
                Console.WriteLine(x);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("final block will definitely execute even catch is present or not");
            }
            Console.ReadKey();
        }
        public static void Main()
        {
            ExcptnCreatnProg obj = new ExcptnCreatnProg();
            obj.nullArrayExcptn();
        }
    }
}
