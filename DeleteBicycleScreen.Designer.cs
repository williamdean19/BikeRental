namespace BikeRentalGUIFinal
{
    partial class DeleteBicycleScreen
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
            this.DeleteNotification = new System.Windows.Forms.Label();
            this.UserIDToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteUserTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteNotification
            // 
            this.DeleteNotification.AutoSize = true;
            this.DeleteNotification.Location = new System.Drawing.Point(75, 264);
            this.DeleteNotification.Name = "DeleteNotification";
            this.DeleteNotification.Size = new System.Drawing.Size(0, 17);
            this.DeleteNotification.TabIndex = 17;
            // 
            // UserIDToDeleteTextBox
            // 
            this.UserIDToDeleteTextBox.Location = new System.Drawing.Point(201, 123);
            this.UserIDToDeleteTextBox.Name = "UserIDToDeleteTextBox";
            this.UserIDToDeleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDToDeleteTextBox.TabIndex = 16;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(78, 171);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(226, 171);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bike ID";
            // 
            // DeleteUserTitle
            // 
            this.DeleteUserTitle.AutoSize = true;
            this.DeleteUserTitle.Location = new System.Drawing.Point(95, 53);
            this.DeleteUserTitle.Name = "DeleteUserTitle";
            this.DeleteUserTitle.Size = new System.Drawing.Size(151, 17);
            this.DeleteUserTitle.TabIndex = 12;
            this.DeleteUserTitle.Text = "Enter Bike ID to Delete";
            // 
            // DeleteBicycleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 337);
            this.Controls.Add(this.DeleteNotification);
            this.Controls.Add(this.UserIDToDeleteTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteUserTitle);
            this.Name = "DeleteBicycleScreen";
            this.Text = "DeleteBicycleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteNotification;
        private System.Windows.Forms.TextBox UserIDToDeleteTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeleteUserTitle;
    }
}