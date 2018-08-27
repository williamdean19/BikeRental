namespace BikeRentalGUIFinal
{
    partial class ModifyUserScreen
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyUserTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserIDToModifyTextBox
            // 
            this.UserIDToModifyTextBox.Location = new System.Drawing.Point(177, 104);
            this.UserIDToModifyTextBox.Name = "UserIDToModifyTextBox";
            this.UserIDToModifyTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDToModifyTextBox.TabIndex = 9;
            this.UserIDToModifyTextBox.TextChanged += new System.EventHandler(this.UserIDToDeleteTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(49, 152);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Search";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(177, 152);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Banner ID to Modify";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ModifyUserTitle
            // 
            this.ModifyUserTitle.AutoSize = true;
            this.ModifyUserTitle.Location = new System.Drawing.Point(81, 47);
            this.ModifyUserTitle.Name = "ModifyUserTitle";
            this.ModifyUserTitle.Size = new System.Drawing.Size(154, 17);
            this.ModifyUserTitle.TabIndex = 5;
            this.ModifyUserTitle.Text = "Enter User ID to Modify";
            this.ModifyUserTitle.Click += new System.EventHandler(this.DeleteUserTitle_Click);
            // 
            // ModifyUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 233);
            this.Controls.Add(this.UserIDToModifyTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModifyUserTitle);
            this.Name = "ModifyUserScreen";
            this.Text = "ModifyUserScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIDToModifyTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ModifyUserTitle;
    }
}