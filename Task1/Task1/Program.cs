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
                string ss="";
                foreach (char c in s)
                {
                    if ((c<'0'||c>'9') && ss.Length>0) {
                        int n = int.Parse(ss);
                        int m = n;
                        while (m % 2 == 0 && m!=0) m /= 2; 
                        if (m == 1) Console.Write(ss + " ");
                        ss = "";                     
                    }
                    else
                    {
                        if (c >= '0' && c <= '9')
                        {
                            ss += c;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
