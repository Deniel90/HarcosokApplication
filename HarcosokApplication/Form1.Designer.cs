namespace HarcosokApplication
{
    partial class HarcosForm
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
            this.groupBoxLetrehozas = new System.Windows.Forms.GroupBox();
            this.buttonHarcosLetrehoz = new System.Windows.Forms.Button();
            this.textBoxHarcosNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxKepesseg = new System.Windows.Forms.GroupBox();
            this.buttonKepessegHozzaad = new System.Windows.Forms.Button();
            this.textBoxKepessegNev = new System.Windows.Forms.TextBox();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.comboBoxHarcosok = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxListazas = new System.Windows.Forms.GroupBox();
            this.buttonLeirasModosit = new System.Windows.Forms.Button();
            this.buttonKepessegTorles = new System.Windows.Forms.Button();
            this.listBoxKepessegek = new System.Windows.Forms.ListBox();
            this.textBoxKepessegLeiras = new System.Windows.Forms.TextBox();
            this.listBoxHarcosok = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxLetrehozas.SuspendLayout();
            this.groupBoxKepesseg.SuspendLayout();
            this.groupBoxListazas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLetrehozas
            // 
            this.groupBoxLetrehozas.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLetrehozas.Controls.Add(this.buttonHarcosLetrehoz);
            this.groupBoxLetrehozas.Controls.Add(this.textBoxHarcosNev);
            this.groupBoxLetrehozas.Controls.Add(this.label3);
            this.groupBoxLetrehozas.Controls.Add(this.label1);
            this.groupBoxLetrehozas.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxLetrehozas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLetrehozas.Name = "groupBoxLetrehozas";
            this.groupBoxLetrehozas.Size = new System.Drawing.Size(481, 88);
            this.groupBoxLetrehozas.TabIndex = 0;
            this.groupBoxLetrehozas.TabStop = false;
            // 
            // buttonHarcosLetrehoz
            // 
            this.buttonHarcosLetrehoz.Location = new System.Drawing.Point(213, 41);
            this.buttonHarcosLetrehoz.Name = "buttonHarcosLetrehoz";
            this.buttonHarcosLetrehoz.Size = new System.Drawing.Size(75, 23);
            this.buttonHarcosLetrehoz.TabIndex = 2;
            this.buttonHarcosLetrehoz.Text = "Létrehozás";
            this.buttonHarcosLetrehoz.UseVisualStyleBackColor = true;
            this.buttonHarcosLetrehoz.Click += new System.EventHandler(this.ButtonHarcosLetrehoz_Click);
            // 
            // textBoxHarcosNev
            // 
            this.textBoxHarcosNev.Location = new System.Drawing.Point(48, 43);
            this.textBoxHarcosNev.MaxLength = 100;
            this.textBoxHarcosNev.Name = "textBoxHarcosNev";
            this.textBoxHarcosNev.Size = new System.Drawing.Size(153, 20);
            this.textBoxHarcosNev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcos létrehozása";
            // 
            // groupBoxKepesseg
            // 
            this.groupBoxKepesseg.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxKepesseg.Controls.Add(this.buttonKepessegHozzaad);
            this.groupBoxKepesseg.Controls.Add(this.textBoxKepessegNev);
            this.groupBoxKepesseg.Controls.Add(this.textBoxLeiras);
            this.groupBoxKepesseg.Controls.Add(this.comboBoxHarcosok);
            this.groupBoxKepesseg.Controls.Add(this.label6);
            this.groupBoxKepesseg.Controls.Add(this.label5);
            this.groupBoxKepesseg.Controls.Add(this.label4);
            this.groupBoxKepesseg.Controls.Add(this.label2);
            this.groupBoxKepesseg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxKepesseg.Location = new System.Drawing.Point(0, 88);
            this.groupBoxKepesseg.Name = "groupBoxKepesseg";
            this.groupBoxKepesseg.Size = new System.Drawing.Size(481, 441);
            this.groupBoxKepesseg.TabIndex = 1;
            this.groupBoxKepesseg.TabStop = false;
            // 
            // buttonKepessegHozzaad
            // 
            this.buttonKepessegHozzaad.Location = new System.Drawing.Point(66, 131);
            this.buttonKepessegHozzaad.Name = "buttonKepessegHozzaad";
            this.buttonKepessegHozzaad.Size = new System.Drawing.Size(173, 23);
            this.buttonKepessegHozzaad.TabIndex = 4;
            this.buttonKepessegHozzaad.Text = "Hozzáad";
            this.buttonKepessegHozzaad.UseVisualStyleBackColor = true;
            this.buttonKepessegHozzaad.Click += new System.EventHandler(this.ButtonKepessegHozzaad_Click);
            // 
            // textBoxKepessegNev
            // 
            this.textBoxKepessegNev.Location = new System.Drawing.Point(66, 92);
            this.textBoxKepessegNev.MaxLength = 100;
            this.textBoxKepessegNev.Name = "textBoxKepessegNev";
            this.textBoxKepessegNev.Size = new System.Drawing.Size(173, 20);
            this.textBoxKepessegNev.TabIndex = 2;
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(259, 49);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(201, 105);
            this.textBoxLeiras.TabIndex = 3;
            // 
            // comboBoxHarcosok
            // 
            this.comboBoxHarcosok.FormattingEnabled = true;
            this.comboBoxHarcosok.Location = new System.Drawing.Point(66, 49);
            this.comboBoxHarcosok.Name = "comboBoxHarcosok";
            this.comboBoxHarcosok.Size = new System.Drawing.Size(173, 21);
            this.comboBoxHarcosok.TabIndex = 1;
            this.comboBoxHarcosok.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHarcosok_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Leírás";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Használó:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Képesség hozzáadása";
            // 
            // groupBoxListazas
            // 
            this.groupBoxListazas.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxListazas.Controls.Add(this.buttonLeirasModosit);
            this.groupBoxListazas.Controls.Add(this.buttonKepessegTorles);
            this.groupBoxListazas.Controls.Add(this.listBoxKepessegek);
            this.groupBoxListazas.Controls.Add(this.textBoxKepessegLeiras);
            this.groupBoxListazas.Controls.Add(this.listBoxHarcosok);
            this.groupBoxListazas.Controls.Add(this.label9);
            this.groupBoxListazas.Controls.Add(this.label8);
            this.groupBoxListazas.Controls.Add(this.label7);
            this.groupBoxListazas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxListazas.Location = new System.Drawing.Point(0, 259);
            this.groupBoxListazas.Name = "groupBoxListazas";
            this.groupBoxListazas.Size = new System.Drawing.Size(481, 270);
            this.groupBoxListazas.TabIndex = 0;
            this.groupBoxListazas.TabStop = false;
            // 
            // buttonLeirasModosit
            // 
            this.buttonLeirasModosit.Location = new System.Drawing.Point(305, 231);
            this.buttonLeirasModosit.Name = "buttonLeirasModosit";
            this.buttonLeirasModosit.Size = new System.Drawing.Size(155, 23);
            this.buttonLeirasModosit.TabIndex = 4;
            this.buttonLeirasModosit.Text = "Módosít";
            this.buttonLeirasModosit.UseVisualStyleBackColor = true;
            this.buttonLeirasModosit.Click += new System.EventHandler(this.ButtonLeirasModosit_Click);
            // 
            // buttonKepessegTorles
            // 
            this.buttonKepessegTorles.Location = new System.Drawing.Point(145, 231);
            this.buttonKepessegTorles.Name = "buttonKepessegTorles";
            this.buttonKepessegTorles.Size = new System.Drawing.Size(143, 23);
            this.buttonKepessegTorles.TabIndex = 4;
            this.buttonKepessegTorles.Text = "Törlés";
            this.buttonKepessegTorles.UseVisualStyleBackColor = true;
            this.buttonKepessegTorles.Click += new System.EventHandler(this.ButtonKepessegTorles_Click);
            // 
            // listBoxKepessegek
            // 
            this.listBoxKepessegek.FormattingEnabled = true;
            this.listBoxKepessegek.Location = new System.Drawing.Point(145, 42);
            this.listBoxKepessegek.Name = "listBoxKepessegek";
            this.listBoxKepessegek.Size = new System.Drawing.Size(143, 173);
            this.listBoxKepessegek.TabIndex = 2;
            this.listBoxKepessegek.SelectedIndexChanged += new System.EventHandler(this.ListBoxKepessegek_SelectedIndexChanged);
            // 
            // textBoxKepessegLeiras
            // 
            this.textBoxKepessegLeiras.Location = new System.Drawing.Point(305, 42);
            this.textBoxKepessegLeiras.Multiline = true;
            this.textBoxKepessegLeiras.Name = "textBoxKepessegLeiras";
            this.textBoxKepessegLeiras.Size = new System.Drawing.Size(155, 173);
            this.textBoxKepessegLeiras.TabIndex = 3;
            // 
            // listBoxHarcosok
            // 
            this.listBoxHarcosok.FormattingEnabled = true;
            this.listBoxHarcosok.Location = new System.Drawing.Point(14, 42);
            this.listBoxHarcosok.Name = "listBoxHarcosok";
            this.listBoxHarcosok.Size = new System.Drawing.Size(111, 212);
            this.listBoxHarcosok.TabIndex = 1;
            this.listBoxHarcosok.SelectedIndexChanged += new System.EventHandler(this.ListBoxHarcosok_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Képesség leírása";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Képességek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Harcosok:";
            // 
            // HarcosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 529);
            this.Controls.Add(this.groupBoxListazas);
            this.Controls.Add(this.groupBoxKepesseg);
            this.Controls.Add(this.groupBoxLetrehozas);
            this.Name = "HarcosForm";
            this.Text = "Harcos";
            this.Load += new System.EventHandler(this.HarcosForm_Load);
            this.groupBoxLetrehozas.ResumeLayout(false);
            this.groupBoxLetrehozas.PerformLayout();
            this.groupBoxKepesseg.ResumeLayout(false);
            this.groupBoxKepesseg.PerformLayout();
            this.groupBoxListazas.ResumeLayout(false);
            this.groupBoxListazas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLetrehozas;
        private System.Windows.Forms.GroupBox groupBoxKepesseg;
        private System.Windows.Forms.GroupBox groupBoxListazas;
        private System.Windows.Forms.Button buttonHarcosLetrehoz;
        private System.Windows.Forms.TextBox textBoxHarcosNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKepessegHozzaad;
        private System.Windows.Forms.TextBox textBoxKepessegNev;
        private System.Windows.Forms.TextBox textBoxLeiras;
        private System.Windows.Forms.ComboBox comboBoxHarcosok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLeirasModosit;
        private System.Windows.Forms.Button buttonKepessegTorles;
        private System.Windows.Forms.ListBox listBoxKepessegek;
        private System.Windows.Forms.TextBox textBoxKepessegLeiras;
        private System.Windows.Forms.ListBox listBoxHarcosok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

