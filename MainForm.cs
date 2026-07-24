using System;
using System.Windows.Forms;

namespace PharmacyDrugStoreManager
{
    public partial class MainForm : Form
    {
        private DrugStoreManager manager;

        public MainForm(DrugStoreManager mgr)
        {
            InitializeComponent();
            manager = mgr;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = manager.GetAllCustomers();
            if (dgvDisplay.Columns.Count > 0)
            {
                dgvDisplay.Columns["Id"].HeaderText = "ID";
                dgvDisplay.Columns["Name"].HeaderText = "Name";
                dgvDisplay.Columns["Phone"].HeaderText = "Phone";
                dgvDisplay.Columns["Address"].HeaderText = "Address";
            }
        }

        private void LoadItems()
        {
            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = manager.GetAllItems();
            if (dgvDisplay.Columns.Count > 0)
            {
                dgvDisplay.Columns["Id"].HeaderText = "ID";
                dgvDisplay.Columns["Name"].HeaderText = "Item Name";
                dgvDisplay.Columns["Price"].HeaderText = "Price";
                dgvDisplay.Columns["Quantity"].HeaderText = "Stock";
                dgvDisplay.Columns["Category"].HeaderText = "Category";
            }
        }

        private void LoadSales()
        {
            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = manager.GetAllSales();
            if (dgvDisplay.Columns.Count > 0)
            {
                dgvDisplay.Columns["Id"].HeaderText = "Sale ID";
                dgvDisplay.Columns["CustomerId"].HeaderText = "Customer ID";
                dgvDisplay.Columns["ItemId"].HeaderText = "Item ID";
                dgvDisplay.Columns["Quantity"].HeaderText = "Quantity";
                dgvDisplay.Columns["TotalPrice"].HeaderText = "Total Price";
                dgvDisplay.Columns["SaleDate"].HeaderText = "Date";
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "What do you want to display?\n\nEnter: customers, items, or sales",
                "Display All", "customers");

            if (choice.ToLower() == "customers")
            {
                LoadCustomers();
                MessageBox.Show("All customers loaded!", "Display All",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (choice.ToLower() == "items")
            {
                LoadItems();
                MessageBox.Show("All items loaded!", "Display All",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (choice.ToLower() == "sales")
            {
                LoadSales();
                MessageBox.Show("All sales loaded!", "Display All",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customers, items, or sales",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisplaySingle_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "What do you want to view?\n\nEnter: customer, item, or sale",
                "Display Single", "customer");

            if (choice.ToLower() == "customer")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Customer ID:", "Display Customer", "1");
                if (int.TryParse(input, out int id))
                {
                    Customer c = manager.GetCustomerById(id);
                    if (c != null)
                    {
                        MessageBox.Show($"ID: {c.Id}\nName: {c.Name}\nPhone: {c.Phone}\nAddress: {c.Address}",
                            "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (choice.ToLower() == "item")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Item ID:", "Display Item", "1");
                if (int.TryParse(input, out int id))
                {
                    Item i = manager.GetItemById(id);
                    if (i != null)
                    {
                        MessageBox.Show($"ID: {i.Id}\nName: {i.Name}\nPrice: ${i.Price}\nStock: {i.Quantity}\nCategory: {i.Category}",
                            "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (choice.ToLower() == "sale")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Sale ID:", "Display Sale", "1");
                if (int.TryParse(input, out int id))
                {
                    var sales = manager.GetAllSales();
                    var sale = sales.Find(s => s.Id == id);
                    if (sale != null)
                    {
                        MessageBox.Show($"Sale ID: {sale.Id}\nCustomer ID: {sale.CustomerId}\nItem ID: {sale.ItemId}\nQuantity: {sale.Quantity}\nTotal: ${sale.TotalPrice}\nDate: {sale.SaleDate}",
                            "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sale not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customer, item, or sale",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "What do you want to add?\n\nEnter: customer, item, or sale",
                "Add New Data", "customer");

            if (choice.ToLower() == "customer")
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Customer Name:", "Add Customer");
                if (!string.IsNullOrEmpty(name))
                {
                    string phone = Microsoft.VisualBasic.Interaction.InputBox("Enter Phone:", "Add Customer");
                    string address = Microsoft.VisualBasic.Interaction.InputBox("Enter Address:", "Add Customer");
                    manager.AddCustomer(name, phone, address);
                    LoadCustomers();
                    MessageBox.Show("Customer added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (choice.ToLower() == "item")
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Item Name:", "Add Item");
                if (!string.IsNullOrEmpty(name))
                {
                    string priceStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Price:", "Add Item");
                    string qtyStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Quantity:", "Add Item");
                    string category = Microsoft.VisualBasic.Interaction.InputBox("Enter Category:", "Add Item");

                    if (double.TryParse(priceStr, out double price) && int.TryParse(qtyStr, out int qty))
                    {
                        manager.AddItem(name, price, qty, category);
                        MessageBox.Show("Item added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid price or quantity!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (choice.ToLower() == "sale")
            {
                string customerIdStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Customer ID:", "Add Sale");
                string itemIdStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Item ID:", "Add Sale");
                string qtyStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Quantity:", "Add Sale");

                if (int.TryParse(customerIdStr, out int customerId) &&
                    int.TryParse(itemIdStr, out int itemId) &&
                    int.TryParse(qtyStr, out int qty))
                {
                    try
                    {
                        manager.AddSale(customerId, itemId, qty);
                        MessageBox.Show("Sale added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customer, item, or sale",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "Search what?\n\nEnter: customer or item",
                "Search", "customer");

            string keyword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Name or ID to search:", "Search");

            if (!string.IsNullOrEmpty(keyword))
            {
                if (choice.ToLower() == "customer")
                {
                    var results = manager.SearchCustomers(keyword);
                    if (results.Count > 0)
                    {
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = results;
                        MessageBox.Show($"Found {results.Count} customers!", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No customers found!", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (choice.ToLower() == "item")
                {
                    var results = manager.SearchItems(keyword);
                    if (results.Count > 0)
                    {
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = results;
                        MessageBox.Show($"Found {results.Count} items!", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No items found!", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid choice! Use: customer or item",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "Sort what?\n\nEnter: customer or item",
                "Sort", "customer");

            string sortChoice = Microsoft.VisualBasic.Interaction.InputBox(
                "Sort by:\n1. Name (Ascending)\n2. Name (Descending)\n3. ID (Ascending)\n4. ID (Descending)",
                "Sort", "1");

            if (choice.ToLower() == "customer")
            {
                switch (sortChoice)
                {
                    case "1":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortCustomersByName(true);
                        break;
                    case "2":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortCustomersByName(false);
                        break;
                    case "3":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortCustomersById(true);
                        break;
                    case "4":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortCustomersById(false);
                        break;
                    default:
                        MessageBox.Show("Invalid option!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else if (choice.ToLower() == "item")
            {
                switch (sortChoice)
                {
                    case "1":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortItemsByName(true);
                        break;
                    case "2":
                        dgvDisplay.DataSource = null;
                        dgvDisplay.DataSource = manager.SortItemsByName(false);
                        break;
                    default:
                        MessageBox.Show("Invalid option!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customer or item",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBusinessLogic_Click(object sender, EventArgs e)
        {
            double revenue = manager.GetTotalRevenue();
            int itemsSold = manager.GetTotalItemsSold();
            var lowStock = manager.GetLowStockItems(5);

            string message = $"Total Revenue: ${revenue:F2}\n";
            message += $"Total Items Sold: {itemsSold}\n";
            message += $"Low Stock Items (<= 5): {lowStock.Count}\n\n";
            message += "Low Stock Items:\n";

            foreach (var item in lowStock)
            {
                message += $"- {item.Name}: {item.Quantity} left\n";
            }

            MessageBox.Show(message, "Business Logic - Report",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "Delete what?\n\nEnter: customer or item",
                "Delete", "customer");

            if (choice.ToLower() == "customer")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Customer ID to delete:", "Delete Customer");
                if (int.TryParse(input, out int id))
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Customer ID {id}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        manager.DeleteCustomer(id);
                        LoadCustomers();
                        MessageBox.Show("Customer deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (choice.ToLower() == "item")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Item ID to delete:", "Delete Item");
                if (int.TryParse(input, out int id))
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete Item ID {id}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        manager.DeleteItem(id);
                        LoadItems();
                        MessageBox.Show("Item deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customer or item",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox(
                "Update what?\n\nEnter: customer or item",
                "Update", "customer");

            if (choice.ToLower() == "customer")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Customer ID to update:", "Update Customer");
                if (int.TryParse(input, out int id))
                {
                    Customer c = manager.GetCustomerById(id);
                    if (c != null)
                    {
                        string name = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Name:", "Update", c.Name);
                        string phone = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Phone:", "Update", c.Phone);
                        string address = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Address:", "Update", c.Address);
                        manager.UpdateCustomer(id, name, phone, address);
                        LoadCustomers();
                        MessageBox.Show("Customer updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (choice.ToLower() == "item")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Item ID to update:", "Update Item");
                if (int.TryParse(input, out int id))
                {
                    Item i = manager.GetItemById(id);
                    if (i != null)
                    {
                        string name = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Name:", "Update", i.Name);
                        string priceStr = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Price:", "Update", i.Price.ToString());
                        string qtyStr = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Quantity:", "Update", i.Quantity.ToString());
                        string category = Microsoft.VisualBasic.Interaction.InputBox(
                            "Enter New Category:", "Update", i.Category);

                        if (double.TryParse(priceStr, out double price) && int.TryParse(qtyStr, out int qty))
                        {
                            manager.UpdateItem(id, name, price, qty, category);
                            LoadItems();
                            MessageBox.Show("Item updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid price or quantity!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid choice! Use: customer or item",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}