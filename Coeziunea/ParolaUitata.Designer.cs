namespace Coeziunea
{
    partial class ParolaUitata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolaUitata));
            this.textBoxSecur = new System.Windows.Forms.TextBox();
            this.textBoxRaspuns = new System.Windows.Forms.TextBox();
            this.buttonVerif = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelRaspuns = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelSecur = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelParola = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSecur
            // 
            this.textBoxSecur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecur.Location = new System.Drawing.Point(239, 101);
            this.textBoxSecur.Name = "textBoxSecur";
            this.textBoxSecur.ReadOnly = true;
            this.textBoxSecur.Size = new System.Drawing.Size(273, 24);
            this.textBoxSecur.TabIndex = 126;
            this.textBoxSecur.Text = "Introduceți codul de securitate:";
            this.textBoxSecur.Visible = false;
            // 
            // textBoxRaspuns
            // 
            this.textBoxRaspuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaspuns.Location = new System.Drawing.Point(149, 143);
            this.textBoxRaspuns.Name = "textBoxRaspuns";
            this.textBoxRaspuns.Size = new System.Drawing.Size(202, 24);
            this.textBoxRaspuns.TabIndex = 128;
            this.textBoxRaspuns.Visible = false;
            // 
            // buttonVerif
            // 
            this.buttonVerif.BackColor = System.Drawing.Color.DarkGray;
            this.buttonVerif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerif.Location = new System.Drawing.Point(614, 190);
            this.buttonVerif.Name = "buttonVerif";
            this.buttonVerif.Size = new System.Drawing.Size(75, 40);
            this.buttonVerif.TabIndex = 140;
            this.buttonVerif.Text = "Ok";
            this.buttonVerif.UseVisualStyleBackColor = false;
            this.buttonVerif.Click += new System.EventHandler(this.buttonVerif_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.textBoxSecur);
            this.panel2.Controls.Add(this.textBoxRaspuns);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelRaspuns);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.labelSecur);
            this.panel2.Location = new System.Drawing.Point(26, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 215);
            this.panel2.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 20);
            this.label4.TabIndex = 139;
            this.label4.Text = "Pentru a-ți recupera parola, te rugăm să completezi următoarele date:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.RosyBrown;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(56, 62);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 134;
            this.labelEmail.Text = "Email:";
            // 
            // labelRaspuns
            // 
            this.labelRaspuns.AutoSize = true;
            this.labelRaspuns.BackColor = System.Drawing.Color.RosyBrown;
            this.labelRaspuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRaspuns.Location = new System.Drawing.Point(56, 145);
            this.labelRaspuns.Name = "labelRaspuns";
            this.labelRaspuns.Size = new System.Drawing.Size(77, 20);
            this.labelRaspuns.TabIndex = 137;
            this.labelRaspuns.Text = "Răspuns:";
            this.labelRaspuns.Visible = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(130, 60);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(328, 24);
            this.textBoxEmail.TabIndex = 135;
            // 
            // labelSecur
            // 
            this.labelSecur.AutoSize = true;
            this.labelSecur.BackColor = System.Drawing.Color.RosyBrown;
            this.labelSecur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSecur.Location = new System.Drawing.Point(56, 103);
            this.labelSecur.Name = "labelSecur";
            this.labelSecur.Size = new System.Drawing.Size(163, 20);
            this.labelSecur.TabIndex = 136;
            this.labelSecur.Text = "Acțiune de securitate:";
            this.labelSecur.Visible = false;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(76, 17);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.ReadOnly = true;
            this.textBoxParola.Size = new System.Drawing.Size(247, 24);
            this.textBoxParola.TabIndex = 124;
            this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.textBoxParola);
            this.panel1.Controls.Add(this.labelParola);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Location = new System.Drawing.Point(189, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 59);
            this.panel1.TabIndex = 138;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.LightSalmon;
            this.labelParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParola.Location = new System.Drawing.Point(12, 19);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(58, 20);
            this.labelParola.TabIndex = 123;
            this.labelParola.Text = "Parolă:";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Care a fost numele primului animal de companie?",
            "Care a fost numele învățătoarei tale?",
            "În ce oraș ai copilărit?",
            "Care este numele filmului preferat?",
            "Ce gen de muzică asculți?",
            "Ce țară ți-ai dori să vizitezi?"});
            this.comboBox5.Location = new System.Drawing.Point(151, -26);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(335, 24);
            this.comboBox5.TabIndex = 133;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInapoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInapoi.BackgroundImage")));
            this.buttonInapoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInapoi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInapoi.Location = new System.Drawing.Point(11, 284);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(61, 40);
            this.buttonInapoi.TabIndex = 142;
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // ParolaUitata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(724, 335);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonVerif);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ParolaUitata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parolă uitată";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParolaUitata_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSecur;
        private System.Windows.Forms.TextBox textBoxRaspuns;
        private System.Windows.Forms.Button buttonVerif;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label labelRaspuns;
        private System.Windows.Forms.Label labelSecur;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonInapoi;
    }
}