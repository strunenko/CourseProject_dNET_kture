using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
            string b = Convert.ToString(textBox2.Text);

            string queryString = "SELECT * FROM [Admin]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();


            while (myOleDbDataReader.Read())
            {
                if (myOleDbDataReader.GetString(0) == a && myOleDbDataReader.GetString(1) == b)
                {
                    Form6 form6 = new Form6();
                    form6.Visible = true;
                    this.Visible = false;
                    break;
                }

            }
            myOleDbDataReader.Close();
            myOleDbConnection.Close();
        }
    }
}
