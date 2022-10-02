namespace Activity_5
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
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.uploadFileLabel = new System.Windows.Forms.Label();
            this.lowerCaseOutputTextBox = new System.Windows.Forms.TextBox();
            this.lowerCaseOutputLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.longestNameTextBox = new System.Windows.Forms.TextBox();
            this.nameMostVowelsTextBox = new System.Windows.Forms.TextBox();
            this.longestNameLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(211, 31);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(277, 46);
            this.uploadFileButton.TabIndex = 0;
            this.uploadFileButton.Text = "Upload File";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            // 
            // uploadFileLabel
            // 
            this.uploadFileLabel.AutoSize = true;
            this.uploadFileLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uploadFileLabel.Location = new System.Drawing.Point(53, 44);
            this.uploadFileLabel.Name = "uploadFileLabel";
            this.uploadFileLabel.Size = new System.Drawing.Size(140, 20);
            this.uploadFileLabel.TabIndex = 1;
            this.uploadFileLabel.Text = "Upload a Text File:";
            // 
            // lowerCaseOutputTextBox
            // 
            this.lowerCaseOutputTextBox.Location = new System.Drawing.Point(211, 98);
            this.lowerCaseOutputTextBox.Multiline = true;
            this.lowerCaseOutputTextBox.Name = "lowerCaseOutputTextBox";
            this.lowerCaseOutputTextBox.Size = new System.Drawing.Size(277, 157);
            this.lowerCaseOutputTextBox.TabIndex = 2;
            // 
            // lowerCaseOutputLabel
            // 
            this.lowerCaseOutputLabel.AutoSize = true;
            this.lowerCaseOutputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lowerCaseOutputLabel.Location = new System.Drawing.Point(50, 133);
            this.lowerCaseOutputLabel.Name = "lowerCaseOutputLabel";
            this.lowerCaseOutputLabel.Size = new System.Drawing.Size(143, 20);
            this.lowerCaseOutputLabel.TabIndex = 3;
            this.lowerCaseOutputLabel.Text = "Lowercase Output:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(211, 281);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 284);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(181, 20);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Alphabetical Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(211, 322);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 328);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(181, 20);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Alphabetical Name:";
            // 
            // longestNameTextBox
            // 
            this.longestNameTextBox.Location = new System.Drawing.Point(211, 365);
            this.longestNameTextBox.Name = "longestNameTextBox";
            this.longestNameTextBox.Size = new System.Drawing.Size(277, 26);
            this.longestNameTextBox.TabIndex = 8;
            // 
            // nameMostVowelsTextBox
            // 
            this.nameMostVowelsTextBox.Location = new System.Drawing.Point(211, 409);
            this.nameMostVowelsTextBox.Name = "nameMostVowelsTextBox";
            this.nameMostVowelsTextBox.Size = new System.Drawing.Size(277, 26);
            this.nameMostVowelsTextBox.TabIndex = 9;
            // 
            // longestNameLabel
            // 
            this.longestNameLabel.AutoSize = true;
            this.longestNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.longestNameLabel.Location = new System.Drawing.Point(92, 371);
            this.longestNameLabel.Name = "longestNameLabel";
            this.longestNameLabel.Size = new System.Drawing.Size(117, 20);
            this.longestNameLabel.TabIndex = 10;
            this.longestNameLabel.Text = "Longest Name:";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.mostVowelsLabel.Location = new System.Drawing.Point(28, 415);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(181, 20);
            this.mostVowelsLabel.TabIndex = 11;
            this.mostVowelsLabel.Text = "Name with Most Vowels:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 509);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestNameLabel);
            this.Controls.Add(this.nameMostVowelsTextBox);
            this.Controls.Add(this.longestNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lowerCaseOutputLabel);
            this.Controls.Add(this.lowerCaseOutputTextBox);
            this.Controls.Add(this.uploadFileLabel);
            this.Controls.Add(this.uploadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.Label uploadFileLabel;
        private System.Windows.Forms.TextBox lowerCaseOutputTextBox;
        private System.Windows.Forms.Label lowerCaseOutputLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox longestNameTextBox;
        private System.Windows.Forms.TextBox nameMostVowelsTextBox;
        private System.Windows.Forms.Label longestNameLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
    }
}

