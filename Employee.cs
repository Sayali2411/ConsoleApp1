using System;


namespace ConsoleApp1
{
    public class Employee
    {
        private string name;
        private int id;

        public int Id { get; set; }

        public string Name { get; set; }
    }
    public class User : Employee
    {
        private string designation;

        public string Designation { get; set; }

        public static void Main(string[] args)
        {
            Employee usr = new Employee();
            usr.Id = 10;
            usr.Name = "Anita";

            User e1 = new User();
            e1.Id = 29;
            e1.Name = "Tom";
            e1.Designation = "Professor";

            Console.WriteLine("Employee's Name is :" + e1.Name);
            Console.WriteLine("Employee's Id is :" + e1.Id);
            Console.WriteLine("Employee's Designation is :" + e1.Designation);
            Console.ReadKey();
        }
    }
}


    

