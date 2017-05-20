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
                Console.Write(file.FullName);
                StreamReader sr = new StreamReader(file.FullName+" ");
                string s = sr.ReadToEnd();
                char b=' ';
                string ss="";
                foreach (char c in s)
                {
                    if (b == ' ') {
                        int n = int.Parse(ss);
                        int m = 1;
                        for (int i = 1; i <= 15; i++)
                        {
                            if (m == n)
                            {
                                Console.Write(m.ToString()+ " ");
                            }
                            m *= 2;
                        }
                            ss = ""; 
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
            }
        }
    }
}
