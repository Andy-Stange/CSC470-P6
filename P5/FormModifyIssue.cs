﻿using P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    
    public partial class FormModifyIssue : Form
    {
        public int _selectID;
        public FormModifyIssue()
        {
            InitializeComponent();
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            FormModifySelectIssue modify = new FormModifySelectIssue();
            _selectID = modify._selectedID;

            FakeIssueRepository iss = new FakeIssueRepository();
            Issue i2 = iss.GetIssueByID(_selectID);
            modID.Text = Convert.ToString(i2.ID);
            modTitle.Text = i2.Title;
            modDateTime.Text = Convert.ToString(i2.DiscoveryDate);
            modDis.Text = i2.Discoverer;
            modComp.Text = i2.Component;
            modStatus.Text = Convert.ToString(i2.IssueStatusID);
            modDes.Text = i2.InitialDescription;

        }
    }
}
