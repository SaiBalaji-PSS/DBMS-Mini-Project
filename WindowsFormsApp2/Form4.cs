using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public string des="chennai";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var w = "https://www.google.com/search?q=" + textBox1.Text;
            webBrowser1.Url = new Uri(w);
        }

        private void Button2_Click(object sender, EventArgs e)
        {



            var w = "https://www.google.co.in/maps/search/earth/@12.9363249,80.1540116,14z/data=!3m1!4b1";
            webBrowser1.Url = new Uri(w);
            
        }
    }
}


