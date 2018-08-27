namespace BikeRentalGUIFinal
{
    partial class BicycleRentalAgent
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
            this.RentBicycleButton = new System.Windows.Forms.Button();
            this.ReturnBicycleButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.InsertBicycleButton = new System.Windows.Forms.Button();
            this.InsertWorkerButton = new System.Windows.Forms.Button();
            this.ModifyWorkerButton = new System.Windows.Forms.Button();
            this.ModifyBicycleButton = new System.Windows.Forms.Button();
            this.ModifyUserButton = new System.Windows.Forms.Button();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.DeleteBicycleButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RentBicycleButton
            // 
            this.RentBicycleButton.Location = new System.Drawing.Point(41, 69);
            this.RentBicycleButton.Name = "RentBicycleButton";
            this.RentBicycleButton.Size = new System.Drawing.Size(108, 31);
            this.RentBicycleButton.TabIndex = 9;
            this.RentBicycleButton.Text = "Rent Bicycle";
            this.RentBicycleButton.UseVisualStyleBackColor = true;
            this.RentBicycleButton.Click += new System.EventHandler(this.RentBicycle_Click);
            // 
            // ReturnBicycleButton
            // 
            this.ReturnBicycleButton.Location = new System.Drawing.Point(269, 69);
            this.ReturnBicycleButton.Name = "ReturnBicycleButton";
            this.ReturnBicycleButton.Size = new System.Drawing.Size(108, 31);
            this.ReturnBicycleButton.TabIndex = 12;
            this.ReturnBicycleButton.Text = "Return Bicycle";
            this.ReturnBicycleButton.UseVisualStyleBackColor = true;
            this.ReturnBicycleButton.Click += new System.EventHandler(this.ReturnBicycle_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(155, 306);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(108, 31);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.Location = new System.Drawing.Point(269, 135);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(108, 31);
            this.InsertUserButton.TabIndex = 14;
            this.InsertUserButton.Text = "Insert User";
            this.InsertUserButton.UseVisualStyleBackColor = true;
            this.InsertUserButton.Click += new System.EventHandler(this.InsertUser_Click);
            // 
            // InsertBicycleButton
            // 
            this.InsertBicycleButton.Location = new System.Drawing.Point(155, 135);
            this.InsertBicycleButton.Name = "InsertBicycleButton";
            this.InsertBicycleButton.Size = new System.Drawing.Size(108, 31);
            this.InsertBicycleButton.TabIndex = 15;
            this.InsertBicycleButton.Text = "Insert Bicycle";
            this.InsertBicycleButton.UseVisualStyleBackColor = true;
            this.InsertBicycleButton.Click += new System.EventHandler(this.InsertBicycle_Click);
            // 
            // InsertWorkerButton
            // 
            this.InsertWorkerButton.Location = new System.Drawing.Point(41, 135);
            this.InsertWorkerButton.Name = "InsertWorkerButton";
            this.InsertWorkerButton.Size = new System.Drawing.Size(108, 31);
            this.InsertWorkerButton.TabIndex = 16;
            this.InsertWorkerButton.Text = "Insert Worker";
            this.InsertWorkerButton.UseVisualStyleBackColor = true;
            this.InsertWorkerButton.Click += new System.EventHandler(this.InsertWorker_Click);
            // 
            // ModifyWorkerButton
            // 
            this.ModifyWorkerButton.Location = new System.Drawing.Point(41, 172);
            this.ModifyWorkerButton.Name = "ModifyWorkerButton";
            this.ModifyWorkerButton.Size = new System.Drawing.Size(108, 31);
            this.ModifyWorkerButton.TabIndex = 19;
            this.ModifyWorkerButton.Text = "Modify Worker";
            this.ModifyWorkerButton.UseVisualStyleBackColor = true;
            this.ModifyWorkerButton.Click += new System.EventHandler(this.ModifyWorker_Click);
            // 
            // ModifyBicycleButton
            // 
            this.ModifyBicycleButton.Location = new System.Drawing.Point(155, 172);
            this.ModifyBicycleButton.Name = "ModifyBicycleButton";
            this.ModifyBicycleButton.Size = new System.Drawing.Size(108, 31);
            this.ModifyBicycleButton.TabIndex = 18;
            this.ModifyBicycleButton.Text = "Modify Bicycle";
            this.ModifyBicycleButton.UseVisualStyleBackColor = true;
            this.ModifyBicycleButton.Click += new System.EventHandler(this.ModifyBicycle_Click);
            // 
            // ModifyUserButton
            // 
            this.ModifyUserButton.Location = new System.Drawing.Point(269, 172);
            this.ModifyUserButton.Name = "ModifyUserButton";
            this.ModifyUserButton.Size = new System.Drawing.Size(108, 31);
            this.ModifyUserButton.TabIndex = 17;
            this.ModifyUserButton.Text = "Modify User";
            this.ModifyUserButton.UseVisualStyleBackColor = true;
            this.ModifyUserButton.Click += new System.EventHandler(this.ModifyUser_Click);
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(41, 209);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(108, 31);
            this.DeleteWorkerButton.TabIndex = 22;
            this.DeleteWorkerButton.Text = "Delete Worker";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // DeleteBicycleButton
            // 
            this.DeleteBicycleButton.Location = new System.Drawing.Point(155, 209);
            this.DeleteBicycleButton.Name = "DeleteBicycleButton";
            this.DeleteBicycleButton.Size = new System.Drawing.Size(108, 31);
            this.DeleteBicycleButton.TabIndex = 21;
            this.DeleteBicycleButton.Text = "Delete Bicycle";
            this.DeleteBicycleButton.UseVisualStyleBackColor = true;
            this.DeleteBicycleButton.Click += new System.EventHandler(this.DeleteBicycle_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(269, 209);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(108, 31);
            this.DeleteUserButton.TabIndex = 20;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // BicycleRentalAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 373);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.DeleteBicycleButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.ModifyWorkerButton);
            this.Controls.Add(this.ModifyBicycleButton);
            this.Controls.Add(this.ModifyUserButton);
            this.Controls.Add(this.InsertWorkerButton);
            this.Controls.Add(this.InsertBicycleButton);
            this.Controls.Add(this.InsertUserButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReturnBicycleButton);
            this.Controls.Add(this.RentBicycleButton);
            this.Name = "BicycleRentalAgent";
            this.Text = "Brockport Bicycle Rental System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RentBicycleButton;
        private System.Windows.Forms.Button ReturnBicycleButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Button InsertBicycleButton;
        private System.Windows.Forms.Button InsertWorkerButton;
        private System.Windows.Forms.Button ModifyWorkerButton;
        private System.Windows.Forms.Button ModifyBicycleButton;
        private System.Windows.Forms.Button ModifyUserButton;
        private System.Windows.Forms.Button DeleteWorkerButton;
        private System.Windows.Forms.Button DeleteBicycleButton;
        private System.Windows.Forms.Button DeleteUserButton;

    }
}