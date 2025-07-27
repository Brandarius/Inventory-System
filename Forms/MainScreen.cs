using Inventory2.Models;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Inventory2
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            // Initialize default test data for demonstration
            Inventory.AddPart(new OutsourcedPart(1, "Bolt", 0.25m, 50, 10, 100, "Joe"));
            Inventory.AddProduct(new Product(1, "Chair", 45.5m, 50, 10, 100));

            // Bind DataGridViews to data sources
            productDataGridView.DataSource = Inventory.Products;
            partDataGridView.DataSource = Inventory.PartSource;
        }

        // Close the application
        private void mainscreenExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open the form to add a new part
        private void partMainAddButton_Click(object sender, EventArgs e)
        {
            PartForm partForm = new PartForm(true);
            partForm.ShowDialog();
        }

        // Delete selected part(s)
        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRows = partDataGridView.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    if (row.DataBoundItem is Part part)
                    {
                        Inventory.DeletePart(part);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        // Open the form to modify the selected part
        private void partModifyButton_Click(object sender, EventArgs e)
        {
            var selectedRows = partDataGridView.SelectedRows;

            try
            {
                if (selectedRows.Count == 1)
                {
                    var selectedPart = selectedRows[0].DataBoundItem as Part;
                    if (selectedPart != null)
                    {
                        PartForm partForm = new PartForm(selectedPart, false);
                        partForm.ShowDialog();

                        Inventory.UpdatePart(selectedPart);
                    }
                }
                else
                {
                    MessageBox.Show("Please select one part to modify.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modifying part: " + ex.Message);
            }
        }

        // Search for a part by name or ID
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = partSearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            Part matchedPart = Inventory.Parts
                .FirstOrDefault(p =>
                    p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    p.PartID.ToString() == searchTerm);

            if (matchedPart != null)
            {
                foreach (DataGridViewRow row in partDataGridView.Rows)
                {
                    if (row.DataBoundItem == matchedPart)
                    {
                        partDataGridView.ClearSelection();
                        row.Selected = true;
                        partDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No parts found matching the search term.");
                partSearchTextBox.Clear();
            }
        }

        // Open the form to add a new product
        private void productMainAddButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        // Modify selected product
        private void productModifyButton_Click(object sender, EventArgs e)
        {
            var selectedRows = productDataGridView.SelectedRows;

            try
            {
                if (selectedRows.Count == 1)
                {
                    var selectedProduct = selectedRows[0].DataBoundItem as Product;
                    if (selectedProduct != null)
                    {
                        ProductForm productForm = new ProductForm(selectedProduct, false);
                        productForm.ShowDialog();

                        Inventory.UpdateProduct(selectedProduct);
                    }
                }
                else
                {
                    MessageBox.Show("Please select one product to modify.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modifying product: " + ex.Message);
            }
        }

        // Search for a product by name or ID
        private void productSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = productSearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            Product matchedProduct = Inventory.Products
                .FirstOrDefault(p =>
                    p.ProductName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    p.ProductID.ToString() == searchTerm);

            if (matchedProduct != null)
            {
                foreach (DataGridViewRow row in productDataGridView.Rows)
                {
                    if (row.DataBoundItem == matchedProduct)
                    {
                        productDataGridView.ClearSelection();
                        row.Selected = true;
                        productDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No products found matching the search term.");
                productSearchTextBox.Clear();
            }
        }

        // Delete selected product(s)
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRows = productDataGridView.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    if (row.DataBoundItem is Product product)
                    {
                        Inventory.DeleteProduct(product);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }
    }
}
