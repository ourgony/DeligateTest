using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeligateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Test += Frm2_Test;
            frm2.DeliTest += Frm2_DeliTest;
            
            frm2.Show();

        }

        private void Frm2_DeliTest(string a)
        {
            textBox2.Text = a;
        }

        private void Frm2_Test(object sender, string e)
        {
            textBox1.Text = e;
        }

        public void ActioTest(string value)
        {
            textBox3.Text = value;
            textBox1.Text = value;
            //MessageBox.Show(value);
            return;
        }
    }
}
