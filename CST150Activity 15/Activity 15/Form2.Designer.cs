namespace Activity_15
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel2.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.ForeColor = System.Drawing.Color.White;
            this.titleLabel2.Location = new System.Drawing.Point(25, 46);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(419, 40);
            this.titleLabel2.TabIndex = 0;
            this.titleLabel2.Text = "Your Lucky Number is:";
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.luckyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel.ForeColor = System.Drawing.Color.White;
            this.luckyNumberLabel.Location = new System.Drawing.Point(203, 147);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(0, 40);
            this.luckyNumberLabel.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 305);
            this.Controls.Add(this.luckyNumberLabel);
            this.Controls.Add(this.titleLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label luckyNumberLabel;
    }
}