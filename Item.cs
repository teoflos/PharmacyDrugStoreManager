namespace PharmacyDrugStoreManager
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public Item()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Quantity = 0;
            Category = "";
        }

        public Item(int id, string name, double price, int quantity, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Price},{Quantity},{Category}";
        }
    }
}