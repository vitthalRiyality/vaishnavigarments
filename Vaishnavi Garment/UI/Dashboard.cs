﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Vaishnavi_Garment.UI;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaishnavi_Garment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.Show();
        }
    }
}
