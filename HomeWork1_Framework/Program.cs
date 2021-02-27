using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"C:\Users\Johan\RiderProjects\HomeWork1\files")
                .Where(c => c.EndsWith("txt"));

            string[] str = new string[files.Count()];
            int i = 0;

            foreach (var file in files)
            {
                str[i++] = file;
            }

            File pr = new File(str);

            Console.WriteLine(pr.FullPrice());
            Console.ReadLine();

        }
    }
}
