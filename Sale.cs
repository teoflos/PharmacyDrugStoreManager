using System;

namespace PharmacyDrugStoreManager
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale()
        {
            Id = 0;
            CustomerId = 0;
            ItemId = 0;
            Quantity = 0;
            TotalPrice = 0;
            SaleDate = DateTime.Now;
        }

        public Sale(int id, int customerId, int itemId, int quantity, double totalPrice)
        {
            Id = id;
            CustomerId = customerId;
            ItemId = itemId;
            Quantity = quantity;
            TotalPrice = totalPrice;
            SaleDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Id},{CustomerId},{ItemId},{Quantity},{TotalPrice},{SaleDate}";
        }
    }
}