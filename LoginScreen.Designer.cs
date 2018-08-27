namespace BikeRentalGUIFinal
{
    partial class LoginScreen
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.WorkerIdText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.WorkerIdLabel = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(61, 230);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.submit_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(204, 230);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.close_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(179, 158);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(100, 22);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // WorkerIdText
            // 
            this.WorkerIdText.Location = new System.Drawing.Point(179, 111);
            this.WorkerIdText.Name = "WorkerIdText";
            this.WorkerIdText.Size = new System.Drawing.Size(100, 22);
            this.WorkerIdText.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(85, 163);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // WorkerIdLabel
            // 
            this.WorkerIdLabel.AutoSize = true;
            this.WorkerIdLabel.Location = new System.Drawing.Point(85, 116);
            this.WorkerIdLabel.Name = "WorkerIdLabel";
            this.WorkerIdLabel.Size = new System.Drawing.Size(71, 17);
            this.WorkerIdLabel.TabIndex = 5;
            this.WorkerIdLabel.Text = "Worker ID";
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Location = new System.Drawing.Point(60, 30);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(219, 17);
            this.Title1.TabIndex = 6;
            this.Title1.Text = "Welcome to the Brockport Bicycle";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Location = new System.Drawing.Point(120, 47);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(99, 17);
            this.Title2.TabIndex = 7;
            this.Title2.Text = "Rental System";
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(2, 283);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(322, 17);
            this.NotificationLabel.TabIndex = 8;
            this.NotificationLabel.Text = "Welcome.  Please enter Worker ID and Password.";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(350, 309);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.WorkerIdLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.WorkerIdText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SubmitButton);
            this.Name = "LoginScreen";
            this.Text = "Brockport Bicycle Rental System";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox WorkerIdText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label WorkerIdLabel;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label NotificationLabel;
    }
}

