namespace Activity8
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
            this.enterFatLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterCarbsLabel = new System.Windows.Forms.Label();
            this.enterFatTextBox = new System.Windows.Forms.TextBox();
            this.enterCarbsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.caloriesFromFatLabel = new System.Windows.Forms.Label();
            this.caloriesFromCarbsLabel = new System.Windows.Forms.Label();
            this.outputCaloriesFromFat = new System.Windows.Forms.Label();
            this.outputCaloriesFromCarbs = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.outputTotalCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterFatLabel
            // 
            this.enterFatLabel.AutoSize = true;
            this.enterFatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterFatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterFatLabel.Location = new System.Drawing.Point(50, 122);
            this.enterFatLabel.Name = "enterFatLabel";
            this.enterFatLabel.Size = new System.Drawing.Size(190, 25);
            this.enterFatLabel.TabIndex = 0;
            this.enterFatLabel.Text = "Enter Fat (in grams):";
            this.enterFatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(133, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 38);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Calorie Counter";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterCarbsLabel
            // 
            this.enterCarbsLabel.AutoSize = true;
            this.enterCarbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCarbsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterCarbsLabel.Location = new System.Drawing.Point(25, 171);
            this.enterCarbsLabel.Name = "enterCarbsLabel";
            this.enterCarbsLabel.Size = new System.Drawing.Size(215, 25);
            this.enterCarbsLabel.TabIndex = 2;
            this.enterCarbsLabel.Text = "Enter Carbs (in grams):";
            this.enterCarbsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterFatTextBox
            // 
            this.enterFatTextBox.Location = new System.Drawing.Point(260, 125);
            this.enterFatTextBox.Name = "enterFatTextBox";
            this.enterFatTextBox.Size = new System.Drawing.Size(221, 22);
            this.enterFatTextBox.TabIndex = 3;
            // 
            // enterCarbsTextBox
            // 
            this.enterCarbsTextBox.Location = new System.Drawing.Point(260, 171);
            this.enterCarbsTextBox.Name = "enterCarbsTextBox";
            this.enterCarbsTextBox.Size = new System.Drawing.Size(221, 22);
            this.enterCarbsTextBox.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(30, 352);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(210, 75);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(271, 352);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(210, 75);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // caloriesFromFatLabel
            // 
            this.caloriesFromFatLabel.AutoSize = true;
            this.caloriesFromFatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromFatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caloriesFromFatLabel.Location = new System.Drawing.Point(74, 218);
            this.caloriesFromFatLabel.Name = "caloriesFromFatLabel";
            this.caloriesFromFatLabel.Size = new System.Drawing.Size(166, 25);
            this.caloriesFromFatLabel.TabIndex = 7;
            this.caloriesFromFatLabel.Text = "Calories from Fat:";
            this.caloriesFromFatLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caloriesFromCarbsLabel
            // 
            this.caloriesFromCarbsLabel.AutoSize = true;
            this.caloriesFromCarbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesFromCarbsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caloriesFromCarbsLabel.Location = new System.Drawing.Point(49, 262);
            this.caloriesFromCarbsLabel.Name = "caloriesFromCarbsLabel";
            this.caloriesFromCarbsLabel.Size = new System.Drawing.Size(191, 25);
            this.caloriesFromCarbsLabel.TabIndex = 8;
            this.caloriesFromCarbsLabel.Text = "Calories from Carbs:";
            this.caloriesFromCarbsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputCaloriesFromFat
            // 
            this.outputCaloriesFromFat.AutoSize = true;
            this.outputCaloriesFromFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCaloriesFromFat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputCaloriesFromFat.Location = new System.Drawing.Point(255, 218);
            this.outputCaloriesFromFat.Name = "outputCaloriesFromFat";
            this.outputCaloriesFromFat.Size = new System.Drawing.Size(0, 25);
            this.outputCaloriesFromFat.TabIndex = 9;
            this.outputCaloriesFromFat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputCaloriesFromCarbs
            // 
            this.outputCaloriesFromCarbs.AutoSize = true;
            this.outputCaloriesFromCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCaloriesFromCarbs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputCaloriesFromCarbs.Location = new System.Drawing.Point(255, 262);
            this.outputCaloriesFromCarbs.Name = "outputCaloriesFromCarbs";
            this.outputCaloriesFromCarbs.Size = new System.Drawing.Size(0, 25);
            this.outputCaloriesFromCarbs.TabIndex = 10;
            this.outputCaloriesFromCarbs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(101, 305);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(139, 25);
            this.totalCaloriesLabel.TabIndex = 11;
            this.totalCaloriesLabel.Text = "Total Calories:";
            this.totalCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputTotalCalories
            // 
            this.outputTotalCalories.AutoSize = true;
            this.outputTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTotalCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputTotalCalories.Location = new System.Drawing.Point(255, 305);
            this.outputTotalCalories.Name = "outputTotalCalories";
            this.outputTotalCalories.Size = new System.Drawing.Size(0, 25);
            this.outputTotalCalories.TabIndex = 12;
            this.outputTotalCalories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.outputTotalCalories);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.outputCaloriesFromCarbs);
            this.Controls.Add(this.outputCaloriesFromFat);
            this.Controls.Add(this.caloriesFromCarbsLabel);
            this.Controls.Add(this.caloriesFromFatLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.enterCarbsTextBox);
            this.Controls.Add(this.enterFatTextBox);
            this.Controls.Add(this.enterCarbsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.enterFatLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterFatLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enterCarbsLabel;
        private System.Windows.Forms.TextBox enterFatTextBox;
        private System.Windows.Forms.TextBox enterCarbsTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label caloriesFromFatLabel;
        private System.Windows.Forms.Label caloriesFromCarbsLabel;
        private System.Windows.Forms.Label outputCaloriesFromFat;
        private System.Windows.Forms.Label outputCaloriesFromCarbs;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label outputTotalCalories;
    }
}

