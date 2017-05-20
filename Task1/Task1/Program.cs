using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo papka = new DirectoryInfo(@"C:\Users\a_krekesova\Desktop\Task1");
            FileInfo[] files = papka.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.Write(file.Name + " ");
                StreamReader sr = new StreamReader(file.FullName);
                string s = sr.ReadToEnd();
                char b=' ';
                string ss="";
                foreach (char c in s)
                {
                    if (b == ' ' && ss.Length>0) {
                       // Console.WriteLine(ss);
                        //Console.ReadKey();
                        int n = int.Parse(ss);
                        int m = n;
                        while (m % 2 == 0) { m /= 2; }
                        if (m == 1) Console.Write(n.ToString() + " ");
                       
                    }
                    else
                    {
                        if (c >= '0' && c <= '9')
                        {
                            ss += c;
                        }
                    }
                    b = c;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
