using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListUygulama
{
    public partial class Form1 : Form
    {
        ArrayList listem=new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listem.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string a in listem)
                listView1.Items.Add(a);
        }
    }
}
