using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryInfoCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }


                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        } 
    }
}
