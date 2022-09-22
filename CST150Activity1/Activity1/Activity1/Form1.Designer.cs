namespace My_First_Project
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
            this.submitButton = new System.Windows.Forms.Button();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rememberMeRadioButton = new System.Windows.Forms.RadioButton();
            this.autoLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.latestProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.forgetLoginRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(224, 390);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 41);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(224, 125);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(234, 26);
            this.enterNameTextBox.TabIndex = 1;
            this.enterNameTextBox.Text = "Username or Email Address";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(224, 183);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(234, 26);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Password";
            // 
            // rememberMeRadioButton
            // 
            this.rememberMeRadioButton.AutoSize = true;
            this.rememberMeRadioButton.Location = new System.Drawing.Point(224, 215);
            this.rememberMeRadioButton.Name = "rememberMeRadioButton";
            this.rememberMeRadioButton.Size = new System.Drawing.Size(156, 24);
            this.rememberMeRadioButton.TabIndex = 3;
            this.rememberMeRadioButton.TabStop = true;
            this.rememberMeRadioButton.Text = "Remember Login";
            this.rememberMeRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoLoginCheckBox
            // 
            this.autoLoginCheckBox.AutoSize = true;
            this.autoLoginCheckBox.Location = new System.Drawing.Point(224, 307);
            this.autoLoginCheckBox.Name = "autoLoginCheckBox";
            this.autoLoginCheckBox.Size = new System.Drawing.Size(166, 24);
            this.autoLoginCheckBox.TabIndex = 4;
            this.autoLoginCheckBox.Text = "Keep me logged in";
            this.autoLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // latestProjectCheckBox
            // 
            this.latestProjectCheckBox.AutoSize = true;
            this.latestProjectCheckBox.Location = new System.Drawing.Point(224, 337);
            this.latestProjectCheckBox.Name = "latestProjectCheckBox";
            this.latestProjectCheckBox.Size = new System.Drawing.Size(176, 24);
            this.latestProjectCheckBox.TabIndex = 5;
            this.latestProjectCheckBox.Text = "Open Latest Project";
            this.latestProjectCheckBox.UseVisualStyleBackColor = true;
            this.latestProjectCheckBox.CheckedChanged += new System.EventHandler(this.latestProjectCheckBox_CheckedChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(72, 128);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(134, 20);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Enter Username: ";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(77, 189);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 20);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Enter Password: ";
            // 
            // forgetLoginRadioButton
            // 
            this.forgetLoginRadioButton.AutoSize = true;
            this.forgetLoginRadioButton.Location = new System.Drawing.Point(224, 245);
            this.forgetLoginRadioButton.Name = "forgetLoginRadioButton";
            this.forgetLoginRadioButton.Size = new System.Drawing.Size(124, 24);
            this.forgetLoginRadioButton.TabIndex = 8;
            this.forgetLoginRadioButton.TabStop = true;
            this.forgetLoginRadioButton.Text = "Forget Login";
            this.forgetLoginRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 485);
            this.Controls.Add(this.forgetLoginRadioButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.latestProjectCheckBox);
            this.Controls.Add(this.autoLoginCheckBox);
            this.Controls.Add(this.rememberMeRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Activity 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.RadioButton rememberMeRadioButton;
        private System.Windows.Forms.CheckBox autoLoginCheckBox;
        private System.Windows.Forms.CheckBox latestProjectCheckBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.RadioButton forgetLoginRadioButton;
    }
}

