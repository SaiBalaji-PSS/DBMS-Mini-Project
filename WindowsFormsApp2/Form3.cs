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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
            string query = "INSERT INTO bookings VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + (string)comboBox1.SelectedItem + "','" + (string)comboBox2.SelectedItem + "')";
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("BOOKING SUCCESS", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcon.Close();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
        }
    }
}
