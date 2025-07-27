namespace Inventory2
{
    partial class PartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partAddModifyLabel = new Label();
            partInHouseRadioButton = new RadioButton();
            partOutsourcedRadioButton = new RadioButton();
            label17 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            partChangeableLabel = new Label();
            partIDTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partInventoryTextBox = new TextBox();
            partPriceTextBox = new TextBox();
            partMaxTextBox = new TextBox();
            partMinTextBox = new TextBox();
            partChangeableTextbox = new TextBox();
            partformSaveButton = new Button();
            partformCancelButton = new Button();
            SuspendLayout();
            // 
            // partAddModifyLabel
            // 
            partAddModifyLabel.AutoSize = true;
            partAddModifyLabel.Location = new Point(21, 19);
            partAddModifyLabel.Name = "partAddModifyLabel";
            partAddModifyLabel.Size = new Size(66, 20);
            partAddModifyLabel.TabIndex = 0;
            partAddModifyLabel.Text = "Add Part";
            // 
            // partInHouseRadioButton
            // 
            partInHouseRadioButton.AutoSize = true;
            partInHouseRadioButton.Checked = true;
            partInHouseRadioButton.Location = new Point(103, 20);
            partInHouseRadioButton.Name = "partInHouseRadioButton";
            partInHouseRadioButton.Size = new Size(90, 24);
            partInHouseRadioButton.TabIndex = 1;
            partInHouseRadioButton.TabStop = true;
            partInHouseRadioButton.Text = "In-House";
            partInHouseRadioButton.UseVisualStyleBackColor = true;
            partInHouseRadioButton.CheckedChanged += partInHouseRadioButton_CheckedChanged;
            // 
            // partOutsourcedRadioButton
            // 
            partOutsourcedRadioButton.AutoSize = true;
            partOutsourcedRadioButton.Location = new Point(199, 20);
            partOutsourcedRadioButton.Name = "partOutsourcedRadioButton";
            partOutsourcedRadioButton.Size = new Size(106, 24);
            partOutsourcedRadioButton.TabIndex = 2;
            partOutsourcedRadioButton.Text = "Outsourced";
            partOutsourcedRadioButton.UseVisualStyleBackColor = true;
            partOutsourcedRadioButton.CheckedChanged += partOutsourcedRadioButton_CheckedChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(83, 107);
            label17.Name = "label17";
            label17.Size = new Size(24, 20);
            label17.TabIndex = 3;
            label17.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 154);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 200);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 244);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 299);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 302);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 8;
            label5.Text = "Min";
            // 
            // partChangeableLabel
            // 
            partChangeableLabel.AutoSize = true;
            partChangeableLabel.Location = new Point(21, 392);
            partChangeableLabel.Name = "partChangeableLabel";
            partChangeableLabel.Size = new Size(84, 20);
            partChangeableLabel.TabIndex = 9;
            partChangeableLabel.Text = "Machine ID";
            // 
            // partIDTextBox
            // 
            partIDTextBox.Location = new Point(113, 104);
            partIDTextBox.Name = "partIDTextBox";
            partIDTextBox.PlaceholderText = "Auto Assigned";
            partIDTextBox.Size = new Size(125, 27);
            partIDTextBox.TabIndex = 10;
            // 
            // partNameTextBox
            // 
            partNameTextBox.Location = new Point(113, 151);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(125, 27);
            partNameTextBox.TabIndex = 11;
            // 
            // partInventoryTextBox
            // 
            partInventoryTextBox.Location = new Point(113, 197);
            partInventoryTextBox.Name = "partInventoryTextBox";
            partInventoryTextBox.Size = new Size(125, 27);
            partInventoryTextBox.TabIndex = 12;
            // 
            // partPriceTextBox
            // 
            partPriceTextBox.Location = new Point(113, 237);
            partPriceTextBox.Name = "partPriceTextBox";
            partPriceTextBox.Size = new Size(125, 27);
            partPriceTextBox.TabIndex = 13;
            // 
            // partMaxTextBox
            // 
            partMaxTextBox.Location = new Point(113, 299);
            partMaxTextBox.Name = "partMaxTextBox";
            partMaxTextBox.Size = new Size(92, 27);
            partMaxTextBox.TabIndex = 14;
            // 
            // partMinTextBox
            // 
            partMinTextBox.Location = new Point(259, 302);
            partMinTextBox.Name = "partMinTextBox";
            partMinTextBox.Size = new Size(92, 27);
            partMinTextBox.TabIndex = 15;
            // 
            // partChangeableTextbox
            // 
            partChangeableTextbox.Location = new Point(155, 389);
            partChangeableTextbox.Name = "partChangeableTextbox";
            partChangeableTextbox.Size = new Size(125, 27);
            partChangeableTextbox.TabIndex = 16;
            // 
            // partformSaveButton
            // 
            partformSaveButton.Location = new Point(219, 455);
            partformSaveButton.Name = "partformSaveButton";
            partformSaveButton.Size = new Size(74, 58);
            partformSaveButton.TabIndex = 17;
            partformSaveButton.Text = "Save";
            partformSaveButton.UseVisualStyleBackColor = true;
            partformSaveButton.Click += partformSaveButton_Click;
            // 
            // partformCancelButton
            // 
            partformCancelButton.Location = new Point(315, 455);
            partformCancelButton.Name = "partformCancelButton";
            partformCancelButton.Size = new Size(74, 58);
            partformCancelButton.TabIndex = 18;
            partformCancelButton.Text = "Cancel";
            partformCancelButton.UseVisualStyleBackColor = true;
            partformCancelButton.Click += partformCancelButton_Click;
            // 
            // PartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 540);
            Controls.Add(partformCancelButton);
            Controls.Add(partformSaveButton);
            Controls.Add(partChangeableTextbox);
            Controls.Add(partMinTextBox);
            Controls.Add(partMaxTextBox);
            Controls.Add(partPriceTextBox);
            Controls.Add(partInventoryTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIDTextBox);
            Controls.Add(partChangeableLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(partOutsourcedRadioButton);
            Controls.Add(partInHouseRadioButton);
            Controls.Add(partAddModifyLabel);
            Name = "PartForm";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label partAddModifyLabel;
        private RadioButton partInHouseRadioButton;
        private RadioButton partOutsourcedRadioButton;
        private Label label17;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label partChangeableLabel;
        private TextBox partIDTextBox;
        private TextBox partNameTextBox;
        private TextBox partInventoryTextBox;
        private TextBox partPriceTextBox;
        private TextBox partMaxTextBox;
        private TextBox partMinTextBox;
        private TextBox partChangeableTextbox;
        private Button partformSaveButton;
        private Button partformCancelButton;
    }
}