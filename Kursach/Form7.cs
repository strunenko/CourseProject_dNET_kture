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
    public partial class Form7 : Form
    {
        OleDbDataAdapter adapter = null;
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();
        public Form7()
        {
            InitializeComponent();

            string queryString = "SELECT * FROM [Admin]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            adapter = new OleDbDataAdapter(queryString, connectionString);
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
            string b = Convert.ToString(textBox2.Text);

            string queryString = "Insert into [Admin] ([login], [password]) values ('" + a + "', '" + b + "')";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();
            myOleDbConnection.Close();
            MessageBox.Show("Новый админ добавлен", "Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
            
            string queryString = "Delete From [Admin] Where [login] = '"+a+"'";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();
            myOleDbConnection.Close();
            MessageBox.Show("Админ удален", "Success");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Visible = true;
            this.Visible = false;
        }
    }
}
