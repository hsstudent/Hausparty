namespace F_Spielprojekt
{
    partial class Optionen
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
            this.rbSchwer = new System.Windows.Forms.RadioButton();
            this.rbMittel = new System.Windows.Forms.RadioButton();
            this.rbLeicht = new System.Windows.Forms.RadioButton();
            this.bSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSchwer
            // 
            this.rbSchwer.AutoSize = true;
            this.rbSchwer.Location = new System.Drawing.Point(51, 87);
            this.rbSchwer.Name = "rbSchwer";
            this.rbSchwer.Size = new System.Drawing.Size(61, 17);
            this.rbSchwer.TabIndex = 11;
            this.rbSchwer.Text = "Schwer";
            this.rbSchwer.UseVisualStyleBackColor = true;
            this.rbSchwer.CheckedChanged += new System.EventHandler(this.rbSchwer_CheckedChanged);
            // 
            // rbMittel
            // 
            this.rbMittel.AutoSize = true;
            this.rbMittel.Location = new System.Drawing.Point(51, 64);
            this.rbMittel.Name = "rbMittel";
            this.rbMittel.Size = new System.Drawing.Size(50, 17);
            this.rbMittel.TabIndex = 10;
            this.rbMittel.Text = "Mittel";
            this.rbMittel.UseVisualStyleBackColor = true;
            this.rbMittel.CheckedChanged += new System.EventHandler(this.rbMittel_CheckedChanged);
            // 
            // rbLeicht
            // 
            this.rbLeicht.AutoSize = true;
            this.rbLeicht.Location = new System.Drawing.Point(51, 41);
            this.rbLeicht.Name = "rbLeicht";
            this.rbLeicht.Size = new System.Drawing.Size(54, 17);
            this.rbLeicht.TabIndex = 9;
            this.rbLeicht.Text = "Leicht";
            this.rbLeicht.UseVisualStyleBackColor = true;
            this.rbLeicht.CheckedChanged += new System.EventHandler(this.rbLeicht_CheckedChanged);
            // 
            // bSpeichern
            // 
            this.bSpeichern.Location = new System.Drawing.Point(51, 129);
            this.bSpeichern.Name = "bSpeichern";
            this.bSpeichern.Size = new System.Drawing.Size(75, 23);
            this.bSpeichern.TabIndex = 8;
            this.bSpeichern.Text = "Übernehmen";
            this.bSpeichern.UseVisualStyleBackColor = true;
            this.bSpeichern.Click += new System.EventHandler(this.bSpeichern_Click);
            // 
            // Optionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 193);
            this.Controls.Add(this.rbSchwer);
            this.Controls.Add(this.rbMittel);
            this.Controls.Add(this.rbLeicht);
            this.Controls.Add(this.bSpeichern);
            this.Name = "Optionen";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSchwer;
        private System.Windows.Forms.RadioButton rbMittel;
        private System.Windows.Forms.RadioButton rbLeicht;
        private System.Windows.Forms.Button bSpeichern;
    }
}