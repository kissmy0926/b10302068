using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b10302068_b10302060_b10302066
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            int n = c1.GetRandomNumber();
            label2.Text = n.ToString();
            for(int i=0; i<=n;++i)
            {
                if(c2.IsPrime(i))
                {
                    comboBox1.Items.Add(i);
                    
                }

            }
        }
    
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedIndex.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
