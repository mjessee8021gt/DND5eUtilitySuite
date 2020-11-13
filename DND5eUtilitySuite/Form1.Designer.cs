namespace DND5eUtilitySuite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SSButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tracker = new System.Windows.Forms.ListView();
            this.TrackerInit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerMaxHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerCurrentHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerConditionTurns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerMemberType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerCR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackerDmgPerTurn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatchNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInitiativeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.causeDamageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.healDamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patchNotesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.betaTestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HealthCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.healToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.causeDamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inflictConditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeInitiativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addXPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.loadFD = new System.Windows.Forms.OpenFileDialog();
            this.headPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainCMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.HealthCMenu.SuspendLayout();
            this.ToolCMenu.SuspendLayout();
            this.MemberCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.headPanel.Controls.Add(this.button1);
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(787, 58);
            this.headPanel.TabIndex = 0;
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "5e Utility Suite";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 450);
            this.panel2.TabIndex = 1;
            // 
            // SSButton
            // 
            this.SSButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SSButton.FlatAppearance.BorderSize = 0;
            this.SSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSButton.Location = new System.Drawing.Point(2, 0);
            this.SSButton.Name = "SSButton";
            this.SSButton.Size = new System.Drawing.Size(97, 38);
            this.SSButton.TabIndex = 2;
            this.SSButton.Text = "Start/Step";
            this.SSButton.UseVisualStyleBackColor = false;
            this.SSButton.Click += new System.EventHandler(this.SSButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(60, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 58);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 58);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 58);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tracker
            // 
            this.Tracker.AllowColumnReorder = true;
            this.Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tracker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackerInit,
            this.TrackerName,
            this.TrackerAC,
            this.TrackerMaxHP,
            this.TrackerCurrentHP,
            this.TrackerCondition,
            this.TrackerConditionTurns,
            this.TrackerMemberType,
            this.TrackerCR,
            this.TrackerDmgPerTurn});
            this.Tracker.FullRowSelect = true;
            this.Tracker.GridLines = true;
            this.Tracker.HideSelection = false;
            this.Tracker.Location = new System.Drawing.Point(60, 58);
            this.Tracker.Margin = new System.Windows.Forms.Padding(4);
            this.Tracker.Name = "Tracker";
            this.Tracker.Size = new System.Drawing.Size(727, 410);
            this.Tracker.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.Tracker.TabIndex = 2;
            this.Tracker.UseCompatibleStateImageBehavior = false;
            this.Tracker.View = System.Windows.Forms.View.Details;
            // 
            // TrackerInit
            // 
            this.TrackerInit.Text = "Init";
            this.TrackerInit.Width = 28;
            // 
            // TrackerName
            // 
            this.TrackerName.Text = "Name";
            this.TrackerName.Width = 85;
            // 
            // TrackerAC
            // 
            this.TrackerAC.Text = "AC";
            this.TrackerAC.Width = 29;
            // 
            // TrackerMaxHP
            // 
            this.TrackerMaxHP.Text = "  Max HP";
            // 
            // TrackerCurrentHP
            // 
            this.TrackerCurrentHP.Text = "Current HP";
            this.TrackerCurrentHP.Width = 65;
            // 
            // TrackerCondition
            // 
            this.TrackerCondition.Text = "Condition";
            // 
            // TrackerConditionTurns
            // 
            this.TrackerConditionTurns.Text = "Turns";
            this.TrackerConditionTurns.Width = 42;
            // 
            // TrackerMemberType
            // 
            this.TrackerMemberType.Text = "Member Type";
            this.TrackerMemberType.Width = 77;
            // 
            // TrackerCR
            // 
            this.TrackerCR.Text = "CR";
            this.TrackerCR.Width = 29;
            // 
            // TrackerDmgPerTurn
            // 
            this.TrackerDmgPerTurn.Text = "Dmg/Turn";
            this.TrackerDmgPerTurn.Width = 67;
            // 
            // MainCMenu
            // 
            this.MainCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.PatchNotesToolStripMenuItem,
            this.betaTestToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.MainCMenu.Name = "MainCMenu";
            this.MainCMenu.Size = new System.Drawing.Size(255, 208);
            this.MainCMenu.Text = "Options";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.newToolStripMenuItem.Text = "New Session";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PatchNotesToolStripMenuItem
            // 
            this.PatchNotesToolStripMenuItem.Name = "PatchNotesToolStripMenuItem";
            this.PatchNotesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.PatchNotesToolStripMenuItem.Text = "Patch Notes";
            this.PatchNotesToolStripMenuItem.Click += new System.EventHandler(this.PatchNotesToolStripMenuItem_Click);
            // 
            // betaTestToolStripMenuItem
            // 
            this.betaTestToolStripMenuItem.Name = "betaTestToolStripMenuItem";
            this.betaTestToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.betaTestToolStripMenuItem.Text = "Beta Test";
            this.betaTestToolStripMenuItem.Click += new System.EventHandler(this.betaTestToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.SSButton);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(60, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 39);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(664, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(51, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "XP per Player:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.newSessionToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.newMemberToolStripMenuItem.Text = "New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.newSessionToolStripMenuItem.Text = "New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeInitiativeToolStripMenuItem1,
            this.causeDamageToolStripMenuItem1,
            this.healDamageToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeInitiativeToolStripMenuItem1
            // 
            this.changeInitiativeToolStripMenuItem1.Name = "changeInitiativeToolStripMenuItem1";
            this.changeInitiativeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.changeInitiativeToolStripMenuItem1.Size = new System.Drawing.Size(289, 26);
            this.changeInitiativeToolStripMenuItem1.Text = "Change Initiative";
            // 
            // causeDamageToolStripMenuItem1
            // 
            this.causeDamageToolStripMenuItem1.Name = "causeDamageToolStripMenuItem1";
            this.causeDamageToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.causeDamageToolStripMenuItem1.Size = new System.Drawing.Size(289, 26);
            this.causeDamageToolStripMenuItem1.Text = "Cause Damage";
            this.causeDamageToolStripMenuItem1.Click += new System.EventHandler(this.causeDamageToolStripMenuItem_Click);
            // 
            // healDamageToolStripMenuItem
            // 
            this.healDamageToolStripMenuItem.Name = "healDamageToolStripMenuItem";
            this.healDamageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.healDamageToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.healDamageToolStripMenuItem.Text = "Heal Damage";
            this.healDamageToolStripMenuItem.Click += new System.EventHandler(this.healToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.patchNotesToolStripMenuItem1,
            this.betaTestToolStripMenuItem1,
            this.feedbackToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // patchNotesToolStripMenuItem1
            // 
            this.patchNotesToolStripMenuItem1.Name = "patchNotesToolStripMenuItem1";
            this.patchNotesToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.patchNotesToolStripMenuItem1.Text = "Patch Notes";
            // 
            // betaTestToolStripMenuItem1
            // 
            this.betaTestToolStripMenuItem1.Name = "betaTestToolStripMenuItem1";
            this.betaTestToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.betaTestToolStripMenuItem1.Text = "Beta Test";
            // 
            // feedbackToolStripMenuItem1
            // 
            this.feedbackToolStripMenuItem1.Name = "feedbackToolStripMenuItem1";
            this.feedbackToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.feedbackToolStripMenuItem1.Text = "Feedback";
            // 
            // HealthCMenu
            // 
            this.HealthCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HealthCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healToolStripMenuItem,
            this.causeDamageToolStripMenuItem,
            this.inflictConditionToolStripMenuItem});
            this.HealthCMenu.Name = "HealthCMenu";
            this.HealthCMenu.Size = new System.Drawing.Size(232, 76);
            // 
            // healToolStripMenuItem
            // 
            this.healToolStripMenuItem.Name = "healToolStripMenuItem";
            this.healToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.healToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.healToolStripMenuItem.Text = "Heal Damage";
            this.healToolStripMenuItem.Click += new System.EventHandler(this.healToolStripMenuItem_Click);
            // 
            // causeDamageToolStripMenuItem
            // 
            this.causeDamageToolStripMenuItem.Name = "causeDamageToolStripMenuItem";
            this.causeDamageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.causeDamageToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.causeDamageToolStripMenuItem.Text = "Cause Damage";
            this.causeDamageToolStripMenuItem.Click += new System.EventHandler(this.causeDamageToolStripMenuItem_Click);
            // 
            // inflictConditionToolStripMenuItem
            // 
            this.inflictConditionToolStripMenuItem.Name = "inflictConditionToolStripMenuItem";
            this.inflictConditionToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.inflictConditionToolStripMenuItem.Text = "Inflict Condition";
            // 
            // ToolCMenu
            // 
            this.ToolCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeInitiativeToolStripMenuItem,
            this.addXPToolStripMenuItem});
            this.ToolCMenu.Name = "ToolCMenu";
            this.ToolCMenu.Size = new System.Drawing.Size(236, 80);
            // 
            // changeInitiativeToolStripMenuItem
            // 
            this.changeInitiativeToolStripMenuItem.Name = "changeInitiativeToolStripMenuItem";
            this.changeInitiativeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.changeInitiativeToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.changeInitiativeToolStripMenuItem.Text = "Change Initiative";
            this.changeInitiativeToolStripMenuItem.Click += new System.EventHandler(this.changeInitiativeToolStripMenuItem_Click);
            // 
            // addXPToolStripMenuItem
            // 
            this.addXPToolStripMenuItem.Name = "addXPToolStripMenuItem";
            this.addXPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.addXPToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.addXPToolStripMenuItem.Text = "Add XP";
            this.addXPToolStripMenuItem.Click += new System.EventHandler(this.addXPToolStripMenuItem_Click);
            // 
            // MemberCMenu
            // 
            this.MemberCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MemberCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.removeMemberToolStripMenuItem});
            this.MemberCMenu.Name = "MemberCMenu";
            this.MemberCMenu.Size = new System.Drawing.Size(286, 52);
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // removeMemberToolStripMenuItem
            // 
            this.removeMemberToolStripMenuItem.Name = "removeMemberToolStripMenuItem";
            this.removeMemberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.removeMemberToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.removeMemberToolStripMenuItem.Text = "Remove Member";
            this.removeMemberToolStripMenuItem.Click += new System.EventHandler(this.removeMemberToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 507);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Tracker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.MainCMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.HealthCMenu.ResumeLayout(false);
            this.ToolCMenu.ResumeLayout(false);
            this.MemberCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Tracker;
        private System.Windows.Forms.ColumnHeader TrackerInit;
        private System.Windows.Forms.ColumnHeader TrackerName;
        private System.Windows.Forms.ColumnHeader TrackerAC;
        private System.Windows.Forms.ColumnHeader TrackerMaxHP;
        private System.Windows.Forms.ColumnHeader TrackerCurrentHP;
        private System.Windows.Forms.ColumnHeader TrackerCondition;
        private System.Windows.Forms.ColumnHeader TrackerConditionTurns;
        private System.Windows.Forms.ColumnHeader TrackerMemberType;
        private System.Windows.Forms.ColumnHeader TrackerCR;
        private System.Windows.Forms.ColumnHeader TrackerDmgPerTurn;
        private System.Windows.Forms.ContextMenuStrip MainCMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatchNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betaTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip HealthCMenu;
        private System.Windows.Forms.ToolStripMenuItem healToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem causeDamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inflictConditionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ToolCMenu;
        private System.Windows.Forms.ToolStripMenuItem changeInitiativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addXPToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MemberCMenu;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMemberToolStripMenuItem;
        private System.Windows.Forms.Button SSButton;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog loadFD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInitiativeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem causeDamageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem healDamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patchNotesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem betaTestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem1;
    }
}

