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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Dolgnost();
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
            string c = Convert.ToString(textBox3.Text);

            string queryString = "Insert into [Сотрудник] ([ФИО], [Адрес],[Телефон], [Ин_должность]) values ('" + a + "', '" + b + "','" + c + "','" + comboBox1.SelectedValue.ToString() + "')";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();
            myOleDbConnection.Close();
            MessageBox.Show("Новый сотрудник добавлен", "Success");
        }
        void Dolgnost()
        {
            string queryString = "SELECT * FROM Должнонсть";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox1.DisplayMember = "Должность";
            comboBox1.ValueMember = "Ин_должность";
            comboBox1.DataSource = dtCity;
            myOleDbConnection.Close();
        }

    }
}
