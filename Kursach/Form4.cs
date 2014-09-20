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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void странаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM [Курорт]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM [Услуги]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void питаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM [Питание]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void проживаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM [Проживание]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM [Транспорт]";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);//загружаем данные
            dataGridView1.DataSource = table; //создаем привязку
            myOleDbConnection.Close();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Visible = false;
            
        }
    }
}
