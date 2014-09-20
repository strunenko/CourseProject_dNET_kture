using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Kursach
{
    public partial class Form8 : Form
    {
        int stoimost = 1;
                
        public Form8()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void новыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Strana();
            Kurort();
            Progivanie();
            Pitanie();
            Transport();
            Klient();
            Sotrudnik();
            
            textBox3.Text = null;
            textBox8.Text = null;
        }

        
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void Pitanie()
        {
            string queryString = "SELECT * FROM Питание";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox5.DisplayMember = "Тип_питание";
            comboBox5.ValueMember = "Ин_питание";
            comboBox5.DataSource = dtCity;
            myOleDbConnection.Close();
        }

        void Progivanie()
        {
            string queryString = "SELECT * FROM Проживание";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox6.DisplayMember = "Тип_проживание";
            comboBox6.ValueMember = "Ин_проживание";
            comboBox6.DataSource = dtCity;
            myOleDbConnection.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void Transport()
        {
            string queryString = "SELECT * FROM Транспорт";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox7.DisplayMember = "Тип_транспорт";
            comboBox7.ValueMember = "Ин_транспорт";
            comboBox7.DataSource = dtCity;
            myOleDbConnection.Close();
        }

        void Kurort()
        {
            string queryString = "SELECT * FROM Курорт where Ин_страна = "+comboBox9.SelectedValue.ToString();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox1.DisplayMember = "Название_курорт";
            comboBox1.ValueMember = "Ин_курорт";
            comboBox1.DataSource = dtCity;
            myOleDbConnection.Close();
        }
        void Klient()
        {
            string queryString = "SELECT * FROM Клиент";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox3.DisplayMember = "Паспортные_дан";
            comboBox3.ValueMember = "Ин_клиент";
            comboBox3.DataSource = dtCity;
            myOleDbConnection.Close();
        }
        void Sotrudnik()
        {
            string queryString = "SELECT * FROM Сотрудник";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox4.DisplayMember = "ФИО";
            comboBox4.ValueMember = "Ин_сотрудник";
            comboBox4.DataSource = dtCity;
            myOleDbConnection.Close();
        }

        private void оформитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan ts = dateTimePicker2.Value - dateTimePicker1.Value;
            int diff = ts.Days;
            string a;
            string b;
            string c;
            string g = Convert.ToString(textBox3.Text);            
            string i = comboBox1.SelectedValue.ToString();

            if (checkBox1.Checked)
            {
                stoimost += 10;
                a = "да";
            }
            else a="нет";
            if (checkBox2.Checked)
            {
                stoimost += 10;
                b = "да";
            }
            else b = "нет";
            if (checkBox3.Checked)
            {
                stoimost += 10;
                c = "да";
            }
            else c = "нет";
            int c1 = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            int c5 = Convert.ToInt32(comboBox5.SelectedValue.ToString());
            int c6 = Convert.ToInt32(comboBox6.SelectedValue.ToString());
            int c7 = Convert.ToInt32(comboBox7.SelectedValue.ToString());
            stoimost *= c1;
            stoimost *= c5;
            stoimost *= c6;
            stoimost *= c7;

            stoimost*=diff;
            int kCh = Convert.ToInt32(g);
            stoimost *= kCh;


            string queryString = "Insert into [Услуги] ([Визовое_обслуж], [Экскурсии], [Достопримечательности], [Ин_курорт]) values ('" + a + "', '" + b + "','" + c + "','" + i + "')";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            myOleDbConnection.Open();
            myOleDbCommand.ExecuteNonQuery();
            myOleDbConnection.Close();

            string sQ = "Select max(Ин_услуги) as Ин_услуги from Услуги";
            string sC = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection oCon = new OleDbConnection(sC);
            OleDbCommand oCom = new OleDbCommand(sQ, oCon);
            oCon.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter(oCom);
            DataTable dtCity = new DataTable();
            ad.Fill(dtCity);
            comboBox2.DisplayMember = "Ин_услуги";
            comboBox2.ValueMember = "Ин_услуги";
            comboBox2.DataSource = dtCity;
            oCon.Close();

            string queryString1 = "Insert into [Тур] ([Дата_н], [Дата_з], [Количество_чел], [Ин_услуги], [Ин_питание],[Ин_транспорт],[Ин_проживание]) values ('" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "','" + g + "','" + comboBox2.SelectedValue.ToString() + "','" + comboBox5.SelectedValue.ToString() + "','" + comboBox7.SelectedValue.ToString() + "','" + comboBox6.SelectedValue.ToString() + "')";
            string connectionString1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection1 = new OleDbConnection(connectionString1);
            OleDbCommand myOleDbCommand1 = new OleDbCommand(queryString1, myOleDbConnection1);
            myOleDbConnection1.Open();
            myOleDbCommand1.ExecuteNonQuery();
            myOleDbConnection1.Close();



            string sQ1 = "Select max(Ин_тур) as Ин_тур from Тур";
            string sC1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection oCon1 = new OleDbConnection(sC1);
            OleDbCommand oCom1 = new OleDbCommand(sQ1, oCon1);
            oCon1.Open();
            OleDbDataAdapter ad1 = new OleDbDataAdapter(oCom1);
            DataTable dtCity1 = new DataTable();
            ad1.Fill(dtCity1);
            comboBox8.DisplayMember = "Ин_тур";
            comboBox8.ValueMember = "Ин_тур";
            comboBox8.DataSource = dtCity1;
            oCon1.Close();

            string queryString2 = "Insert into [Заказ] ([Дата_оформления], [Стоимость], [Ин_тур], [Ин_клиент], [Ин_сотрудник]) values ('" + now.ToString() + "', '" + stoimost.ToString() + "','" + comboBox8.SelectedValue.ToString() + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "')";
            string connectionString2 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection2 = new OleDbConnection(connectionString2);
            OleDbCommand myOleDbCommand2 = new OleDbCommand(queryString2, myOleDbConnection2);
            myOleDbConnection2.Open();
            myOleDbCommand2.ExecuteNonQuery();
            myOleDbConnection2.Close();
            textBox8.Text += "Вы успешно зарегистрировали заказ!!!\r\n" + "Выбраный курорт " + comboBox1.SelectedValue.ToString() + "\r\nКоличество дней " + diff + "\r\nКоличество человек " + kCh + "\r\nСтоимость " + stoimost + "\r\nКлиент " + comboBox3.SelectedValue.ToString() + "\r\nСотрудник " + comboBox4.SelectedValue.ToString() + "\r\nДата оформления " + now.ToString();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            FileStream stream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            if (stream != null)
            {
                StreamWriter writer = new StreamWriter(stream);

                writer.Write(textBox8.Text);
                writer.Flush();
                stream.Close();
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Visible = true;
            this.Visible = false;
        }
        void Strana()
        {
            string queryString = "SELECT * FROM Страна";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Vladislav\Documents\kursach1.mdb";
            OleDbConnection myOleDbConnection = new OleDbConnection(connectionString);
            OleDbCommand myOleDbCommand = new OleDbCommand(queryString, myOleDbConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(myOleDbCommand);
            DataTable dtCity = new DataTable();
            adapter.Fill(dtCity);
            comboBox9.DisplayMember = "Назв_страна";
            comboBox9.ValueMember = "Ин_страна";
            comboBox9.DataSource = dtCity;
            myOleDbConnection.Close();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurort();
        }
    }
}
