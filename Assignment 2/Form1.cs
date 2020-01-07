using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double ResistorSeries1 = double.Parse(textBox1.Text);
            double ResistorSeries2 = double.Parse(textBox2.Text);
            double TotalResistance1 = ResistorSeries1 + ResistorSeries2;
            MessageBox.Show(TotalResistance1.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double ResistorSeries3 = double.Parse(textBox3.Text);
            double ResistorSeries4 = double.Parse(textBox4.Text);
            double ResistorSeries5 = double.Parse(textBox5.Text);
            double TotalResistance2 = ResistorSeries3 + ResistorSeries4 + ResistorSeries5;
            MessageBox.Show(TotalResistance2.ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double ResistorParallel1 = double.Parse(textBox6.Text);
            double ResistorParallel2 = double.Parse(textBox7.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double ResistorParallel3 = double.Parse(textBox8.Text);
            double ResistorParallel4 = double.Parse(textBox9.Text);
            double ResistorParallel5 = double.Parse(textBox10.Text);
        }
    }
}
