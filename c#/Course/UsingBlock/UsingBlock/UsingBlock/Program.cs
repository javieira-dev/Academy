using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\temp\file.txt";
                // using (FileStream fs = new FileStream(path, FileMode.Open)){

                //fazer a instanciação de forma resumida
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
