﻿namespace P5
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.labelDis = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStat = new System.Windows.Forms.Label();
            this.textBoxIssueID = new System.Windows.Forms.TextBox();
            this.textBoxIssueTitle = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.textBoxInitialDescription = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimeDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.comboBoxIssueStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(91, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(80, 71);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(32, 151);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(84, 17);
            this.labelComp.TabIndex = 4;
            this.labelComp.Text = "Component:";
            // 
            // labelDis
            // 
            this.labelDis.AutoSize = true;
            this.labelDis.Location = new System.Drawing.Point(39, 124);
            this.labelDis.Name = "labelDis";
            this.labelDis.Size = new System.Drawing.Size(80, 17);
            this.labelDis.TabIndex = 5;
            this.labelDis.Text = "Discoverer:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(108, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Discovery Date:";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(64, 176);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(52, 17);
            this.labelStat.TabIndex = 3;
            this.labelStat.Text = "Status:";
            // 
            // textBoxIssueID
            // 
            this.textBoxIssueID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxIssueID.Location = new System.Drawing.Point(123, 46);
            this.textBoxIssueID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIssueID.Name = "textBoxIssueID";
            this.textBoxIssueID.ReadOnly = true;
            this.textBoxIssueID.Size = new System.Drawing.Size(89, 22);
            this.textBoxIssueID.TabIndex = 7;
            // 
            // textBoxIssueTitle
            // 
            this.textBoxIssueTitle.Location = new System.Drawing.Point(123, 71);
            this.textBoxIssueTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIssueTitle.Name = "textBoxIssueTitle";
            this.textBoxIssueTitle.Size = new System.Drawing.Size(356, 22);
            this.textBoxIssueTitle.TabIndex = 8;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(64, 199);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(116, 17);
            this.labelDes.TabIndex = 9;
            this.labelDes.Text = "Intial Description:";
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(123, 151);
            this.textBoxComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(356, 22);
            this.textBoxComponent.TabIndex = 10;
            // 
            // textBoxInitialDescription
            // 
            this.textBoxInitialDescription.Location = new System.Drawing.Point(123, 218);
            this.textBoxInitialDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInitialDescription.Multiline = true;
            this.textBoxInitialDescription.Name = "textBoxInitialDescription";
            this.textBoxInitialDescription.Size = new System.Drawing.Size(356, 218);
            this.textBoxInitialDescription.TabIndex = 11;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(353, 473);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(124, 23);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Create Issue";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(188, 473);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimeDiscoveryDate
            // 
            this.dateTimeDiscoveryDate.Location = new System.Drawing.Point(123, 100);
            this.dateTimeDiscoveryDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeDiscoveryDate.Name = "dateTimeDiscoveryDate";
            this.dateTimeDiscoveryDate.Size = new System.Drawing.Size(356, 22);
            this.dateTimeDiscoveryDate.TabIndex = 14;
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(123, 124);
            this.comboBoxDiscoverer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(356, 24);
            this.comboBoxDiscoverer.TabIndex = 15;
            // 
            // comboBoxIssueStatus
            // 
            this.comboBoxIssueStatus.FormattingEnabled = true;
            this.comboBoxIssueStatus.Location = new System.Drawing.Point(123, 176);
            this.comboBoxIssueStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIssueStatus.Name = "comboBoxIssueStatus";
            this.comboBoxIssueStatus.Size = new System.Drawing.Size(356, 24);
            this.comboBoxIssueStatus.TabIndex = 16;
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 540);
            this.Controls.Add(this.comboBoxIssueStatus);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.dateTimeDiscoveryDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxInitialDescription);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.textBoxIssueTitle);
            this.Controls.Add(this.textBoxIssueID);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDis);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecordIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.Label labelDis;
        private System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.TextBox textBoxIssueID;
        private System.Windows.Forms.TextBox textBoxIssueTitle;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.TextBox textBoxInitialDescription;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimeDiscoveryDate;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.Windows.Forms.ComboBox comboBoxIssueStatus;
    }
}