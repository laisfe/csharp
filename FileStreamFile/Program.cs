using System;
using System.IO;

namespace FileStreamFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e);
            }
            finally
            {
                //se for diferente de null indica que está aberto
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
