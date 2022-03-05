using System;

namespace FuncoesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHI abc DEF   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);

            string s6 = original.Replace('a', 'x');
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: " + "-" +original + "-");
            Console.WriteLine("To Upper: " + "-" + s1 + "-");
            Console.WriteLine("To Lower: " + "-" + s2 + "-");
            Console.WriteLine("Trim: " + "-" + s3 + "-");
            Console.WriteLine("IndexOf bc: " + "-" + n1 + "-");
            Console.WriteLine("LastOf bc: " + "-" + n2 + "-");
            Console.WriteLine("Substring: " + "-" + s4 + "-");
            Console.WriteLine("Substring: " + "-" + s5 + "-");
            Console.WriteLine("Replace: " + "-" + s6 + "-");
            Console.WriteLine("IsnullOrEmpty: " + "-" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: " + "-" + b2 + "-");
        }
    }
}
