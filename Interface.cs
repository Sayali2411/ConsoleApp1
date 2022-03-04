using System;


namespace ConsoleApp1
{
    interface ICanFight
    {
        void Fight();
    }

    interface ICanSwim
    {
        void Swim();
    }
    interface ICanJump
    {
        void Jump();

    }
    class ActionStar : ICanFight
    {
        public void Fight()
        {
            Console.WriteLine("Action Star can Fight");
        }
    }
    class Hero : ActionStar, ICanSwim, ICanJump
    {
        public void Swim()
        {
            Console.WriteLine("Hero can Swim");
        }
        public void Jump()
        {
            Console.WriteLine("Hero can Jump");
        }
    }
    class Interface
    {
        public static void Main()
        {
            ActionStar objA = new ActionStar();
            objA.Fight();
            Hero objH = new Hero();
            objH.Fight();
            objH.Jump();
            objH.Jump();

            ICanSwim ICW = new Hero();
            ICW.Swim();
            Console.ReadKey();
        }
    }
}


        
