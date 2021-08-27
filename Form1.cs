using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int r = 0;
            if (comboBox1.SelectedIndex == 0) r = n1 + n2;
            if (comboBox1.SelectedIndex == 1) r = n1 - n2;
            if (comboBox1.SelectedIndex == 2) r = n1 * n2;
            if (comboBox1.SelectedIndex == 3) r = n1 / n2;
            label3.Text = r.ToString();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int r = 0;
            if (comboBox1.SelectedIndex == 0) r = n1 + n2;
            if (comboBox1.SelectedIndex == 1) r = n1 - n2;
            if (comboBox1.SelectedIndex == 2) r = n1 * n2;
            if (comboBox1.SelectedIndex == 3) r = n1 / n2;
            MessageBox.Show(r.ToString());
        }
    }
}
