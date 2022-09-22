namespace Activity_2
{
    partial class ageInDaysCalculatorForm
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
            this.enterAgeLabel = new System.Windows.Forms.Label();
            this.ageInDaysLabel = new System.Windows.Forms.Label();
            this.enterAgeTextBox = new System.Windows.Forms.TextBox();
            this.ageInDaysTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterAgeLabel
            // 
            this.enterAgeLabel.AutoSize = true;
            this.enterAgeLabel.Location = new System.Drawing.Point(134, 113);
            this.enterAgeLabel.Name = "enterAgeLabel";
            this.enterAgeLabel.Size = new System.Drawing.Size(129, 25);
            this.enterAgeLabel.TabIndex = 0;
            this.enterAgeLabel.Text = "Enter Your Age";
            // 
            // ageInDaysLabel
            // 
            this.ageInDaysLabel.AutoSize = true;
            this.ageInDaysLabel.Location = new System.Drawing.Point(116, 187);
            this.ageInDaysLabel.Name = "ageInDaysLabel";
            this.ageInDaysLabel.Size = new System.Drawing.Size(147, 25);
            this.ageInDaysLabel.TabIndex = 1;
            this.ageInDaysLabel.Text = "Your Age in Days";
            // 
            // enterAgeTextBox
            // 
            this.enterAgeTextBox.Location = new System.Drawing.Point(286, 113);
            this.enterAgeTextBox.Name = "enterAgeTextBox";
            this.enterAgeTextBox.Size = new System.Drawing.Size(150, 31);
            this.enterAgeTextBox.TabIndex = 2;
            // 
            // ageInDaysTextBox
            // 
            this.ageInDaysTextBox.Location = new System.Drawing.Point(286, 187);
            this.ageInDaysTextBox.Name = "ageInDaysTextBox";
            this.ageInDaysTextBox.Size = new System.Drawing.Size(150, 31);
            this.ageInDaysTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(116, 303);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(147, 57);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(289, 303);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 57);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(116, 248);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(320, 34);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ageInDaysCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 465);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.ageInDaysTextBox);
            this.Controls.Add(this.enterAgeTextBox);
            this.Controls.Add(this.ageInDaysLabel);
            this.Controls.Add(this.enterAgeLabel);
            this.Name = "ageInDaysCalculatorForm";
            this.Text = "Your Age in Days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterAgeLabel;
        private Label ageInDaysLabel;
        private TextBox enterAgeTextBox;
        private TextBox ageInDaysTextBox;
        private Button convertButton;
        private Button exitButton;
        private Button resetButton;
    }
}