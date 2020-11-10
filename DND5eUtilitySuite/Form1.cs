using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DND5eUtilitySuite
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public List<string[]> initMembers = new List<string[]>(50);
        public int passthrough;
        private int members, selectedIndex = 0, selectedIndex2;
        //MemberForm m = new MemberForm();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            members = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bSender = (Button)sender;
            Point pLowerLeft = new Point(0, bSender.Height);
            pLowerLeft = bSender.PointToScreen(pLowerLeft);
            MainCMenu.Show(pLowerLeft);
        }
        private void HeadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This software was written solely by Matt Jessee and is designed to be used at the gaming table to help my fellow game masters keep track of things such as experience and initiative. More will come as it is developed. Please provide feedback where possible by going to the main menu and clicking Feedback.\n\nThe Current Version is: 2.0.0.XXX\n\nCopyright (C) 2017 Matt Jessee\n\nLicensing Boiler Plate:\n\nThis program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, Either Version 3 of the license.\n\nThis program is distributred in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.\n\nYou should have received a copy of the GNU General Public License along with this program. If not, see http://www.gnu.org/license/.";
            MessageBox.Show(message, "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PatchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "D&D 5e GM Utility Suite\nFirst Published: October 4th, 2017 4:11 PM\nLast Updated: October XX, 2020 XX:XX XM\nCurrent Version: 2.0.0.XXX\n\nPatch Notes - 10/XX/2020 - 2.0.0.XXX\nNEW FEATURES\n-New UI!\n\nPatch Notes - 4/15/2018 - 1.2.2.121\nBUG FIXES\n- Fixed the bug where attempting to heal a track member did not heal them.\n\nPatch Notes - 2/23/2018 - 1.2.2.103\nBUG FIXES\n-Fixed the bug where killing the last member of the initiative track would cause the tracker to crash.\n-Fixed the bug where the experience totals of multiple killed NPCs would not add together.\n-Fixed the bug where the program would crash when starting a new 'lap' in the initiative after killing a track member.\n\nNEW FEATURES\n-Incorporated a feature to delete track members without adding XP to the track. XP will also recalculate when PC's are removed.\n\n!!!For the full historical patch notes, please click the CANCEL button!!!";
            DialogResult results = MessageBox.Show(message, "Patch Notes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(results == System.Windows.Forms.DialogResult.Cancel)
            {
                /*
                 * Send the user to a new webpage with Patch Notes
                 */
            }
        }

        private void betaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSdrMkpL8Cvf_CdetYZHYwrmShmkIHwPSyJ9fds9rjvD8HUlNA/viewform?usp=sf_link");
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfdiTXUsFKstHoX44pMpbvNCHaqvRbWyy47lfo06B7vu1l14Q/viewform?usp=sf_link");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bSender = (Button)sender;
            Point pLowerLeft = new Point(0, bSender.Height);
            pLowerLeft = bSender.PointToScreen(pLowerLeft);
            MemberCMenu.Show(pLowerLeft);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button bSender = (Button)sender;
            Point pLowerLeft = new Point(0, bSender.Height);
            pLowerLeft = bSender.PointToScreen(pLowerLeft);
            HealthCMenu.Show(pLowerLeft);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bSender = (Button)sender;
            Point pLowerLeft = new Point(0, bSender.Height);
            pLowerLeft = bSender.PointToScreen(pLowerLeft);
            ToolCMenu.Show(pLowerLeft);
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm m = new MemberForm();
            m.Show();
            m.FormClosing += new FormClosingEventHandler(M_FormClosing);
            m.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void M_FormClosing(Object sender, FormClosingEventArgs e)
        {
            MemberForm m = (MemberForm)sender;
            initMembers.Add(m.member);
            m.FormClosing -= M_FormClosing;
        }

        private void Form_Closed (object sender, FormClosedEventArgs e)
        {
            MemberForm m = (MemberForm)sender;
            m.Dispose();
            m.FormClosed -= Form_Closed;
            gCollect();
            updateMemberList();
        }
        
        
        private void gCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        private void listSort()
        {
            Tracker.Sort();
        }
        private void updateMemberList()
        {
            string[] temp = initMembers[members];
            ListViewItem lTemp = new ListViewItem(temp);
            Tracker.Items.Add(lTemp);
            Tracker.Sort();
            members++;
            listSort();
        }

        private void changeInitiativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitChangeForm i = new InitChangeForm();
            i.Show();
            i.FormClosing += new FormClosingEventHandler(I_FormClosing);
            i.FormClosed += new FormClosedEventHandler(iForm_Closed);
        }

        private void I_FormClosing(Object sender, FormClosingEventArgs e)
        {
            InitChangeForm i = (InitChangeForm)sender;
            Tracker.Items[selectedIndex2].SubItems[0].Text = i.initChange;
            i.FormClosing -= I_FormClosing;
        }
        private void iForm_Closed(object sender, FormClosedEventArgs e)
        {
            InitChangeForm i = (InitChangeForm)sender;
            i.Dispose();
            i.FormClosed -= iForm_Closed;
            gCollect();
            updateMemberList();
        }

        private void Tracker_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach(ListViewItem item in Tracker.Items)
            {
                if(item.Selected == true)
                {
                    selectedIndex2 = Tracker.Items.IndexOf(item);
                    Tracker.Items[selectedIndex2].BackColor = Color.DodgerBlue;
                    Tracker.Items[selectedIndex2].ForeColor = Color.White;

                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                initReestablish();
            }
        }

        private void SSButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex == 0)
            {
                selectedIndex = 1;
                Tracker.Items[selectedIndex - 1].ForeColor = Color.RoyalBlue;
            }
            else if (selectedIndex < Tracker.Items.Count)
            {
                Tracker.Items[selectedIndex - 1].ForeColor = Color.Black;
                selectedIndex++;
                Tracker.Items[selectedIndex - 1].ForeColor = Color.RoyalBlue;
            }
            else
            {
                Tracker.Items[selectedIndex - 1].ForeColor = Color.Black;
                selectedIndex = 1;
                Tracker.Items[selectedIndex - 1].ForeColor = Color.RoyalBlue;
            }
        }
        private void initReestablish()
        {
            if(selectedIndex != 0)
                Tracker.Items[selectedIndex - 1].ForeColor = Color.DeepSkyBlue;
        }
    }
}
