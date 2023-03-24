using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_MULTIPLICATION_TABLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int a, x, sayılar;
            sayılar = Convert.ToInt32(guna2TextBox3.Text);
            for (a = 1; a <= sayılar; a++)
            {
                for (x = 1; x <= sayılar; x++)
                {
                    listBox1.ForeColor = Color.DarkRed;
                    listBox1.Items.Add(a + "x" + x + "=" + x * x);
                }
            }
        }
    }
}

