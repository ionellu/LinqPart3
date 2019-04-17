namespace LinqPart3
{
    public class Product
    {
        public string Name;
        public int Quantity;

        public Product(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product other))
                return false;
            return this.Name == other.Name && this.Quantity == other.Quantity;
        }
    }
}