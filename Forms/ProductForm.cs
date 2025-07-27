using Inventory2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    // Form class for adding or modifying Products in the Inventory system.
    // Each Product can have multiple associated Parts.
    public partial class ProductForm : Form
    {
        // Holds the original Product to be edited (null if adding new).
        private Product _originalProduct;

        // Flag indicating if the form is in Add mode (true) or Modify mode (false).
        private bool isAddModeButton;

        // BindingList for managing associated Parts shown in the form.
        private BindingList<Part> _associatedParts;

        // Constructor for Add Product mode.
        public ProductForm()
        {
            InitializeComponent();

            // Set the form to Add mode
            isAddModeButton = true;

            // Initialize the associated parts list as empty for a new product
            _associatedParts = new BindingList<Part>();

            // Bind all available parts to the candidate parts DataGridView
            productAllCandidatePartsDataGridView.DataSource = Inventory.PartSource;

            // Bind the associated parts list to the associated parts DataGridView
            productAssociatedPartsDataGridView.DataSource = _associatedParts;

            // Set form title and fields according to mode
            ProductWindowTopText();
        }

        // Constructor for Modify Product mode, receives the product to edit and mode flag.
        public ProductForm(Product productToEdit, bool isAddNew)
        {
            InitializeComponent();

            // Store the original product for editing
            _originalProduct = productToEdit;

            // Set mode flag
            isAddModeButton = isAddNew;

            // Initialize the associated parts list from the product's current associated parts
            _associatedParts = new BindingList<Part>(_originalProduct.AssociatedParts);

            // Bind all available parts and associated parts to their respective DataGridViews
            productAllCandidatePartsDataGridView.DataSource = Inventory.PartSource;
            productAssociatedPartsDataGridView.DataSource = _associatedParts;

            // Set form title and fields according to mode and product data
            ProductWindowTopText();
        }

        // Event handler for the Add button.
        // Adds the selected parts from all candidate parts list to the associated parts list.
        private void productAddButton_Click(object sender, EventArgs e)
        {
            var selectedRows = productAllCandidatePartsDataGridView.SelectedRows;

            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    // Add the part to associated parts if not already present
                    if (row.DataBoundItem is Part part && !_associatedParts.Contains(part))
                    {
                        _associatedParts.Add(part);
                    }
                }
            }
            else
            {
                // Inform user to select a part before attempting to add
                MessageBox.Show("Please select a part to add.");
            }
        }

        // Event handler for Cancel button.
        // Closes the form without saving changes.
        private void productCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for Save button.
        // Validates user input, creates or updates the Product, and saves associated parts.
        private void productSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse product details from input fields
                int productId = int.Parse(productIDTextBox.Text);
                string productName = productNameTextBox.Text;
                decimal productPrice = decimal.Parse(productPriceTextBox.Text);
                int productInStock = int.Parse(productInventoryTextBox.Text);
                int productMin = int.Parse(productMinTextBox.Text);
                int productMax = int.Parse(productMaxTextBox.Text);

                // Validate that inventory is within the specified min and max range
                if (productInStock < productMin || productInStock > productMax)
                {
                    MessageBox.Show("Inventory must be between Min and Max values.");
                    return;
                }

                // Create new product instance with user input
                Product newProduct = new Product(productId, productName, productPrice, productInStock, productMin, productMax);

                // Assign associated parts to the new product
                newProduct.AssociatedParts = _associatedParts;

                if (isAddModeButton)
                {
                    // Add new product to the inventory
                    Inventory.AddProduct(newProduct);
                }
                else
                {
                    // Update existing product in the inventory
                    Inventory.UpdateProduct(newProduct);
                }

                // Close the form after saving successfully
                this.Close();
            }
            catch (Exception ex)
            {
                // Display error message if input parsing or saving fails
                MessageBox.Show($"Error saving product: {ex.Message}");
            }
        }

        // Event handler for Delete button.
        // Removes the selected parts from the associated parts list.
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRows = productAssociatedPartsDataGridView.SelectedRows;

            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    if (row.DataBoundItem is Part part)
                    {
                        _associatedParts.Remove(part);
                    }
                }
            }
            else
            {
                // Inform user to select a part before attempting to delete
                MessageBox.Show("Please select a part to delete.");
            }
        }

        // Sets the window title and populates form fields based on Add or Modify mode.
        public void ProductWindowTopText()
        {
            if (isAddModeButton)
            {
                // Setup form for adding a new product
                productAddModifyLabel.Text = "Add Product";

                // Disable editing of Product ID as it is auto-generated
                productIDTextBox.Enabled = false;

                // Generate and display the next available Product ID
                int nextID = Inventory.GetNextAvailableProductID();
                productIDTextBox.Text = nextID.ToString();
            }
            else
            {
                // Setup form for modifying an existing product
                productAddModifyLabel.Text = "Modify Product";
                productIDTextBox.Enabled = false;

                if (_originalProduct != null)
                {
                    // Populate form fields with existing product data
                    productIDTextBox.Text = _originalProduct.ProductID.ToString();
                    productNameTextBox.Text = _originalProduct.ProductName;
                    productPriceTextBox.Text = _originalProduct.Price.ToString();
                    productInventoryTextBox.Text = _originalProduct.Instock.ToString();
                    productMinTextBox.Text = _originalProduct.Min.ToString();
                    productMaxTextBox.Text = _originalProduct.Max.ToString();
                }
            }
        }

        // Event handler for the Search button.
        // Searches parts by name in the inventory and displays matching parts.
        public void productSearchButton_Click(object sender, EventArgs e)
        {
            // Retrieve trimmed search term from input box
            string searchTerm = productSearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Inform user to enter a search term
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Search inventory parts matching the term, case-insensitive
            var foundParts = Inventory.Parts
                .Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (foundParts.Count > 0)
            {
                // Display found parts in candidate parts grid
                productAllCandidatePartsDataGridView.DataSource = new BindingSource(foundParts, null);
            }
            else
            {
                // Inform user no matches found and reset the parts grid and search box
                MessageBox.Show("No parts found matching the search term.");
                productAllCandidatePartsDataGridView.DataSource = Inventory.PartSource;
                productSearchTextBox.Clear();
            }
        }
    }
}
