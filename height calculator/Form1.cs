using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace height_calculator
{
    public partial class f1 : Form
    {
        public int l { get; set; }
        public f1(int h)
        {
            InitializeComponent();
            int n = h;
            l = n;
            label1.Update();
            label2.Update();
            pb1.Update();
        }
        private void f1_Shown(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "Processing your data...", "Sending your data to our research centre...", "Calculating your height...", "Calculating your height...",
                "Calculating your height...", "Finishing touches", "Rechecking results", "Rechecking results", "Getting results...", "Getting results..."
            };
            for (int i = 0; i < 20; i++)
            {
                pb1.Value = i * 5;
                if (label1.Text.Length == 15)
                {
                    label1.Text = label1.Text.Remove(12);
                }
                else label1.Text = label1.Text + ".";
                label1.Update();
                label2.Text = list[i / 2];
                label2.Update();
                Thread.Sleep(1000);
            }
            pb1.Value = 99;
            Thread.Sleep(10000);
            pb1.Value = 100;
            Thread.Sleep(500);
            label1.Text = "Done";
            label2.Text = "Your results are ready! Do you want to see them?";
            pb1.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(l);
            f2.Show();
            this.Hide();
        }
    }
}
