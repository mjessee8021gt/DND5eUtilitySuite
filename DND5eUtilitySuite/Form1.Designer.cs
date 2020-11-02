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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainCMenu.SuspendLayout();
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
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(606, 58);
            this.headPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "5e Utility Suite";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 471);
            this.panel2.TabIndex = 1;
            // 
            // Tracker
            // 
            this.Tracker.AllowColumnReorder = true;
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
            this.Tracker.GridLines = true;
            this.Tracker.HideSelection = false;
            this.Tracker.Location = new System.Drawing.Point(59, 57);
            this.Tracker.Name = "Tracker";
            this.Tracker.Size = new System.Drawing.Size(547, 384);
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
            this.MainCMenu.Size = new System.Drawing.Size(141, 192);
            this.MainCMenu.Text = "Options";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newToolStripMenuItem.Text = "New Session";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PatchNotesToolStripMenuItem
            // 
            this.PatchNotesToolStripMenuItem.Name = "PatchNotesToolStripMenuItem";
            this.PatchNotesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.PatchNotesToolStripMenuItem.Text = "Patch Notes";
            this.PatchNotesToolStripMenuItem.Click += new System.EventHandler(this.PatchNotesToolStripMenuItem_Click);
            // 
            // betaTestToolStripMenuItem
            // 
            this.betaTestToolStripMenuItem.Name = "betaTestToolStripMenuItem";
            this.betaTestToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.betaTestToolStripMenuItem.Text = "Beta Test";
            this.betaTestToolStripMenuItem.Click += new System.EventHandler(this.betaTestToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 58);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 58);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 471);
            this.Controls.Add(this.Tracker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.MainCMenu.ResumeLayout(false);
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
    }
}

