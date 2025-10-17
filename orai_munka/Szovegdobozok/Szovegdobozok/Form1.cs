using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szovegdobozok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int birthDate = Convert.ToInt32(textBox2.Text);

            int actYear = DateTime.Now.Year;
            int age = actYear - birthDate;

            label4.Text = "Az életkorod: " + age;
        }

    }
}
