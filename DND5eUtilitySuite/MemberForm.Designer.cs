namespace DND5eUtilitySuite
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NPCButton = new System.Windows.Forms.Button();
            this.PCButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InitLabel = new System.Windows.Forms.Label();
            this.InitTB = new System.Windows.Forms.TextBox();
            this.MaxHPLabel = new System.Windows.Forms.Label();
            this.MaxHPTB = new System.Windows.Forms.TextBox();
            this.CurrHPLabel = new System.Windows.Forms.Label();
            this.CurrHPTB = new System.Windows.Forms.TextBox();
            this.ACLabel = new System.Windows.Forms.Label();
            this.ACTB = new System.Windows.Forms.TextBox();
            this.CRTB = new System.Windows.Forms.TextBox();
            this.CRLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 30);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(298, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(72, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(153, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Add Member";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.NPCButton);
            this.panel2.Controls.Add(this.PCButton);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 102);
            this.panel2.TabIndex = 1;
            // 
            // NPCButton
            // 
            this.NPCButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NPCButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NPCButton.BackgroundImage")));
            this.NPCButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NPCButton.FlatAppearance.BorderSize = 0;
            this.NPCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPCButton.Location = new System.Drawing.Point(0, 52);
            this.NPCButton.Name = "NPCButton";
            this.NPCButton.Size = new System.Drawing.Size(50, 50);
            this.NPCButton.TabIndex = 1;
            this.NPCButton.UseVisualStyleBackColor = true;
            this.NPCButton.Click += new System.EventHandler(this.NPCButton_Click);
            // 
            // PCButton
            // 
            this.PCButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PCButton.BackgroundImage = global::DND5eUtilitySuite.Properties.Resources.person_Select;
            this.PCButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCButton.FlatAppearance.BorderSize = 0;
            this.PCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCButton.Location = new System.Drawing.Point(0, -2);
            this.PCButton.Name = "PCButton";
            this.PCButton.Size = new System.Drawing.Size(50, 50);
            this.PCButton.TabIndex = 0;
            this.PCButton.UseVisualStyleBackColor = true;
            this.PCButton.Click += new System.EventHandler(this.PCButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(105, 36);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(149, 22);
            this.NameTB.TabIndex = 3;
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Location = new System.Drawing.Point(260, 39);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(30, 17);
            this.InitLabel.TabIndex = 4;
            this.InitLabel.Text = "Init:";
            // 
            // InitTB
            // 
            this.InitTB.Location = new System.Drawing.Point(290, 36);
            this.InitTB.Name = "InitTB";
            this.InitTB.Size = new System.Drawing.Size(32, 22);
            this.InitTB.TabIndex = 5;
            // 
            // MaxHPLabel
            // 
            this.MaxHPLabel.AutoSize = true;
            this.MaxHPLabel.Location = new System.Drawing.Point(56, 66);
            this.MaxHPLabel.Name = "MaxHPLabel";
            this.MaxHPLabel.Size = new System.Drawing.Size(60, 17);
            this.MaxHPLabel.TabIndex = 6;
            this.MaxHPLabel.Text = "Max HP:";
            // 
            // MaxHPTB
            // 
            this.MaxHPTB.Location = new System.Drawing.Point(122, 64);
            this.MaxHPTB.Name = "MaxHPTB";
            this.MaxHPTB.Size = new System.Drawing.Size(45, 22);
            this.MaxHPTB.TabIndex = 7;
            // 
            // CurrHPLabel
            // 
            this.CurrHPLabel.AutoSize = true;
            this.CurrHPLabel.Location = new System.Drawing.Point(173, 67);
            this.CurrHPLabel.Name = "CurrHPLabel";
            this.CurrHPLabel.Size = new System.Drawing.Size(82, 17);
            this.CurrHPLabel.TabIndex = 8;
            this.CurrHPLabel.Text = "Current HP:";
            // 
            // CurrHPTB
            // 
            this.CurrHPTB.Location = new System.Drawing.Point(260, 64);
            this.CurrHPTB.Name = "CurrHPTB";
            this.CurrHPTB.Size = new System.Drawing.Size(45, 22);
            this.CurrHPTB.TabIndex = 9;
            // 
            // ACLabel
            // 
            this.ACLabel.AutoSize = true;
            this.ACLabel.Location = new System.Drawing.Point(56, 95);
            this.ACLabel.Name = "ACLabel";
            this.ACLabel.Size = new System.Drawing.Size(30, 17);
            this.ACLabel.TabIndex = 10;
            this.ACLabel.Text = "AC:";
            // 
            // ACTB
            // 
            this.ACTB.Location = new System.Drawing.Point(92, 92);
            this.ACTB.Name = "ACTB";
            this.ACTB.Size = new System.Drawing.Size(32, 22);
            this.ACTB.TabIndex = 11;
            // 
            // CRTB
            // 
            this.CRTB.Location = new System.Drawing.Point(166, 92);
            this.CRTB.Name = "CRTB";
            this.CRTB.Size = new System.Drawing.Size(32, 22);
            this.CRTB.TabIndex = 13;
            // 
            // CRLabel
            // 
            this.CRLabel.AutoSize = true;
            this.CRLabel.Location = new System.Drawing.Point(130, 95);
            this.CRLabel.Name = "CRLabel";
            this.CRLabel.Size = new System.Drawing.Size(31, 17);
            this.CRLabel.TabIndex = 12;
            this.CRLabel.Text = "CR:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(247, 97);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 132);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CRTB);
            this.Controls.Add(this.CRLabel);
            this.Controls.Add(this.ACTB);
            this.Controls.Add(this.ACLabel);
            this.Controls.Add(this.CurrHPTB);
            this.Controls.Add(this.CurrHPLabel);
            this.Controls.Add(this.MaxHPTB);
            this.Controls.Add(this.MaxHPLabel);
            this.Controls.Add(this.InitTB);
            this.Controls.Add(this.InitLabel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberForm";
            this.Text = "New Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NPCButton;
        private System.Windows.Forms.Button PCButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label InitLabel;
        private System.Windows.Forms.TextBox InitTB;
        private System.Windows.Forms.Label MaxHPLabel;
        private System.Windows.Forms.TextBox MaxHPTB;
        private System.Windows.Forms.Label CurrHPLabel;
        private System.Windows.Forms.TextBox CurrHPTB;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.TextBox ACTB;
        private System.Windows.Forms.TextBox CRTB;
        private System.Windows.Forms.Label CRLabel;
        private System.Windows.Forms.Button AddButton;
    }
}