namespace BikeRentalGUIFinal
{
    partial class RentBicycleScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.chooseCombo = new System.Windows.Forms.ComboBox();
            this.renterTextBox = new System.Windows.Forms.TextBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.rentTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(222, 248);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(74, 248);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // chooseCombo
            // 
            this.chooseCombo.FormattingEnabled = true;
            this.chooseCombo.Location = new System.Drawing.Point(222, 166);
            this.chooseCombo.Margin = new System.Windows.Forms.Padding(4);
            this.chooseCombo.Name = "chooseCombo";
            this.chooseCombo.Size = new System.Drawing.Size(132, 24);
            this.chooseCombo.TabIndex = 11;
            // 
            // renterTextBox
            // 
            this.renterTextBox.Location = new System.Drawing.Point(222, 107);
            this.renterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.renterTextBox.Name = "renterTextBox";
            this.renterTextBox.Size = new System.Drawing.Size(132, 22);
            this.renterTextBox.TabIndex = 10;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(27, 176);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(108, 17);
            this.chooseLabel.TabIndex = 9;
            this.chooseLabel.Text = "Choose Bicycle:";
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(27, 107);
            this.enterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(158, 17);
            this.enterLabel.TabIndex = 8;
            this.enterLabel.Text = "Enter Renter Banner Id:";
            // 
            // rentTitle
            // 
            this.rentTitle.AutoSize = true;
            this.rentTitle.Location = new System.Drawing.Point(156, 29);
            this.rentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentTitle.Name = "rentTitle";
            this.rentTitle.Size = new System.Drawing.Size(98, 17);
            this.rentTitle.TabIndex = 7;
            this.rentTitle.Text = "Rent a Bicycle";
            this.rentTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RentBicycleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 354);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.chooseCombo);
            this.Controls.Add(this.renterTextBox);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.rentTitle);
            this.Name = "RentBicycleScreen";
            this.Text = "RentBicycleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox chooseCombo;
        private System.Windows.Forms.TextBox renterTextBox;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label rentTitle;
    }
}