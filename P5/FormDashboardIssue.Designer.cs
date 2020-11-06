namespace Builder
{
    partial class FormDashboardIssue
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
            this.totalNumIssues = new System.Windows.Forms.Label();
            this.monthIssue = new System.Windows.Forms.Label();
            this.discoveryIssues = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalNumIssues
            // 
            this.totalNumIssues.AutoSize = true;
            this.totalNumIssues.Location = new System.Drawing.Point(49, 59);
            this.totalNumIssues.Name = "totalNumIssues";
            this.totalNumIssues.Size = new System.Drawing.Size(122, 13);
            this.totalNumIssues.TabIndex = 0;
            this.totalNumIssues.Text = "Total Number of Issues: ";
            // 
            // monthIssue
            // 
            this.monthIssue.AutoSize = true;
            this.monthIssue.Location = new System.Drawing.Point(49, 110);
            this.monthIssue.Name = "monthIssue";
            this.monthIssue.Size = new System.Drawing.Size(84, 13);
            this.monthIssue.TabIndex = 1;
            this.monthIssue.Text = "Issues by Month";
            // 
            // discoveryIssues
            // 
            this.discoveryIssues.AutoSize = true;
            this.discoveryIssues.Location = new System.Drawing.Point(49, 258);
            this.discoveryIssues.Name = "discoveryIssues";
            this.discoveryIssues.Size = new System.Drawing.Size(101, 13);
            this.discoveryIssues.TabIndex = 2;
            this.discoveryIssues.Text = "Issues by Discovery";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 108);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(52, 274);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 95);
            this.listBox2.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(212, 391);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 37);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // FormDashboardIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 440);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.discoveryIssues);
            this.Controls.Add(this.monthIssue);
            this.Controls.Add(this.totalNumIssues);
            this.Name = "FormDashboardIssue";
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalNumIssues;
        private System.Windows.Forms.Label monthIssue;
        private System.Windows.Forms.Label discoveryIssues;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button closeButton;
    }
}