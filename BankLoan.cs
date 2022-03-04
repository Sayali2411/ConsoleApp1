using System;


namespace ConsoleApp1
{
    class BankLoan
    {
        double totalamount;

        public virtual double TotalAmount(double amount)
        {
            return totalamount = amount;
        }
        public virtual double TotalAmount(double amount, double intrest)
        {
            totalamount = amount + intrest;
            return totalamount;
        }
    }

    class PersonalLoan : BankLoan
    {
        double amount;
        double totalamount;

        public override double TotalAmount(double amount)
        {
            this.amount = amount + 25.00;
            return this.amount;
        }
    }

    class FunOverriding
    {
        public static void Main(string[] args)
        {
            BankLoan l1 = new BankLoan();
            PersonalLoan l2 = new PersonalLoan();
            BankLoan l3 = new PersonalLoan();

            Console.WriteLine(l1.TotalAmount(1000.00));
            Console.WriteLine(l2.TotalAmount(1000.00));
            Console.WriteLine(l3.TotalAmount(1000.00, 50.00));
            Console.WriteLine(l3.TotalAmount(1000.00));
            Console.ReadKey();
        }
    }
}
        

        

   