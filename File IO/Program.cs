using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace File_IO
{
    class Program
    {
        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Det här är sparat även när programmet stängs ned.");
        }
        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }
        static void Main(string[] args)
        {
            string Filename = @"C:\test\IO.txt";
            WriteFile(Filename);
            ReadFile(Filename);
        }
    }
}
