using System;

namespace ConsoleApp1
{
   abstract public class AbstractionConcept
    {
        public abstract void abstrct();
        //{
        //  Console.WriteLine("Hello);
        //}
        public double area;

        //public abstract double Area { get; set; }

        public abstract double Area
        {
            get;
        }
        //{
        //     return area;
        //}

        //set
        //{
        //     area = value;
        //}
    }
    public class Childabstract : AbstractionConcept
    {
        public override void abstrct()
        {
            Console.WriteLine("Hello");
        }
        public override double Area
        {
            get { return area; }
        }
    }
    class AbstractImplementation
    {
        public static void Main()
        {
           
            Childabstract obj = new Childabstract();
            obj.abstrct();
        }
    }
}
   



      


          
            
       
            
    

