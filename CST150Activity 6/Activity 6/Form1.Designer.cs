namespace Activity_6
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
            this.enterAgeTextBox = new System.Windows.Forms.TextBox();
            this.enterAgeLabel = new System.Windows.Forms.Label();
            this.ageInDaysLabel = new System.Windows.Forms.Label();
            this.ageInDaysTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterAgeTextBox
            // 
            this.enterAgeTextBox.Location = new System.Drawing.Point(239, 66);
            this.enterAgeTextBox.Name = "enterAgeTextBox";
            this.enterAgeTextBox.Size = new System.Drawing.Size(164, 26);
            this.enterAgeTextBox.TabIndex = 0;
            // 
            // enterAgeLabel
            // 
            this.enterAgeLabel.AutoSize = true;
            this.enterAgeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.enterAgeLabel.Location = new System.Drawing.Point(95, 72);
            this.enterAgeLabel.Name = "enterAgeLabel";
            this.enterAgeLabel.Size = new System.Drawing.Size(119, 20);
            this.enterAgeLabel.TabIndex = 1;
            this.enterAgeLabel.Text = "Enter Your Age";
            // 
            // ageInDaysLabel
            // 
            this.ageInDaysLabel.AutoSize = true;
            this.ageInDaysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ageInDaysLabel.Location = new System.Drawing.Point(82, 124);
            this.ageInDaysLabel.Name = "ageInDaysLabel";
            this.ageInDaysLabel.Size = new System.Drawing.Size(132, 20);
            this.ageInDaysLabel.TabIndex = 2;
            this.ageInDaysLabel.Text = "Your Age in Days";
            // 
            // ageInDaysTextBox
            // 
            this.ageInDaysTextBox.Location = new System.Drawing.Point(239, 121);
            this.ageInDaysTextBox.Name = "ageInDaysTextBox";
            this.ageInDaysTextBox.Size = new System.Drawing.Size(164, 26);
            this.ageInDaysTextBox.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(86, 178);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(317, 29);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(86, 230);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(150, 44);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(254, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(485, 327);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ageInDaysTextBox);
            this.Controls.Add(this.ageInDaysLabel);
            this.Controls.Add(this.enterAgeLabel);
            this.Controls.Add(this.enterAgeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Your Age in Days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterAgeTextBox;
        private System.Windows.Forms.Label enterAgeLabel;
        private System.Windows.Forms.Label ageInDaysLabel;
        private System.Windows.Forms.TextBox ageInDaysTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

