using System;

namespace ConsoleApp1
{
    class Opr
    {
        public void UnaryOperator()
        {
            int x = 10;


            System.Console.WriteLine("incrementing/decrementing....");
            Console.WriteLine("\n\n Initial x value:" + x + " \n \n");

            System.Console.WriteLine("Pre incrementing: (++x)" + ++x);
            Console.WriteLine("pre Inicrement Result: (x)" + x);

            System.Console.WriteLine("\nPre Decrement: (--x)" + --x);
            Console.WriteLine("Pre Decrement Result: (x)" + x);

            System.Console.WriteLine("/nPost Increment: (x++)" + x++);
            Console.WriteLine("Post Increment Result: (x)" + x);

            System.Console.WriteLine("\n\nSetting signs...");
            Console.WriteLine(+x);
            Console.WriteLine(-x);

            Console.ReadKey();
        }

        public void RelationalOperator()
        {
            int a = 10;
            int b = 20;

            Boolean GreaterThan = a > b;
            Console.WriteLine(GreaterThan);

            Boolean LessThan = a < b;
            Console.WriteLine(LessThan);

            string name1 = "Marlon"; int weight1 = 140, height1 = 74;
            string name2 = "Katie"; int weight2 = 124, height2 = 78;

            Boolean isLight = weight1 < weight2, isLightEq = weight1 <= weight2;

            System.Console.WriteLine("Is " + name1 + " lighter than " + name2 + "? " + isLight);
            System.Console.WriteLine("Is " + name1 + " lighter or same weight as " + name2 + "? " + isLight);

            Boolean isTall = height1 < height2, isTallEq = height1 <= height2;

            System.Console.WriteLine("Is " + name1 + " taller than " + name2 + "? " + isTall);
            System.Console.WriteLine("Is " + name1 + " taller or same height as " + name2 + "? " + isTallEq);

            System.Console.WriteLine("So who is heavier?");
            System.Console.WriteLine("And who is taller?");
            Console.ReadKey();
        }

        public void ConditionalOperator()
        {
            int yyyy = 1981;
            int mm = 10;
            int dd = 22;
            String mmm = mm == 1 ? "Jan" : mm == 2 ? "Feb" : mm == 3 ? "Mar" : mm == 4 ? "Apr" : mm == 5 ? "May" : mm == 6 ? "June" :
                mm == 7 ? "Jul" : mm == 8 ? "Aug" : mm == 9 ? "Sep" : mm == 10 ? "Oct" : mm == 11 ? "Nov" : mm == 12 ? "Dec" : "unknown";
            System.Console.WriteLine("I was born on " + mmm + " " + dd + ", " + yyyy);
            Console.ReadKey();
        }


        public static void main(String[] Args)
        {
            Opr obj = new Opr();
            obj.UnaryOperator();
            obj.RelationalOperator();
            obj.ConditionalOperator();
        }

    }
}  


