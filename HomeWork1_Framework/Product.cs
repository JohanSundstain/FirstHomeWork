namespace HomeWork1_Framework
{
    class Product
    {
        public int _price { get; set; }
        public string _name { get; set; }

        public Product(string name, int price)
        {
            this._name = name;
            this._price = price;
        }
    }
}