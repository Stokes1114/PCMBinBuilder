﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PcmFunctions;

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
                TextBox1.Text = ValidateVIN(TextBox1.Text);
                if (TextBox1.Text.Length != 17)
                {
                    MessageBox.Show("VIN code must be 17 digits long!","Check VIN Length");
                    return;
                }
            } 
            this.DialogResult = DialogResult.OK;
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

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            
            try {
                string VINfile = SelectFile("Load VIN from file");
                if (VINfile.Length > 1)
                {
                    TextBox1.Text = ReadVIN(VINfile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

        }
    }
}
