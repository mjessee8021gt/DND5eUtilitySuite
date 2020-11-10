using DND5eUtilitySuite.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND5eUtilitySuite
{
    public partial class MemberForm : Form
    {
        private int selectionMode;
        private Image pClear = Resources.Person_Clear;
        private Image pSelect = Resources.person_Select;
        private Image mClear = Resources.Monster;
        private Image mSelect = Resources.Monster_Select;
        public string[] member = new string[10];

        public MemberForm()
        {
            InitializeComponent();
            selectionMode = 0;
            CRLabel.Visible = false;
            CRTB.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PCButton_Click(object sender, EventArgs e)
        {
            if(selectionMode != 0)
            {
                selectionMode = 0;
                PCButton.BackgroundImage = pSelect;
                NPCButton.BackgroundImage = mClear;
                CRTB.Visible = false;
                CRLabel.Visible = false;
                CRTB.Text = "";
            }
        }

        private void NPCButton_Click(object sender, EventArgs e)
        {
            if(selectionMode != 1)
            {
                selectionMode = 1;
                NPCButton.BackgroundImage = mSelect;
                PCButton.BackgroundImage = pClear;
                CRTB.Visible = true;
                CRLabel.Visible = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(InitTB.Text) < 10)
                    member[0] = "0" + InitTB.Text;
                else
                    member[0] = InitTB.Text;
            }
            catch(Exception f)
            {
                MessageBox.Show("Your Input is not a number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            member[1] = NameTB.Text;
            member[2] = ACTB.Text;
            member[3] = MaxHPTB.Text;
            member[4] = CurrHPTB.Text;
            member[5] = null;
            member[6] = null;
            member[9] = null;

            if(CRTB.Text != "")
            {
                member[7] = "NPC";
                member[8] = CRTB.Text;
            }
            else
            {
                member[7] = "PC";
                member[8] = null;
            }

            this.Close();
            this.Dispose();
        }
    }
}
