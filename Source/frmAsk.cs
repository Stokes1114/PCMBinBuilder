﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCMBinBuilder
{
    public partial class FrmAsk : Form
    {
        public FrmAsk()
        {
            InitializeComponent();
        }

        public void SetMyText(string Txt)
        {
            TextBox1.Text = Txt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Text == "Enter VIN Code")
            {
                string tmp = globals.ValidateVIN(TextBox1.Text);
                if (tmp == "")
                {
                       MessageBox.Show("VIN code must be 17 digits long!","Check VIN Length");
                       return;
                }
                TextBox1.Text = tmp;
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
                this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
