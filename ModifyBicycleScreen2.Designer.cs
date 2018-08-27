namespace BikeRentalGUIFinal
{
    partial class ModifyBicycleScreen2
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
            this.workerInputLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.physicalCondition = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.physicalConditionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // workerInputLabel
            // 
            this.workerInputLabel.AutoSize = true;
            this.workerInputLabel.Location = new System.Drawing.Point(130, 9);
            this.workerInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workerInputLabel.Name = "workerInputLabel";
            this.workerInputLabel.Size = new System.Drawing.Size(107, 17);
            this.workerInputLabel.TabIndex = 66;
            this.workerInputLabel.Text = "Edit Bicyle Data";
            this.workerInputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(216, 301);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 65;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(47, 301);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 64;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(216, 207);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(132, 22);
            this.statusBox.TabIndex = 63;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(216, 180);
            this.notesBox.Margin = new System.Windows.Forms.Padding(4);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(132, 22);
            this.notesBox.TabIndex = 62;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(216, 123);
            this.locationBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(132, 22);
            this.locationBox.TabIndex = 60;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(216, 95);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(132, 22);
            this.descriptionBox.TabIndex = 59;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(216, 68);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(132, 22);
            this.colorBox.TabIndex = 58;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(4, 211);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 17);
            this.status.TabIndex = 54;
            this.status.Text = "Status";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(4, 184);
            this.notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(45, 17);
            this.notes.TabIndex = 53;
            this.notes.Text = "Notes";
            // 
            // physicalCondition
            // 
            this.physicalCondition.AutoSize = true;
            this.physicalCondition.Location = new System.Drawing.Point(4, 157);
            this.physicalCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.physicalCondition.Name = "physicalCondition";
            this.physicalCondition.Size = new System.Drawing.Size(123, 17);
            this.physicalCondition.TabIndex = 52;
            this.physicalCondition.Text = "Physical Condition";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(4, 127);
            this.location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(62, 17);
            this.location.TabIndex = 51;
            this.location.Text = "Location";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(4, 99);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(79, 17);
            this.description.TabIndex = 50;
            this.description.Text = "Description";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(4, 72);
            this.color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(41, 17);
            this.color.TabIndex = 49;
            this.color.Text = "Color";
            // 
            // physicalConditionBox
            // 
            this.physicalConditionBox.Location = new System.Drawing.Point(216, 151);
            this.physicalConditionBox.Name = "physicalConditionBox";
            this.physicalConditionBox.Size = new System.Drawing.Size(132, 22);
            this.physicalConditionBox.TabIndex = 67;
            // 
            // ModifyBicycleScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 420);
            this.Controls.Add(this.physicalConditionBox);
            this.Controls.Add(this.workerInputLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.physicalCondition);
            this.Controls.Add(this.location);
            this.Controls.Add(this.description);
            this.Controls.Add(this.color);
            this.Name = "ModifyBicycleScreen2";
            this.Text = "ModifyBicycleScreen2";
            this.Load += new System.EventHandler(this.ModifyBicycleScreen2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerInputLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label physicalCondition;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox physicalConditionBox;
    }
}