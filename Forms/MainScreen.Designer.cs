namespace Inventory2
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            partSearchButton = new Button();
            partSearchTextBox = new TextBox();
            productSearchButton = new Button();
            productSearchTextBox = new TextBox();
            partDataGridView = new DataGridView();
            productDataGridView = new DataGridView();
            label3 = new Label();
            partMainAddButton = new Button();
            partDeleteButton = new Button();
            partModifyButton = new Button();
            productModifyButton = new Button();
            productDeleteButton = new Button();
            productMainAddButton = new Button();
            mainscreenExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)partDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(248, 23);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(32, 62);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 1;
            label2.Text = "Parts";
            // 
            // partSearchButton
            // 
            partSearchButton.Location = new Point(171, 62);
            partSearchButton.Name = "partSearchButton";
            partSearchButton.Size = new Size(69, 27);
            partSearchButton.TabIndex = 2;
            partSearchButton.Text = "Search";
            partSearchButton.UseVisualStyleBackColor = true;
            partSearchButton.Click += partSearchButton_Click;
            // 
            // partSearchTextBox
            // 
            partSearchTextBox.Location = new Point(246, 62);
            partSearchTextBox.Name = "partSearchTextBox";
            partSearchTextBox.Size = new Size(163, 27);
            partSearchTextBox.TabIndex = 4;
            // 
            // productSearchButton
            // 
            productSearchButton.Location = new Point(616, 62);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(69, 27);
            productSearchButton.TabIndex = 5;
            productSearchButton.Text = "Search";
            productSearchButton.UseVisualStyleBackColor = true;
            productSearchButton.Click += productSearchButton_Click;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(691, 62);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(163, 27);
            productSearchTextBox.TabIndex = 6;
            // 
            // partDataGridView
            // 
            partDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partDataGridView.Location = new Point(32, 120);
            partDataGridView.Name = "partDataGridView";
            partDataGridView.RowHeadersWidth = 51;
            partDataGridView.Size = new Size(377, 238);
            partDataGridView.TabIndex = 7;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(477, 120);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.Size = new Size(377, 238);
            productDataGridView.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(477, 66);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 9;
            label3.Text = "Products";
            // 
            // partMainAddButton
            // 
            partMainAddButton.Location = new Point(175, 364);
            partMainAddButton.Name = "partMainAddButton";
            partMainAddButton.Size = new Size(74, 58);
            partMainAddButton.TabIndex = 10;
            partMainAddButton.Text = "Add";
            partMainAddButton.UseVisualStyleBackColor = true;
            partMainAddButton.Click += partMainAddButton_Click;
            // 
            // partDeleteButton
            // 
            partDeleteButton.Location = new Point(335, 364);
            partDeleteButton.Name = "partDeleteButton";
            partDeleteButton.Size = new Size(74, 58);
            partDeleteButton.TabIndex = 11;
            partDeleteButton.Text = "Delete";
            partDeleteButton.UseVisualStyleBackColor = true;
            partDeleteButton.Click += partDeleteButton_Click;
            // 
            // partModifyButton
            // 
            partModifyButton.Location = new Point(255, 364);
            partModifyButton.Name = "partModifyButton";
            partModifyButton.Size = new Size(74, 58);
            partModifyButton.TabIndex = 12;
            partModifyButton.Text = "Modify";
            partModifyButton.UseVisualStyleBackColor = true;
            partModifyButton.Click += partModifyButton_Click;
            // 
            // productModifyButton
            // 
            productModifyButton.Location = new Point(700, 364);
            productModifyButton.Name = "productModifyButton";
            productModifyButton.Size = new Size(74, 58);
            productModifyButton.TabIndex = 15;
            productModifyButton.Text = "Modify";
            productModifyButton.UseVisualStyleBackColor = true;
            productModifyButton.Click += productModifyButton_Click;
            // 
            // productDeleteButton
            // 
            productDeleteButton.Location = new Point(780, 364);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(74, 58);
            productDeleteButton.TabIndex = 14;
            productDeleteButton.Text = "Delete";
            productDeleteButton.UseVisualStyleBackColor = true;
            productDeleteButton.Click += productDeleteButton_Click;
            // 
            // productMainAddButton
            // 
            productMainAddButton.Location = new Point(620, 364);
            productMainAddButton.Name = "productMainAddButton";
            productMainAddButton.Size = new Size(74, 58);
            productMainAddButton.TabIndex = 13;
            productMainAddButton.Text = "Add";
            productMainAddButton.UseVisualStyleBackColor = true;
            productMainAddButton.Click += productMainAddButton_Click;
            // 
            // mainscreenExitButton
            // 
            mainscreenExitButton.Location = new Point(742, 471);
            mainscreenExitButton.Name = "mainscreenExitButton";
            mainscreenExitButton.Size = new Size(112, 59);
            mainscreenExitButton.TabIndex = 16;
            mainscreenExitButton.Text = "Exit";
            mainscreenExitButton.UseVisualStyleBackColor = true;
            mainscreenExitButton.Click += mainscreenExitButton_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 542);
            Controls.Add(mainscreenExitButton);
            Controls.Add(productModifyButton);
            Controls.Add(productDeleteButton);
            Controls.Add(productMainAddButton);
            Controls.Add(partModifyButton);
            Controls.Add(partDeleteButton);
            Controls.Add(partMainAddButton);
            Controls.Add(label3);
            Controls.Add(productDataGridView);
            Controls.Add(partDataGridView);
            Controls.Add(productSearchTextBox);
            Controls.Add(productSearchButton);
            Controls.Add(partSearchTextBox);
            Controls.Add(partSearchButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)partDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button partSearchButton;
        private TextBox partSearchTextBox;
        private Button productSearchButton;
        private TextBox productSearchTextBox;
        public DataGridView partDataGridView;
        private DataGridView productDataGridView;
        private Label label3;
        private Button partMainAddButton;
        private Button partDeleteButton;
        private Button partModifyButton;
        private Button productModifyButton;
        private Button productDeleteButton;
        private Button productMainAddButton;
        private Button mainscreenExitButton;
    }
}
