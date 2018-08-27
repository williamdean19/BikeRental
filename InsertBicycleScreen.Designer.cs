namespace BikeRentalGUIFinal
{
    partial class InsertBicycleScreen
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
            System.Windows.Forms.TextBox physicalConditionBox;
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.serialNumberBox = new System.Windows.Forms.TextBox();
            this.modelNumberBox = new System.Windows.Forms.TextBox();
            this.bikeMakeBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.physicalCondition = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.Label();
            this.modelNumber = new System.Windows.Forms.Label();
            this.bikeMake = new System.Windows.Forms.Label();
            this.workerInputLabel = new System.Windows.Forms.Label();
            physicalConditionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // physicalConditionBox
            // 
            physicalConditionBox.Location = new System.Drawing.Point(246, 219);
            physicalConditionBox.Margin = new System.Windows.Forms.Padding(4);
            physicalConditionBox.Name = "physicalConditionBox";
            physicalConditionBox.Size = new System.Drawing.Size(132, 22);
            physicalConditionBox.TabIndex = 39;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(246, 341);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 44;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(77, 341);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 43;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(246, 273);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(132, 22);
            this.statusBox.TabIndex = 41;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(246, 246);
            this.notesBox.Margin = new System.Windows.Forms.Padding(4);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(132, 22);
            this.notesBox.TabIndex = 40;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(246, 189);
            this.locationBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(132, 22);
            this.locationBox.TabIndex = 38;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(246, 161);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(132, 22);
            this.descriptionBox.TabIndex = 37;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(246, 134);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(132, 22);
            this.colorBox.TabIndex = 36;
            // 
            // serialNumberBox
            // 
            this.serialNumberBox.Location = new System.Drawing.Point(246, 106);
            this.serialNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialNumberBox.Name = "serialNumberBox";
            this.serialNumberBox.Size = new System.Drawing.Size(132, 22);
            this.serialNumberBox.TabIndex = 35;
            // 
            // modelNumberBox
            // 
            this.modelNumberBox.Location = new System.Drawing.Point(246, 76);
            this.modelNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelNumberBox.Name = "modelNumberBox";
            this.modelNumberBox.Size = new System.Drawing.Size(132, 22);
            this.modelNumberBox.TabIndex = 34;
            // 
            // bikeMakeBox
            // 
            this.bikeMakeBox.Location = new System.Drawing.Point(246, 47);
            this.bikeMakeBox.Margin = new System.Windows.Forms.Padding(4);
            this.bikeMakeBox.Name = "bikeMakeBox";
            this.bikeMakeBox.Size = new System.Drawing.Size(132, 22);
            this.bikeMakeBox.TabIndex = 33;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(34, 277);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 17);
            this.status.TabIndex = 31;
            this.status.Text = "Status";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(34, 250);
            this.notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(45, 17);
            this.notes.TabIndex = 30;
            this.notes.Text = "Notes";
            // 
            // physicalCondition
            // 
            this.physicalCondition.AutoSize = true;
            this.physicalCondition.Location = new System.Drawing.Point(34, 223);
            this.physicalCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.physicalCondition.Name = "physicalCondition";
            this.physicalCondition.Size = new System.Drawing.Size(123, 17);
            this.physicalCondition.TabIndex = 29;
            this.physicalCondition.Text = "Physical Condition";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(34, 193);
            this.location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(62, 17);
            this.location.TabIndex = 28;
            this.location.Text = "Location";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(34, 165);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(79, 17);
            this.description.TabIndex = 27;
            this.description.Text = "Description";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(34, 138);
            this.color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(41, 17);
            this.color.TabIndex = 26;
            this.color.Text = "Color";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(34, 109);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(98, 17);
            this.serialNumber.TabIndex = 25;
            this.serialNumber.Text = "Serial Number";
            // 
            // modelNumber
            // 
            this.modelNumber.AutoSize = true;
            this.modelNumber.Location = new System.Drawing.Point(34, 80);
            this.modelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelNumber.Name = "modelNumber";
            this.modelNumber.Size = new System.Drawing.Size(100, 17);
            this.modelNumber.TabIndex = 24;
            this.modelNumber.Text = "Model Number";
            // 
            // bikeMake
            // 
            this.bikeMake.AutoSize = true;
            this.bikeMake.Location = new System.Drawing.Point(33, 50);
            this.bikeMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bikeMake.Name = "bikeMake";
            this.bikeMake.Size = new System.Drawing.Size(73, 17);
            this.bikeMake.TabIndex = 23;
            this.bikeMake.Text = "Bike Make";
            // 
            // workerInputLabel
            // 
            this.workerInputLabel.AutoSize = true;
            this.workerInputLabel.Location = new System.Drawing.Point(117, 9);
            this.workerInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workerInputLabel.Name = "workerInputLabel";
            this.workerInputLabel.Size = new System.Drawing.Size(148, 17);
            this.workerInputLabel.TabIndex = 45;
            this.workerInputLabel.Text = "Enter New Bicyle Data";
            this.workerInputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InsertBicycleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 417);
            this.Controls.Add(this.workerInputLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(physicalConditionBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.serialNumberBox);
            this.Controls.Add(this.modelNumberBox);
            this.Controls.Add(this.bikeMakeBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.physicalCondition);
            this.Controls.Add(this.location);
            this.Controls.Add(this.description);
            this.Controls.Add(this.color);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.modelNumber);
            this.Controls.Add(this.bikeMake);
            this.Name = "InsertBicycleScreen";
            this.Text = "InsertBicycleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox serialNumberBox;
        private System.Windows.Forms.TextBox modelNumberBox;
        private System.Windows.Forms.TextBox bikeMakeBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label physicalCondition;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label serialNumber;
        private System.Windows.Forms.Label modelNumber;
        private System.Windows.Forms.Label bikeMake;
        private System.Windows.Forms.Label workerInputLabel;
    }
}