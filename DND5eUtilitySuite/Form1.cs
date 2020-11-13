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
using System.IO;
using System.Runtime.Remoting.Channels;

namespace DND5eUtilitySuite
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static int entryPoint;
        public string[] member = new string[10];
        private int members, selectedIndex = 0, selectedIndex2, PCCount, NPCCount, totalCR = 0, deadMonsterCount = 0, TotalXP = 0;

        private StreamWriter save;
        //MemberForm m = new MemberForm();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            buildSaveDialog();
            buildLoadDialog();
            members = 0;
            textBox1.Text = Convert.ToString(TotalXP);
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
            m.FormClosed += new FormClosedEventHandler(MForm_Closed);
        }

        private void M_FormClosing(Object sender, FormClosingEventArgs e)
        {
            MemberForm m = (MemberForm)sender;
            Tracker.Items.Add(new ListViewItem(m.member));
            if (m.member[7] == "PC")
                PCCount++;
            else
                NPCCount++;
            m.FormClosing -= M_FormClosing;
            Tracker.Sort();
            members++;
        }

        private void MForm_Closed (object sender, FormClosedEventArgs e)
        {
            MemberForm m = (MemberForm)sender;
            m.Dispose();
            m.FormClosed -= MForm_Closed;
            gCollect();
        }
        
        
        private void gCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void changeInitiativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitChangeForm i = new InitChangeForm();
            selectedIndex2 = Tracker.SelectedIndices[0]; 
            i.Show();
            i.FormClosing += new FormClosingEventHandler(I_FormClosing);
            i.FormClosed += new FormClosedEventHandler(iForm_Closed);
        }

        private void I_FormClosing(Object sender, FormClosingEventArgs e)
        {
            InitChangeForm i = (InitChangeForm)sender;
            Tracker.Items[selectedIndex2].SubItems[0].Text = i.initChange;
            Tracker.Sort();
            i.FormClosing -= I_FormClosing;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFD.ShowDialog();
            if (loadFD.FileName != "")
            {
                string[] array = File.ReadAllLines(loadFD.FileName);
                members = Convert.ToInt32(array[0]);
                PCCount = Convert.ToInt32(array[1]);
                NPCCount = Convert.ToInt32(array[2]);
                for (int i = 3; i + 9 < array.Length; i += 10)
                {
                    Tracker.Items.Add(new ListViewItem(new string[10]
                    {
                        array[i],
                        array[i + 1],
                        array[i + 2],
                        array[i + 3],
                        array[i + 4],
                        array[i + 5],
                        array[i + 6],
                        array[i + 7],
                        array[i + 8],
                        array[i + 9]
                    }));
                }
            }
            loadFD.Dispose();
            gCollect();
        }

        private void iForm_Closed(object sender, FormClosedEventArgs e)
        {
            InitChangeForm i = (InitChangeForm)sender;
            i.Dispose();
            i.FormClosed -= iForm_Closed;
            gCollect();
            Tracker.Sort();

            foreach(ListViewItem item in Tracker.Items)
            {
                if (item.Selected == true)
                {
                    item.Selected = false;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFD.ShowDialog();
            if (!(saveFD.FileName != ""))
            {
                return;
            }
            save = new StreamWriter(saveFD.FileName);
            save.WriteLine(members);
            save.WriteLine(PCCount);
            save.WriteLine(NPCCount);
            foreach (ListViewItem item in Tracker.Items)
            {
                for (int i = 0; i <= 9; i++)
                {
                    save.WriteLine(item.SubItems[i].Text);
                }
            }
            save.Close();
            gCollect();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in Tracker.Items)
            {
                item.Remove();
            }
        }

        private void removeMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                selectedIndex2 = Tracker.SelectedIndices[0];

                if (Tracker.Items[selectedIndex2].SubItems[7].Text == "NPC")
                {
                    Tracker.Items[selectedIndex2].Remove();
                    NPCCount--;
                }
                else
                {
                    Tracker.Items[selectedIndex2].Remove();
                    PCCount--;
                }
                members--;
            }
            catch(Exception)
            {
                MessageBox.Show("You do not currently have a Initiative Member selected.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void causeDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryPoint = 1;
            DamageForm d = new DamageForm();
            d.Show();
            d.FormClosing += d_FormClosing;
            d.FormClosed += d_FormClosed;
        }

        private void d_FormClosing(object sender, EventArgs e)
        {
            DamageForm d = (DamageForm)sender;

            if (entryPoint == 1)
            {
                Tracker.Items[Tracker.SelectedIndices[0]].SubItems[4].Text = Convert.ToString(Convert.ToInt32(Tracker.Items[Tracker.SelectedIndices[0]].SubItems[4].Text) - d.x);
                if (Convert.ToInt32(Tracker.Items[Tracker.SelectedIndices[0]].SubItems[4].Text) <= 0)
                {
                    if (Tracker.Items[Tracker.SelectedIndices[0]].SubItems[7].Text == "PC")
                    {
                        Tracker.Items[Tracker.SelectedIndices[0]].ForeColor = Color.Red;
                    }
                    else if (Tracker.Items[Tracker.SelectedIndices[0]].SubItems[7].Text == "NPC")
                    {
                        totalCR += Convert.ToInt32(Tracker.Items[Tracker.SelectedIndices[0]].SubItems[8].Text);
                        deadMonsterCount++;
                        TotalXP += AddXP(Convert.ToInt32(Tracker.Items[Tracker.SelectedIndices[0]].SubItems[8].Text));
                        textBox1.Text = UpdateXP(TotalXP);
                        Tracker.Items[Tracker.SelectedIndices[0]].Remove();
                        NPCCount--;
                    }
                }

            }
            else if (entryPoint == 2)
                Tracker.Items[Tracker.SelectedIndices[0]].SubItems[4].Text = Convert.ToString(Convert.ToInt32(Tracker.Items[Tracker.SelectedIndices[0]].SubItems[4].Text) + d.x);
            else if (entryPoint == 3)
            {
                TotalXP += AddXP(d.x);
                textBox1.Text = UpdateXP(TotalXP);
            }
            else if (entryPoint == -1)
                return;
            d.FormClosing -= d_FormClosing;

        }

        private void d_FormClosed (object sender, EventArgs e)
        {
            DamageForm d = (DamageForm)sender;
            d.FormClosed -= d_FormClosed;
            d.Dispose();
            gCollect();
        }

        private void addXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryPoint = 3;
            DamageForm d = new DamageForm();
            d.Show();
            d.FormClosing += d_FormClosing;
            d.FormClosed += d_FormClosed;
        }

        private void healToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryPoint = 2;
            DamageForm d = new DamageForm();
            d.Show();
            d.FormClosing += d_FormClosing;
            d.FormClosed += d_FormClosed;
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
        private void buildSaveDialog()
        {
            saveFD.InitialDirectory = ".\\";
            saveFD.Filter = "Init Files (*.itf)|*.itf|All files(*.*)|*.*";
            saveFD.FilterIndex = 1;
            saveFD.RestoreDirectory = true;
        }

        private void buildLoadDialog()
        {
            loadFD.InitialDirectory = ".\\";
            loadFD.Filter = "Init Files (*.itf)|*.itf|All files(*.*)|*.*";
            loadFD.FilterIndex = 1;
        }

        private int AddXP(int z)
        {
            double num = Convert.ToDouble(z);
            double value = 0.2856 * Math.Pow(num, 4.0) - 2.8773 * Math.Pow(num, 3.0) - 21.328 * Math.Pow(num, 2.0) + 813.36 * num - 609.26;
            return Convert.ToInt32(value);
        }

        private string UpdateXP(int a)
        {
            if (a != 0)
            {
                return Convert.ToString(a / PCCount);
            }
            return textBox1.Text;
        }
    }
}
