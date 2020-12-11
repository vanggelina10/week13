using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumweek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Proses_Click(object sender, EventArgs e)
        {
            label1Empty.Text = textBox1Tulisan.Text;
            if (textBox1Tulisan.Text == "delete")
            {
                label1Empty.Text = "[ EMPTY ]";
                label1Empty.Font = new Font("Microsoft Sans Serif", 15);
            }
            else
            {
            }
        }
    }
}