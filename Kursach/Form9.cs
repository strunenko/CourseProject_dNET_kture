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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
            string b = Convert.ToString(textBox2.Text);

            string queryString = "Insert into [Клиент] ([Паспортные_дан], [Телефон]) values ('" + a + "', '" + b + "')";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();
            myOleDbConnection.Close();
            MessageBox.Show("Новый клиент добавлен", "Success");
        }
    }
}
