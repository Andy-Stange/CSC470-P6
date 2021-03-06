﻿namespace Builder
{
    partial class FormDashIssue
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
            this.issueLabel = new System.Windows.Forms.Label();
            this.issueNumber = new System.Windows.Forms.Label();
            this.issueMonth = new System.Windows.Forms.Label();
            this.listMonth = new System.Windows.Forms.ListBox();
            this.issueDis = new System.Windows.Forms.Label();
            this.listDis = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(80, 57);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(158, 17);
            this.issueLabel.TabIndex = 0;
            this.issueLabel.Text = "Total Number of Issues:";
            // 
            // issueNumber
            // 
            this.issueNumber.AutoSize = true;
            this.issueNumber.Location = new System.Drawing.Point(243, 57);
            this.issueNumber.Name = "issueNumber";
            this.issueNumber.Size = new System.Drawing.Size(68, 17);
            this.issueNumber.TabIndex = 1;
            this.issueNumber.Text = "labelssue";
            // 
            // issueMonth
            // 
            this.issueMonth.AutoSize = true;
            this.issueMonth.Location = new System.Drawing.Point(80, 111);
            this.issueMonth.Name = "issueMonth";
            this.issueMonth.Size = new System.Drawing.Size(110, 17);
            this.issueMonth.TabIndex = 2;
            this.issueMonth.Text = "Issues by Month";
            // 
            // listMonth
            // 
            this.listMonth.FormattingEnabled = true;
            this.listMonth.ItemHeight = 16;
            this.listMonth.Location = new System.Drawing.Point(84, 130);
            this.listMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMonth.Name = "listMonth";
            this.listMonth.Size = new System.Drawing.Size(292, 132);
            this.listMonth.TabIndex = 3;
            // 
            // issueDis
            // 
            this.issueDis.AutoSize = true;
            this.issueDis.Location = new System.Drawing.Point(80, 301);
            this.issueDis.Name = "issueDis";
            this.issueDis.Size = new System.Drawing.Size(139, 17);
            this.issueDis.TabIndex = 4;
            this.issueDis.Text = "Issues by Discoverer";
            // 
            // listDis
            // 
            this.listDis.FormattingEnabled = true;
            this.listDis.ItemHeight = 16;
            this.listDis.Location = new System.Drawing.Point(84, 319);
            this.listDis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDis.Name = "listDis";
            this.listDis.Size = new System.Drawing.Size(292, 132);
            this.listDis.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(286, 473);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(89, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDashIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 555);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listDis);
            this.Controls.Add(this.issueDis);
            this.Controls.Add(this.listMonth);
            this.Controls.Add(this.issueMonth);
            this.Controls.Add(this.issueNumber);
            this.Controls.Add(this.issueLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDashIssue";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormDashIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Label issueNumber;
        private System.Windows.Forms.Label issueMonth;
        private System.Windows.Forms.ListBox listMonth;
        private System.Windows.Forms.Label issueDis;
        private System.Windows.Forms.ListBox listDis;
        private System.Windows.Forms.Button buttonCancel;
    }
}