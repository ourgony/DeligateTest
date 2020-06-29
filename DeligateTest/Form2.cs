using System;
using System.Windows.Forms;

namespace DeligateTest
{
    public partial class Form2 : Form
    {
        public event EventHandler<string> Test;

        public delegate void delitest(string a);
        public event delitest DeliTest;
        public Action<string> action;
        public Func<string, string> func;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test?.Invoke(this, textBox1.Text);
            DeliTest?.Invoke(textBox2.Text);
            
            func?.Invoke(textBox4.Text);

            Form1 frm1 = new Form1();
            action = frm1.ActioTest;
            action(textBox3.Text);

            //Action<string> action = (a) => { textBox3.Text = a; };

            //this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
