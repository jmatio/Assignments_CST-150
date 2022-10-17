namespace Activity_11
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
            this.dieOneTextBox = new System.Windows.Forms.RichTextBox();
            this.dieTwoTextBox = new System.Windows.Forms.RichTextBox();
            this.snakeEyesLabel = new System.Windows.Forms.Label();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dieOneTextBox
            // 
            this.dieOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieOneTextBox.Location = new System.Drawing.Point(104, 238);
            this.dieOneTextBox.Name = "dieOneTextBox";
            this.dieOneTextBox.Size = new System.Drawing.Size(102, 90);
            this.dieOneTextBox.TabIndex = 0;
            this.dieOneTextBox.Text = "1";
            // 
            // dieTwoTextBox
            // 
            this.dieTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieTwoTextBox.Location = new System.Drawing.Point(294, 238);
            this.dieTwoTextBox.Name = "dieTwoTextBox";
            this.dieTwoTextBox.Size = new System.Drawing.Size(102, 90);
            this.dieTwoTextBox.TabIndex = 1;
            this.dieTwoTextBox.Text = "1";
            // 
            // snakeEyesLabel
            // 
            this.snakeEyesLabel.AutoSize = true;
            this.snakeEyesLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.snakeEyesLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeEyesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.snakeEyesLabel.Location = new System.Drawing.Point(125, 83);
            this.snakeEyesLabel.Name = "snakeEyesLabel";
            this.snakeEyesLabel.Size = new System.Drawing.Size(257, 52);
            this.snakeEyesLabel.TabIndex = 2;
            this.snakeEyesLabel.Text = "Snake Eyes";
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollDiceButton.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rollDiceButton.Location = new System.Drawing.Point(104, 434);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(292, 132);
            this.rollDiceButton.TabIndex = 3;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = false;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 675);
            this.Controls.Add(this.rollDiceButton);
            this.Controls.Add(this.snakeEyesLabel);
            this.Controls.Add(this.dieTwoTextBox);
            this.Controls.Add(this.dieOneTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake Eyes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dieOneTextBox;
        private System.Windows.Forms.RichTextBox dieTwoTextBox;
        private System.Windows.Forms.Label snakeEyesLabel;
        private System.Windows.Forms.Button rollDiceButton;
    }
}

