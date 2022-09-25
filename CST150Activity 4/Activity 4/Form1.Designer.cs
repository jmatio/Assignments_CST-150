namespace Activity_4
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
            this.secondsElapsedTextBox = new System.Windows.Forms.TextBox();
            this.secondsElapsedLabel = new System.Windows.Forms.Label();
            this.convertedTimeTextBox = new System.Windows.Forms.TextBox();
            this.convertedTimeLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsElapsedTextBox
            // 
            this.secondsElapsedTextBox.Location = new System.Drawing.Point(203, 79);
            this.secondsElapsedTextBox.Name = "secondsElapsedTextBox";
            this.secondsElapsedTextBox.Size = new System.Drawing.Size(211, 26);
            this.secondsElapsedTextBox.TabIndex = 0;
            this.secondsElapsedTextBox.TextChanged += new System.EventHandler(this.secondsElapsedTextBox_TextChanged);
            // 
            // secondsElapsedLabel
            // 
            this.secondsElapsedLabel.AutoSize = true;
            this.secondsElapsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secondsElapsedLabel.Location = new System.Drawing.Point(61, 82);
            this.secondsElapsedLabel.Name = "secondsElapsedLabel";
            this.secondsElapsedLabel.Size = new System.Drawing.Size(136, 20);
            this.secondsElapsedLabel.TabIndex = 1;
            this.secondsElapsedLabel.Text = "Seconds elapsed:";
            // 
            // convertedTimeTextBox
            // 
            this.convertedTimeTextBox.Location = new System.Drawing.Point(203, 135);
            this.convertedTimeTextBox.Name = "convertedTimeTextBox";
            this.convertedTimeTextBox.Size = new System.Drawing.Size(211, 26);
            this.convertedTimeTextBox.TabIndex = 2;
            // 
            // convertedTimeLabel
            // 
            this.convertedTimeLabel.AutoSize = true;
            this.convertedTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.convertedTimeLabel.Location = new System.Drawing.Point(77, 135);
            this.convertedTimeLabel.Name = "convertedTimeLabel";
            this.convertedTimeLabel.Size = new System.Drawing.Size(120, 20);
            this.convertedTimeLabel.TabIndex = 3;
            this.convertedTimeLabel.Text = "Converted time:";
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.Control;
            this.convertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.convertButton.Location = new System.Drawing.Point(51, 204);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(117, 52);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(190, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 52);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(326, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 52);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLable.Location = new System.Drawing.Point(163, 23);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(180, 29);
            this.titleLable.TabIndex = 9;
            this.titleLable.Text = "Time Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(514, 285);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedTimeLabel);
            this.Controls.Add(this.convertedTimeTextBox);
            this.Controls.Add(this.secondsElapsedLabel);
            this.Controls.Add(this.secondsElapsedTextBox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Time Converter (Activity 4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondsElapsedTextBox;
        private System.Windows.Forms.Label secondsElapsedLabel;
        private System.Windows.Forms.TextBox convertedTimeTextBox;
        private System.Windows.Forms.Label convertedTimeLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLable;
    }
}

