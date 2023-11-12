using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBN
{
    public partial class Form1 : Form
    {
        double a, b;
        string kq;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a =double.Parse(textBox1.Text);
            b =double.Parse(textBox2.Text);
            SimpleEquation sp = new SimpleEquation(a, b);
            kq = sp.SingleEquation();
            textBox3.Text = kq;
        }
    }
}
