﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form2 form2 = new Form2();
                form2.Visible = true;
                this.Visible = false;
            }

            if (radioButton1.Checked)
            {
                Form3 form3 = new Form3();
                form3.Visible = true;
                this.Visible = false;
            }
        }
    }
}
