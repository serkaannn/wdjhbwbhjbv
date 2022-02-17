using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1,say2, toplamö;
            say1 = Convert.ToInt32(textBox1.Text);
            say2 = Convert.ToInt32(textBox2.Text);
            toplamö = 0;
            while (say1 <= say2)
            {
                toplamö = say1 + toplamö;
                say1++;
            }
            label1.Text="sayıların toplamı"+toplamö.ToString();
        }
    }
}
