using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b10302068_b10302066_B10302060
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
            Class1 cA = new Class1();
            Class2 cB = new Class2();
            int n = cA.GetNumber();
            label1.Text = n.ToString();
            for (int i = 0; i <= n; ++i)
            {
                if (cB.IsPrime(i))
                {
                    comboBox1.Items.Add(i);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();

        }
    }
}
