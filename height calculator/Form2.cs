using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace height_calculator
{
    public partial class Form2 : Form
    {
        public int h { get; set; }
        public Form2(int l)
        {
            InitializeComponent();
            h = l;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                label1.Text = label1.Text + ".";
                label1.Update();
                Thread.Sleep(1000);
            }
            label2.Visible = true;
            label2.Update();
            Thread.Sleep(1000);
            int hh = h + 50;
            label3.Text = h - 50 + " and " + hh;
            label3.Visible = true;
            label3.Update();
            Thread.Sleep(1000);
            label4.Visible = true;
            label4.Update();
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
