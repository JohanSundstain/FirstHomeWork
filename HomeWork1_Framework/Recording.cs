using System.Collections.Generic;

namespace HomeWork1_Framework
{
    class Recording
    {
        private int _id;
        private string _data;

        private List<Product> _products;

        public Recording(string data)
        {
            this._id = data[0] - 48;
            this._data = data.Remove(0, 1);
            Parsing();
        }

        private void Parsing()
        {
            _products = new List<Product>();
            _data = _data.Replace("\t", "");
            _data = _data.Replace("[", "");
            _data = _data.Replace("]", "");
            string[] str = _data.Split('\n');
            foreach (var prod in str)
            {
                string s = prod.Replace("\r", "");
                if (s != "")
                {
                    string[] NAP = s.Split(',');
                    string name = NAP[0].Split('=')[1];
                    int price = 0;
                    try
                    {
                        price = int.Parse(NAP[1].Split('=')[1]);
                        _products.Add(new Product(name, price));
                    }
                    catch { }
                }
            }
        }

        public int FullPrice()
        {
            int sum = 0;
            foreach (var p in _products)
            {
                sum += p._price;
            }

            return sum;
        }
    }
}