﻿using My_college_project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_college_project.Forms
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!NavigationService.isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
