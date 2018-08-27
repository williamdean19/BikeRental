namespace BikeRentalGUIFinal
{
    partial class ModifyWorkerScreen
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
            this.UserIDToModifyTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyUserTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserIDToModifyTextBox
            // 
            this.UserIDToModifyTextBox.Location = new System.Drawing.Point(193, 119);
            this.UserIDToModifyTextBox.Name = "UserIDToModifyTextBox";
            this.UserIDToModifyTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDToModifyTextBox.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(49, 167);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(202, 167);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Worker Banner ID to Modify";
            // 
            // ModifyUserTitle
            // 
            this.ModifyUserTitle.AutoSize = true;
            this.ModifyUserTitle.Location = new System.Drawing.Point(88, 55);
            this.ModifyUserTitle.Name = "ModifyUserTitle";
            this.ModifyUserTitle.Size = new System.Drawing.Size(170, 17);
            this.ModifyUserTitle.TabIndex = 10;
            this.ModifyUserTitle.Text = "Enter Worker ID to Modify";
            // 
            // ModifyWorkerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 264);
            this.Controls.Add(this.UserIDToModifyTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModifyUserTitle);
            this.Name = "ModifyWorkerScreen";
            this.Text = "ModifyWorkerScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIDToModifyTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ModifyUserTitle;
    }
}