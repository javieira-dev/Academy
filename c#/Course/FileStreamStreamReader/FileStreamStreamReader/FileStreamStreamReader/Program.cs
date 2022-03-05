using System;
using System.IO;

namespace FileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);

                sr = File.OpenText(path);
                //o open text implicitamente ja instancia o fileStream e instancia o streamReader em cima dele
                //assim não ha necessidade de usar duas variáveis conforme acima
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //precisa fechar as streams, pois são recursos externos, é uma "Conversa com o SO"
            //esse recurso não é gerenciado pelo clr do .net, então precisa fechar o recurso manualmente
            //conforme está no finally
            finally
            {
               // if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
