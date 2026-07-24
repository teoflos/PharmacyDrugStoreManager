namespace PharmacyDrugStoreManager
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            Id = 0;
            Name = "";
            Phone = "";
            Address = "";
        }

        public Customer(int id, string name, string phone, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Phone},{Address}";
        }
    }
}