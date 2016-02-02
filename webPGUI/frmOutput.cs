﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlavaGu.ConsoleAppLauncher;

namespace webPGUI
{
    public partial class frmOutput : Form
    {
        public frmOutput()
        {
            InitializeComponent();
        }

        private void frmOutput_Load(object sender, EventArgs e)
        {
            textBox2.Text = "# " + DateTime.Now.ToString() + " - Encoding... \r\n ";
            textBox2.Update();
            string outputconsole = ConsoleApp.Run("cwebp.exe", Globals.args).Output.Trim();
            textBox2.Text += outputconsole;
        }
    }
}