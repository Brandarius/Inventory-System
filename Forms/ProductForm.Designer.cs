namespace Inventory2
{
    partial class ProductForm
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
            productAddModifyLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            productAllCandidatePartsDataGridView = new DataGridView();
            productAddButton = new Button();
            productAssociatedPartsDataGridView = new DataGridView();
            productCancelButton = new Button();
            productIDTextBox = new TextBox();
            productNameTextBox = new TextBox();
            productInventoryTextBox = new TextBox();
            productMaxTextBox = new TextBox();
            productMinTextBox = new TextBox();
            productDeleteButton = new Button();
            productSaveButton = new Button();
            productSearchTextBox = new TextBox();
            productSearchButton = new Button();
            label6 = new Label();
            label7 = new Label();
            productPriceTextBox = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)productAllCandidatePartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productAssociatedPartsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // productAddModifyLabel
            // 
            productAddModifyLabel.AutoSize = true;
            productAddModifyLabel.Location = new Point(12, 9);
            productAddModifyLabel.Name = "productAddModifyLabel";
            productAddModifyLabel.Size = new Size(119, 20);
            productAddModifyLabel.TabIndex = 0;
            productAddModifyLabel.Text = "Changeable Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 105);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 140);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 212);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 266);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 5;
            label5.Text = "Min";
            // 
            // productAllCandidatePartsDataGridView
            // 
            productAllCandidatePartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productAllCandidatePartsDataGridView.Location = new Point(381, 53);
            productAllCandidatePartsDataGridView.Name = "productAllCandidatePartsDataGridView";
            productAllCandidatePartsDataGridView.RowHeadersWidth = 51;
            productAllCandidatePartsDataGridView.Size = new Size(466, 188);
            productAllCandidatePartsDataGridView.TabIndex = 6;
            // 
            // productAddButton
            // 
            productAddButton.Location = new Point(753, 248);
            productAddButton.Name = "productAddButton";
            productAddButton.Size = new Size(94, 58);
            productAddButton.TabIndex = 7;
            productAddButton.Text = "Add";
            productAddButton.UseVisualStyleBackColor = true;
            productAddButton.Click += productAddButton_Click;
            // 
            // productAssociatedPartsDataGridView
            // 
            productAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productAssociatedPartsDataGridView.Location = new Point(381, 312);
            productAssociatedPartsDataGridView.Name = "productAssociatedPartsDataGridView";
            productAssociatedPartsDataGridView.RowHeadersWidth = 51;
            productAssociatedPartsDataGridView.Size = new Size(466, 188);
            productAssociatedPartsDataGridView.TabIndex = 8;
            // 
            // productCancelButton
            // 
            productCancelButton.Location = new Point(753, 528);
            productCancelButton.Name = "productCancelButton";
            productCancelButton.Size = new Size(94, 58);
            productCancelButton.TabIndex = 9;
            productCancelButton.Text = "Cancel";
            productCancelButton.UseVisualStyleBackColor = true;
            productCancelButton.Click += productCancelButton_Click;
            // 
            // productIDTextBox
            // 
            productIDTextBox.Location = new Point(158, 98);
            productIDTextBox.Name = "productIDTextBox";
            productIDTextBox.PlaceholderText = "Auto Assigned";
            productIDTextBox.ReadOnly = true;
            productIDTextBox.Size = new Size(125, 27);
            productIDTextBox.TabIndex = 10;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(158, 133);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(125, 27);
            productNameTextBox.TabIndex = 11;
            // 
            // productInventoryTextBox
            // 
            productInventoryTextBox.Location = new Point(158, 209);
            productInventoryTextBox.Name = "productInventoryTextBox";
            productInventoryTextBox.Size = new Size(125, 27);
            productInventoryTextBox.TabIndex = 12;
            // 
            // productMaxTextBox
            // 
            productMaxTextBox.Location = new Point(65, 263);
            productMaxTextBox.Name = "productMaxTextBox";
            productMaxTextBox.Size = new Size(81, 27);
            productMaxTextBox.TabIndex = 13;
            // 
            // productMinTextBox
            // 
            productMinTextBox.Location = new Point(208, 263);
            productMinTextBox.Name = "productMinTextBox";
            productMinTextBox.Size = new Size(75, 27);
            productMinTextBox.TabIndex = 14;
            // 
            // productDeleteButton
            // 
            productDeleteButton.Location = new Point(481, 528);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(94, 58);
            productDeleteButton.TabIndex = 15;
            productDeleteButton.Text = "Delete";
            productDeleteButton.UseVisualStyleBackColor = true;
            productDeleteButton.Click += productDeleteButton_Click;
            // 
            // productSaveButton
            // 
            productSaveButton.Location = new Point(381, 528);
            productSaveButton.Name = "productSaveButton";
            productSaveButton.Size = new Size(94, 58);
            productSaveButton.TabIndex = 16;
            productSaveButton.Text = "Save";
            productSaveButton.UseVisualStyleBackColor = true;
            productSaveButton.Click += productSaveButton_Click;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(684, 20);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(163, 27);
            productSearchTextBox.TabIndex = 18;
            // 
            // productSearchButton
            // 
            productSearchButton.Location = new Point(609, 20);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(69, 27);
            productSearchButton.TabIndex = 17;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            productSearchButton.Click += productSearchButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 23);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 19;
            label6.Text = "All Candidate Parts";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 286);
            label7.Name = "label7";
            label7.Size = new Size(236, 20);
            label7.TabIndex = 20;
            label7.Text = "Parts Associated With This Product";
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(158, 173);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(125, 27);
            productPriceTextBox.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 176);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 21;
            label8.Text = "Price";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 598);
            Controls.Add(productPriceTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(productSearchTextBox);
            Controls.Add(productSearchButton);
            Controls.Add(productSaveButton);
            Controls.Add(productDeleteButton);
            Controls.Add(productMinTextBox);
            Controls.Add(productMaxTextBox);
            Controls.Add(productInventoryTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(productIDTextBox);
            Controls.Add(productCancelButton);
            Controls.Add(productAssociatedPartsDataGridView);
            Controls.Add(productAddButton);
            Controls.Add(productAllCandidatePartsDataGridView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productAddModifyLabel);
            Name = "ProductForm";
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)productAllCandidatePartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productAssociatedPartsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productAddModifyLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView productAllCandidatePartsDataGridView;
        private Button productAddButton;
        private DataGridView productAssociatedPartsDataGridView;
        private Button productCancelButton;
        private TextBox productIDTextBox;
        private TextBox productNameTextBox;
        private TextBox productInventoryTextBox;
        private TextBox productMaxTextBox;
        private TextBox productMinTextBox;
        private Button productDeleteButton;
        private Button productSaveButton;
        private TextBox productSearchTextBox;
        private Button productSearchButton;
        private Label label6;
        private Label label7;
        private TextBox productPriceTextBox;
        private Label label8;
    }
}