using System;
using System.IO;

namespace WorkingWithFiles3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lucas Ortis\Downloads\file1.txt";


            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred " + e.Message);
            }

            string path2 = @"C:\Users\Lucas Ortis\Downloads\file2.txt";

            try
            {
                using (StreamReader sr2 = File.OpenText(path2))
                {
                    while (!sr2.EndOfStream)
                    {
                        Console.WriteLine(sr2.ReadLine());
                    }
                }
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred " + e.Message);
            }

        }
    }
}
