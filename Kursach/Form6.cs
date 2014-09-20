using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form7 form7 = new Form7();
                form7.Visible = true;
                this.Visible = false;
            }

            if (radioButton2.Checked)
            {
                Form8 form8 = new Form8();
                form8.Visible = true;
                this.Visible = false;
            }
            if (radioButton3.Checked)
            {
                Form9 form9 = new Form9();
                form9.Visible = true;
                this.Visible = false;
            }
            if (radioButton4.Checked)
            {
                Form10 form10 = new Form10();
                form10.Visible = true;
                this.Visible = false;
            }
            if (radioButton5.Checked)
            {
                Form11 form11 = new Form11();
                form11.Visible = true;
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Visible = true;
            this.Visible = false;
        }
    }
}
