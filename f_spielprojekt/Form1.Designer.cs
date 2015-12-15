﻿using System.Windows.Forms;

namespace F_Spielprojekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bOptionen;
        private System.Windows.Forms.Button bHighscore;
        private PictureBox1 pB1;
        private PictureBox1 pB2;
        private PictureBox1 pB3;
        private PictureBox1 pB4;
        private PictureBox1 pB5;
        private PictureBox1 pBPerson;

        public PictureBox1 PB1
        {
            get
            {
                return pB1;
            }

            set
            {
                pB1 = value;
            }
        }

        public PictureBox1 PB2
        {
            get
            {
                return pB2;
            }

            set
            {
                pB2 = value;
            }
        }

        public PictureBox1 PB3
        {
            get
            {
                return pB3;
            }

            set
            {
                pB3 = value;
            }
        }

        public PictureBox1 PB4
        {
            get
            {
                return pB4;
            }

            set
            {
                pB4 = value;
            }
        }

        public PictureBox1 PB5
        {
            get
            {
                return pB5;
            }

            set
            {
                pB5 = value;
            }
        }

        public PictureBox1 PBPerson
        {
            get
            {
                return pBPerson;
            }

            set
            {
                pBPerson = value;
            }
        }


        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bStart = new System.Windows.Forms.Button();
            this.bOptionen = new System.Windows.Forms.Button();
            this.bHighscore = new System.Windows.Forms.Button();
            this.lHighscore = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Enabled = false;
            this.bStart.Location = new System.Drawing.Point(334, 283);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(112, 51);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bOptionen
            // 
            this.bOptionen.Location = new System.Drawing.Point(660, 283);
            this.bOptionen.Name = "bOptionen";
            this.bOptionen.Size = new System.Drawing.Size(112, 51);
            this.bOptionen.TabIndex = 1;
            this.bOptionen.Text = "Optionen";
            this.bOptionen.UseVisualStyleBackColor = true;
            this.bOptionen.Click += new System.EventHandler(this.bOptionen_Click);
            // 
            // bHighscore
            // 
            this.bHighscore.Location = new System.Drawing.Point(10, 283);
            this.bHighscore.Name = "bHighscore";
            this.bHighscore.Size = new System.Drawing.Size(112, 51);
            this.bHighscore.TabIndex = 2;
            this.bHighscore.Text = "Highscore";
            this.bHighscore.UseVisualStyleBackColor = true;
            this.bHighscore.Click += new System.EventHandler(this.bHighscore_Click);
            // 
            // lHighscore
            // 
            this.lHighscore.AutoSize = true;
            this.lHighscore.BackColor = System.Drawing.Color.Transparent;
            this.lHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHighscore.Location = new System.Drawing.Point(582, 18);
            this.lHighscore.Name = "lHighscore";
            this.lHighscore.Size = new System.Drawing.Size(114, 16);
            this.lHighscore.TabIndex = 13;
            this.lHighscore.Text = "Highscore: XXX";
            this.lHighscore.Visible = false;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lName.Location = new System.Drawing.Point(154, 63);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(214, 25);
            this.lName.TabIndex = 12;
            this.lName.Text = "Spielername eintragen:";
            // 
            // rtbName
            // 
            this.rtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbName.Location = new System.Drawing.Point(374, 63);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(168, 25);
            this.rtbName.TabIndex = 11;
            this.rtbName.Text = "";
            this.rtbName.TextChanged += new System.EventHandler(this.rtbName_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.bStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 342);
            this.Controls.Add(this.lHighscore);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.bHighscore);
            this.Controls.Add(this.bOptionen);
            this.Controls.Add(this.bStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 380);
            this.MinimumSize = new System.Drawing.Size(800, 380);
            this.Name = "Form1";
            this.Text = "DasgeilsteSpielderWelt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lHighscore;
        private Label lName;
        private RichTextBox rtbName;
    }
}

