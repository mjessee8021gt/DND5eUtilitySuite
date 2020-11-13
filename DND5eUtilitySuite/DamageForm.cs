using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND5eUtilitySuite
{
    public partial class DamageForm : Form
    {
        public int x, entryPoint;
        public DamageForm()
        {
            InitializeComponent();
            if(Form1.entryPoint == 1)
            {
                label1.Text = "Cause Damage";
                label2.Text = "Damage dealt";
            }
            else if(Form1.entryPoint == 2)
            {
                label1.Text = "Heal Damage";
                label2.Text = "Damage Healed";
            }
            else if(Form1.entryPoint == 3)
            {
                label1.Text = "Add XP";
                label2.Text = "XP to Add";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.entryPoint = -1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("The Value entered is not a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
