using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSploit.Tools
{
    internal class Spoof
    {
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
        public static string Extension(string file, string extension)
        {
            string reverseChar = "\u202E";
            var Spoofed = Path.GetFileNameWithoutExtension(file) + reverseChar + ReverseString(extension) + Path.GetExtension(file);
            Console.WriteLine($"Chaning FileName To {Path.GetFileNameWithoutExtension(file)}exe.{extension}");
            return Spoofed;

        }
    }
}
