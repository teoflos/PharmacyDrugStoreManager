using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PharmacyDrugStoreManager
{
    public class DrugStoreManager
    {
        private List<Customer> customers = new List<Customer>();
        private List<Item> items = new List<Item>();
        private List<Sale> sales = new List<Sale>();
        private int nextCustomerId = 1;
        private int nextItemId = 1;
        private int nextSaleId = 1;
        private string dataFile = "data.txt";

        public DrugStoreManager()
        {
            LoadData();
        }

        public void LoadData()
        {
            if (File.Exists(dataFile))
            {
                try
                {
                    string[] lines = File.ReadAllLines(dataFile);
                    customers.Clear();
                    items.Clear();
                    sales.Clear();

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts[0] == "CUSTOMER")
                        {
                            string[] data = parts[1].Split(',');
                            Customer c = new Customer(
                                int.Parse(data[0]),
                                data[1],
                                data[2],
                                data[3]
                            );
                            customers.Add(c);
                            if (c.Id >= nextCustomerId) nextCustomerId = c.Id + 1;
                        }
                        else if (parts[0] == "ITEM")
                        {
                            string[] data = parts[1].Split(',');
                            Item i = new Item(
                                int.Parse(data[0]),
                                data[1],
                                double.Parse(data[2]),
                                int.Parse(data[3]),
                                data[4]
                            );
                            items.Add(i);
                            if (i.Id >= nextItemId) nextItemId = i.Id + 1;
                        }
                        else if (parts[0] == "SALE")
                        {
                            string[] data = parts[1].Split(',');
                            Sale s = new Sale(
                                int.Parse(data[0]),
                                int.Parse(data[1]),
                                int.Parse(data[2]),
                                int.Parse(data[3]),
                                double.Parse(data[4])
                            );
                            sales.Add(s);
                            if (s.Id >= nextSaleId) nextSaleId = s.Id + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        public void SaveData()
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (Customer c in customers)
                    lines.Add("CUSTOMER|" + c.ToString());
                foreach (Item i in items)
                    lines.Add("ITEM|" + i.ToString());
                foreach (Sale s in sales)
                    lines.Add("SALE|" + s.ToString());
                File.WriteAllLines(dataFile, lines);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        public List<Customer> GetAllCustomers() => customers;
        public List<Item> GetAllItems() => items;
        public List<Sale> GetAllSales() => sales;

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }

        public Item GetItemById(int id)
        {
            return items.FirstOrDefault(i => i.Id == id);
        }

        public void AddCustomer(string name, string phone, string address)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[0-9]+$"))
            {
                throw new Exception("Phone number must contain only digits!");
            }
            customers.Add(new Customer(nextCustomerId++, name, phone, address));
            SaveData();
        }
        public void AddItem(string name, double price, int quantity, string category)
        {
            items.Add(new Item(nextItemId++, name, price, quantity, category));
            SaveData();
        }

        public void AddSale(int customerId, int itemId, int quantity)
        {
            Item item = GetItemById(itemId);
            if (item == null)
            {
                throw new Exception("Item not found!");
            }
            if (item.Quantity < quantity)
            {
                throw new Exception("Not enough stock!");
            }
            double total = item.Price * quantity;
            sales.Add(new Sale(nextSaleId++, customerId, itemId, quantity, total));
            item.Quantity -= quantity;
            SaveData();
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            return customers.Where(c => c.Name.ToLower().Contains(keyword.ToLower()) ||
                                        c.Id.ToString().Contains(keyword)).ToList();
        }

        public List<Item> SearchItems(string keyword)
        {
            return items.Where(i => i.Name.ToLower().Contains(keyword.ToLower()) ||
                                    i.Id.ToString().Contains(keyword)).ToList();
        }

        public List<Customer> SortCustomersByName(bool ascending = true)
        {
            if (ascending)
                return customers.OrderBy(c => c.Name).ToList();
            else
                return customers.OrderByDescending(c => c.Name).ToList();
        }

        public List<Item> SortItemsByName(bool ascending = true)
        {
            if (ascending)
                return items.OrderBy(i => i.Name).ToList();
            else
                return items.OrderByDescending(i => i.Name).ToList();
        }

        public List<Customer> SortCustomersById(bool ascending = true)
        {
            if (ascending)
                return customers.OrderBy(c => c.Id).ToList();
            else
                return customers.OrderByDescending(c => c.Id).ToList();
        }

        public void DeleteCustomer(int id)
        {
            Customer c = GetCustomerById(id);
            if (c != null)
            {
                customers.Remove(c);
                SaveData();
            }
        }

        public void DeleteItem(int id)
        {
            Item i = GetItemById(id);
            if (i != null)
            {
                items.Remove(i);
                SaveData();
            }
        }

        public void UpdateCustomer(int id, string name, string phone, string address)
        {
            Customer c = GetCustomerById(id);
            if (c != null)
            {
                c.Name = name;
                c.Phone = phone;
                c.Address = address;
                SaveData();
            }
        }

        public void UpdateItem(int id, string name, double price, int quantity, string category)
        {
            Item i = GetItemById(id);
            if (i != null)
            {
                i.Name = name;
                i.Price = price;
                i.Quantity = quantity;
                i.Category = category;
                SaveData();
            }
        }

        public double GetTotalRevenue()
        {
            return sales.Sum(s => s.TotalPrice);
        }

        public int GetTotalItemsSold()
        {
            return sales.Sum(s => s.Quantity);
        }

        public List<Item> GetLowStockItems(int threshold = 5)
        {
            return items.Where(i => i.Quantity <= threshold).ToList();
        }
    }
}