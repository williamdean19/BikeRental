﻿namespace BikeRentalGUIFinal
{
    partial class ModifyWorkerScreen2
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewWorkerNotificationLabel = new System.Windows.Forms.Label();
            this.UserTypeTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.ModifyDataTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(225, 331);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 60;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewWorkerNotificationLabel
            // 
            this.NewWorkerNotificationLabel.AutoSize = true;
            this.NewWorkerNotificationLabel.Location = new System.Drawing.Point(16, 397);
            this.NewWorkerNotificationLabel.Name = "NewWorkerNotificationLabel";
            this.NewWorkerNotificationLabel.Size = new System.Drawing.Size(0, 17);
            this.NewWorkerNotificationLabel.TabIndex = 59;
            // 
            // UserTypeTextBox
            // 
            this.UserTypeTextBox.Location = new System.Drawing.Point(194, 195);
            this.UserTypeTextBox.Name = "UserTypeTextBox";
            this.UserTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserTypeTextBox.TabIndex = 58;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(194, 167);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 57;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(194, 139);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberTextBox.TabIndex = 56;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(194, 111);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.LastNameTextBox.TabIndex = 55;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(194, 83);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNameTextBox.TabIndex = 54;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(194, 223);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(100, 22);
            this.NotesTextBox.TabIndex = 53;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(63, 331);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 51;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(77, 88);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 50;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(77, 116);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.LastNameLabel.TabIndex = 49;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(77, 144);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumberLabel.TabIndex = 48;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(77, 172);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 47;
            this.EmailLabel.Text = "Email";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(77, 200);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.UserTypeLabel.TabIndex = 46;
            this.UserTypeLabel.Text = "Credential";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(77, 228);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(45, 17);
            this.NotesLabel.TabIndex = 45;
            this.NotesLabel.Text = "Notes";
            // 
            // ModifyDataTitle
            // 
            this.ModifyDataTitle.AutoSize = true;
            this.ModifyDataTitle.Location = new System.Drawing.Point(105, 36);
            this.ModifyDataTitle.Name = "ModifyDataTitle";
            this.ModifyDataTitle.Size = new System.Drawing.Size(193, 17);
            this.ModifyDataTitle.TabIndex = 43;
            this.ModifyDataTitle.Text = "Change Existing Worker Data";
            // 
            // ModifyWorkerScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 445);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewWorkerNotificationLabel);
            this.Controls.Add(this.UserTypeTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserTypeLabel);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.ModifyDataTitle);
            this.Name = "ModifyWorkerScreen2";
            this.Text = "ModifyWorkerScreen2";
            this.Load += new System.EventHandler(this.ModifyWorkerScreen2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NewWorkerNotificationLabel;
        private System.Windows.Forms.TextBox UserTypeTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label ModifyDataTitle;

    }
}