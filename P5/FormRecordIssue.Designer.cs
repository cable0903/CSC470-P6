namespace Builder
{
    partial class FormRecordIssue
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
            this.cancelRecordButton = new System.Windows.Forms.Button();
            this.createIssueButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.discoveryDate = new System.Windows.Forms.Label();
            this.discoverer = new System.Windows.Forms.Label();
            this.component = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.intialDescription = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelRecordButton
            // 
            this.cancelRecordButton.Location = new System.Drawing.Point(271, 490);
            this.cancelRecordButton.Name = "cancelRecordButton";
            this.cancelRecordButton.Size = new System.Drawing.Size(91, 23);
            this.cancelRecordButton.TabIndex = 0;
            this.cancelRecordButton.Text = "Cancel";
            this.cancelRecordButton.UseVisualStyleBackColor = true;
            // 
            // createIssueButton
            // 
            this.createIssueButton.Location = new System.Drawing.Point(387, 490);
            this.createIssueButton.Name = "createIssueButton";
            this.createIssueButton.Size = new System.Drawing.Size(90, 23);
            this.createIssueButton.TabIndex = 1;
            this.createIssueButton.Text = "Create Issue";
            this.createIssueButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(366, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(366, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // statusBox
            // 
            this.statusBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Open",
            "Assigned",
            "Fixed",
            "Closed - Won\'t Fix",
            "Closed - Fixed",
            "Closed - by design"});
            this.statusBox.Location = new System.Drawing.Point(111, 184);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(366, 21);
            this.statusBox.TabIndex = 7;
            this.statusBox.Text = "Open";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(86, 58);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "Id:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(75, 81);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 9;
            this.Title.Text = "Title:";
            // 
            // discoveryDate
            // 
            this.discoveryDate.AutoSize = true;
            this.discoveryDate.Location = new System.Drawing.Point(22, 107);
            this.discoveryDate.Name = "discoveryDate";
            this.discoveryDate.Size = new System.Drawing.Size(83, 13);
            this.discoveryDate.TabIndex = 10;
            this.discoveryDate.Text = "Discovery Date:";
            // 
            // discoverer
            // 
            this.discoverer.AutoSize = true;
            this.discoverer.Location = new System.Drawing.Point(44, 134);
            this.discoverer.Name = "discoverer";
            this.discoverer.Size = new System.Drawing.Size(61, 13);
            this.discoverer.TabIndex = 11;
            this.discoverer.Text = "Discoverer:";
            // 
            // component
            // 
            this.component.AutoSize = true;
            this.component.Location = new System.Drawing.Point(41, 161);
            this.component.Name = "component";
            this.component.Size = new System.Drawing.Size(64, 13);
            this.component.TabIndex = 12;
            this.component.Text = "Component:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(65, 187);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 13;
            this.status.Text = "Status:";
            // 
            // intialDescription
            // 
            this.intialDescription.AutoSize = true;
            this.intialDescription.Location = new System.Drawing.Point(70, 219);
            this.intialDescription.Name = "intialDescription";
            this.intialDescription.Size = new System.Drawing.Size(87, 13);
            this.intialDescription.TabIndex = 14;
            this.intialDescription.Text = "Initial Description";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 225);
            this.listBox1.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 16;
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 539);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.intialDescription);
            this.Controls.Add(this.status);
            this.Controls.Add(this.component);
            this.Controls.Add(this.discoverer);
            this.Controls.Add(this.discoveryDate);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createIssueButton);
            this.Controls.Add(this.cancelRecordButton);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelRecordButton;
        private System.Windows.Forms.Button createIssueButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label discoveryDate;
        private System.Windows.Forms.Label discoverer;
        private System.Windows.Forms.Label component;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label intialDescription;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}