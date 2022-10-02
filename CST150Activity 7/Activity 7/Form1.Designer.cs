namespace Activity_7
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
            this.enterTermsLabel = new System.Windows.Forms.Label();
            this.inputTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputCalculationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterTermsLabel
            // 
            this.enterTermsLabel.AutoSize = true;
            this.enterTermsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.enterTermsLabel.Location = new System.Drawing.Point(34, 48);
            this.enterTermsLabel.Name = "enterTermsLabel";
            this.enterTermsLabel.Size = new System.Drawing.Size(127, 20);
            this.enterTermsLabel.TabIndex = 0;
            this.enterTermsLabel.Text = "Enter # of terms:";
            // 
            // inputTermsTextBox
            // 
            this.inputTermsTextBox.Location = new System.Drawing.Point(167, 45);
            this.inputTermsTextBox.Name = "inputTermsTextBox";
            this.inputTermsTextBox.Size = new System.Drawing.Size(136, 26);
            this.inputTermsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(38, 88);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(265, 35);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputCalculationLabel
            // 
            this.outputCalculationLabel.AutoSize = true;
            this.outputCalculationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputCalculationLabel.Location = new System.Drawing.Point(24, 149);
            this.outputCalculationLabel.Name = "outputCalculationLabel";
            this.outputCalculationLabel.Size = new System.Drawing.Size(279, 60);
            this.outputCalculationLabel.TabIndex = 3;
            this.outputCalculationLabel.Text = "Approximate value of pi after \"#\" terms\r\n\r\n= \"Solution\"\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(348, 266);
            this.Controls.Add(this.outputCalculationLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputTermsTextBox);
            this.Controls.Add(this.enterTermsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTermsLabel;
        private System.Windows.Forms.TextBox inputTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputCalculationLabel;
    }
}

