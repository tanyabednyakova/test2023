﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.setTextToLabel(textBox1.Text);
            form2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form2.setTextToLabel(textBox1.Text);
        }
    }
}
