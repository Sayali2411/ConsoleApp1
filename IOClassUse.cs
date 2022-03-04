using System;
using System.IO;


namespace ConsoleApp1
{
    public class IOClassUse
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\test1");

            DirectoryInfo di = new DirectoryInfo(@"C:\test1");

            di.CreateSubdirectory("test2");

            File.Create(@"C:\test1\Sample.txt");

            FileInfo fi = new FileInfo(@"C:\test1\Sample.txt");
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.Extension);

            Console.WriteLine("File has been copied");
            Console.WriteLine("File has been moved");
            Console.ReadKey();
        }
    }
}
