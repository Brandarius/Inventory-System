using Inventory2.Models;

namespace Inventory2
{
    // Form class for adding or modifying Parts in the Inventory system.
    // Supports two types of Parts: InHousePart and OutsourcedPart.
    public partial class PartForm : Form
    {
        // Holds the original Part to be edited (null if adding new).
        private Part _originalPart;

        // Flag indicating if form is in Add New mode or Modify mode.
        private bool isAddNewButton;

        // Constructor for Modify Part mode: receives the Part to edit and a flag.
        public PartForm(Part partToEdit, bool isAddNew)
        {
            InitializeComponent();

            // Store the part to be modified
            _originalPart = partToEdit;

            // Retrieve the ID of the original part (currently not directly used)
            int partId = _originalPart.PartID;

            // Configure the form UI elements based on whether adding or modifying
            PartWindowTopText();
        }

        // Constructor for Add New Part mode: receives only a flag.
        public PartForm(bool isAddNew)
        {
            InitializeComponent();

            // Set the mode flag to indicate form is for adding a new part
            isAddNewButton = isAddNew;

            // Configure the form UI elements accordingly
            PartWindowTopText();
        }

        // Returns true if the In-House radio button is selected, false otherwise
        public bool IsInHouse()
        {
            if (partInHouseRadioButton.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Event handler triggered when the form finishes loading.
        // Sets default label and default radio button selection.
        private void PartForm_Load(object sender, EventArgs e)
        {
            // Default label text when InHouse part is selected
            partChangeableLabel.Text = "Machine ID";

            // Default selection is InHouse radio button
            partInHouseRadioButton.Checked = true;
        }

        // Event handler triggered when the InHouse radio button checked state changes.
        // Updates the label to reflect the expected input.
        private void partInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partChangeableLabel.Text = "Machine ID";
        }

        // Event handler triggered when the Outsourced radio button checked state changes.
        // Updates the label to reflect the expected input.
        private void partOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            partChangeableLabel.Text = "Company Name";
        }

        // Event handler for the Cancel button click.
        // Closes the form without saving any changes.
        private void partformCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Save button click.
        // Validates and parses all inputs, creates the appropriate Part object, 
        // adds it to Inventory, and closes the form.
        private void partformSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse common part details from textboxes
                int partId = int.Parse(partIDTextBox.Text);
                string partName = partNameTextBox.Text;
                decimal partPrice = decimal.Parse(partPriceTextBox.Text);
                int partStock = int.Parse(partInventoryTextBox.Text);
                int partMin = int.Parse(partMinTextBox.Text);
                int partMax = int.Parse(partMaxTextBox.Text);

                if (IsInHouse())
                {
                    // Parse Machine ID specific to InHouse parts
                    int machineId = int.Parse(partChangeableTextbox.Text);

                    // Create new InHousePart and add to inventory
                    InHousePart inhousePart = new InHousePart(partId, partName, partPrice, partStock, partMin, partMax, machineId);
                    Inventory.AddPart(inhousePart);
                }
                else
                {
                    // Parse Company Name specific to Outsourced parts
                    string companyName = partChangeableTextbox.Text;

                    // Create new OutsourcedPart and add to inventory
                    OutsourcedPart outsourcedPart = new OutsourcedPart(partId, partName, partPrice, partStock, partMin, partMax, companyName);
                    Inventory.AddPart(outsourcedPart);
                }

                // Close the form upon successful save
                this.Close();
            }
            catch (Exception ex)
            {
                // Display error message in case of invalid input or save failure
                MessageBox.Show("Error saving part: " + ex.Message);
            }
        }

        // Configures the form UI text and input fields based on Add or Modify mode.
        public void PartWindowTopText()
        {
            if (isAddNewButton)
            {
                // Set label and disable editing of Part ID for Add mode
                partAddModifyLabel.Text = "Add Part";
                partIDTextBox.Enabled = false;

                // Auto-generate the next available Part ID and display it
                int nextID = Inventory.GetNextAvailablePartID();
                partIDTextBox.Text = nextID.ToString();
            }
            else
            {
                // Set label and disable editing of Part ID for Modify mode
                partAddModifyLabel.Text = "Modify Part";
                partIDTextBox.Enabled = false;

                if (_originalPart != null)
                {
                    // Populate fields with data from the part being modified
                    partIDTextBox.Text = _originalPart.PartID.ToString();
                    partNameTextBox.Text = _originalPart.Name;
                    partPriceTextBox.Text = _originalPart.Price.ToString();
                    partInventoryTextBox.Text = _originalPart.InStock.ToString();
                    partMinTextBox.Text = _originalPart.Min.ToString();
                    partMaxTextBox.Text = _originalPart.Max.ToString();

                    // Set radio buttons and part-specific textbox depending on part type
                    if (_originalPart is InHousePart inHousePart)
                    {
                        partInHouseRadioButton.Checked = true;
                        partChangeableTextbox.Text = inHousePart.MachineID.ToString();
                    }
                    else if (_originalPart is OutsourcedPart outsourcedPart)
                    {
                        partOutsourcedRadioButton.Checked = true;
                        partChangeableTextbox.Text = outsourcedPart.CompanyName;
                    }
                }
            }
        }

    }
}
