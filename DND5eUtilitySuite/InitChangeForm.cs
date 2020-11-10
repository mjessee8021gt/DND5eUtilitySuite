using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND5eUtilitySuite
{
    public partial class InitChangeForm : Form
    {
        public string initChange;
        public InitChangeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) <= 9)
                initChange = "0" + textBox1.Text;
            else
                initChange = textBox1.Text;

            this.Close();
        }
    }
}
