namespace BikeRentalGUIFinal
{
    partial class ReturnBicycleScreen
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
            this.chooseLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(305, 254);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(49, 254);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // chooseCombo
            // 
            this.chooseCombo.FormattingEnabled = true;
            this.chooseCombo.Location = new System.Drawing.Point(243, 104);
            this.chooseCombo.Margin = new System.Windows.Forms.Padding(4);
            this.chooseCombo.Name = "chooseCombo";
            this.chooseCombo.Size = new System.Drawing.Size(160, 24);
            this.chooseCombo.TabIndex = 7;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(45, 108);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(171, 17);
            this.chooseLabel.TabIndex = 6;
            this.chooseLabel.Text = "Choose Bicycle to Return:";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Location = new System.Drawing.Point(170, 24);
            this.returnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(99, 17);
            this.returnLabel.TabIndex = 5;
            this.returnLabel.Text = "Return Bicycle";
            // 
            // ReturnBicycleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.chooseCombo);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.returnLabel);
            this.Name = "ReturnBicycleScreen";
            this.Text = "ReturnBicycleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox chooseCombo;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label returnLabel;
    }
}