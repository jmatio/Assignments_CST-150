namespace Milestone4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.totalItemLabel = new System.Windows.Forms.Label();
            this.totalNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(24, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.priceLabel.Location = new System.Drawing.Point(24, 350);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 29);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.partNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.partNumberLabel.Location = new System.Drawing.Point(24, 257);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(149, 29);
            this.partNumberLabel.TabIndex = 2;
            this.partNumberLabel.Text = "Part Number";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.quantityLabel.Location = new System.Drawing.Point(24, 434);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(100, 29);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(29, 116);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(29, 289);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(251, 26);
            this.partNumberTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(29, 382);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(251, 26);
            this.priceTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(29, 466);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(251, 26);
            this.quantityTextBox.TabIndex = 4;
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 25;
            this.inventoryListBox.Location = new System.Drawing.Point(716, 82);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(444, 779);
            this.inventoryListBox.Sorted = true;
            this.inventoryListBox.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(429, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 57);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(429, 322);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(176, 57);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(360, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(404, 32);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Inventory Management System";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(29, 200);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(251, 26);
            this.departmentTextBox.TabIndex = 1;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.departmentLabel.Location = new System.Drawing.Point(24, 168);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(138, 29);
            this.departmentLabel.TabIndex = 13;
            this.departmentLabel.Text = "Department";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(29, 815);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(245, 26);
            this.searchNameTextBox.TabIndex = 8;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchNameLabel.Location = new System.Drawing.Point(24, 783);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(191, 29);
            this.searchNameLabel.TabIndex = 15;
            this.searchNameLabel.Text = "Search by Name";
            // 
            // searchNameButton
            // 
            this.searchNameButton.Location = new System.Drawing.Point(429, 799);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(172, 44);
            this.searchNameButton.TabIndex = 9;
            this.searchNameButton.Text = "Search Name";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(429, 435);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(176, 57);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // totalItemLabel
            // 
            this.totalItemLabel.AutoSize = true;
            this.totalItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalItemLabel.Location = new System.Drawing.Point(23, 565);
            this.totalItemLabel.Name = "totalItemLabel";
            this.totalItemLabel.Size = new System.Drawing.Size(314, 32);
            this.totalItemLabel.TabIndex = 16;
            this.totalItemLabel.Text = "Total Items in Inventory:";
            // 
            // totalNumberLabel
            // 
            this.totalNumberLabel.AutoSize = true;
            this.totalNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalNumberLabel.Location = new System.Drawing.Point(139, 635);
            this.totalNumberLabel.Name = "totalNumberLabel";
            this.totalNumberLabel.Size = new System.Drawing.Size(30, 32);
            this.totalNumberLabel.TabIndex = 17;
            this.totalNumberLabel.Text = "0";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 882);
            this.Controls.Add(this.totalNumberLabel);
            this.Controls.Add(this.totalItemLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchNameButton);
            this.Controls.Add(this.searchNameLabel);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.partNumberLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventory Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.Label totalNumberLabel;
    }
}

