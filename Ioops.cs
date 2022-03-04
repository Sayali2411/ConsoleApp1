using System;
using System.IO;


namespace ConsoleApp1
{
    class Ioops
    {
        public static void Main()
        {
            using (FileStream fs = new FileStream(@"C:\Test\SampleFile.txt", FileMode.OpenOrCreate, FileAcccess.ReadWrite))
            {
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);

                m_streamWriter.WriteLine("Fil Write OPeration Starts :");
                m_streamWriter.WriteLine("Welcome to the Sample file");
                m_streamWriter.WriteLine("This is next line in the text file");

                m_streamWriter.Flush();
            }
            StreamReader m_streamReader = new StreamReader(@"C:\Test\SampleFile.txt");
            string str;
            while ((str = m_streamReader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
