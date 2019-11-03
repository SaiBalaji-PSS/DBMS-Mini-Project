using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string usr = Class1.location;
        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
            string query = "SELECT * FROM bookings";
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        ListViewItem lst = new ListViewItem (reader.GetString(0).ToString());
                        lst.SubItems.Add(reader.GetString(1));
                        lst.SubItems.Add(reader.GetString(2));
                        lst.SubItems.Add(reader.GetString(3));
                        lst.SubItems.Add(reader.GetString(4));
                        lst.SubItems.Add(reader.GetString(5));
                        lst.SubItems.Add(reader.GetString(6));
                        listView1.Items.Add(lst);
                    }
                    reader.Close();
                    dbcon.Close();
                }
            }
            catch(Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = usr;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("NAME",100);
            listView1.Columns.Add("EMAIL",100);
            listView1.Columns.Add("PHONE",100);
            listView1.Columns.Add("SOURCE", 100);
            listView1.Columns.Add("DESTINATION", 100);
            listView1.Columns.Add("BUS TYPE", 100);
            listView1.Columns.Add("PAYMENT MODE", 100);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
           
        }
    }
}
