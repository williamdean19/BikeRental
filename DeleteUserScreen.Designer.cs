namespace BikeRentalGUIFinal
{
    partial class DeleteUserScreen
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
            this.DeleteUserTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UserIDToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteUserTitle
            // 
            this.DeleteUserTitle.AutoSize = true;
            this.DeleteUserTitle.Location = new System.Drawing.Point(97, 44);
            this.DeleteUserTitle.Name = "DeleteUserTitle";
            this.DeleteUserTitle.Size = new System.Drawing.Size(154, 17);
            this.DeleteUserTitle.TabIndex = 0;
            this.DeleteUserTitle.Text = "Enter User ID to Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banner ID of user to Delete";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(200, 159);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(52, 159);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UserIDToDeleteTextBox
            // 
            this.UserIDToDeleteTextBox.Location = new System.Drawing.Point(216, 108);
            this.UserIDToDeleteTextBox.Name = "UserIDToDeleteTextBox";
            this.UserIDToDeleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDToDeleteTextBox.TabIndex = 4;
            // 
            // DeleteNotification
            // 
            this.DeleteNotification.AutoSize = true;
            this.DeleteNotification.Location = new System.Drawing.Point(49, 252);
            this.DeleteNotification.Name = "DeleteNotification";
            this.DeleteNotification.Size = new System.Drawing.Size(0, 17);
            this.DeleteNotification.TabIndex = 5;
            // 
            // DeleteUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 286);
            this.Controls.Add(this.DeleteNotification);
            this.Controls.Add(this.UserIDToDeleteTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteUserTitle);
            this.Name = "DeleteUserScreen";
            this.Text = "DeleteUserScreen";
            this.Load += new System.EventHandler(this.DeleteUserScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteUserTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox UserIDToDeleteTextBox;
        private System.Windows.Forms.Label DeleteNotification;
    }
}