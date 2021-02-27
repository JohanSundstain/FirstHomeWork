using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Framework
{
    class File
    {
        private string[] _data;
        private List<Recording> _recordings;

        public File(String[] str)
        {
            _data = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(str[i]))
                    {
                        _data[i] = reader.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            Parsing();
        }

        public void Parsing()
        {
            _recordings = new List<Recording>();
            foreach (var str in _data)
            {
                string[] stringSeparator = new string[] { "Id=" };
                string[] s = str.Split(stringSeparator,StringSplitOptions.None);
                foreach (var c in s)
                {
                    if (!c.Equals(""))
                    {
                        _recordings.Add(new Recording(c));
                    }
                }
            }
        }

        public int FullPrice()// Подсчёт суммы 
        {
            int sum = 0;
            foreach (var r in _recordings)
            {
                sum += r.FullPrice();
            }

            return sum;
        }
    }
}
