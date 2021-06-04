using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileExists();
            //ReadAllLines();
            //ReadAllText();
            //FileCopy();
            //DeleteFile();
            ReadFromStreamReader();
            Console.ReadKey();
        }

        public static void FileExists()
        {
            String path = @"C:\Users\HP\source\repos\FileIO\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\HP\source\repos\FileIO\Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = @"C:\Users\HP\source\repos\FileIO\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            string path = @"C:\Users\HP\source\repos\FileIO\Example.txt";
            string copypath = @"C:\Users\HP\source\repos\FileIO\NewExample.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\HP\source\repos\FileIO\Example.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\HP\source\repos\FileIO\Demo.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\HP\source\repos\FileIO\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }



}
