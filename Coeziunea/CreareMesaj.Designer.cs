namespace Coeziunea
{
    partial class CreareMesaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMesaj = new System.Windows.Forms.RichTextBox();
            this.textBoxSubiect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTrimite = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Către:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesaj:";
            // 
            // richTextBoxMesaj
            // 
            this.richTextBoxMesaj.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBoxMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMesaj.Location = new System.Drawing.Point(28, 150);
            this.richTextBoxMesaj.Name = "richTextBoxMesaj";
            this.richTextBoxMesaj.Size = new System.Drawing.Size(575, 212);
            this.richTextBoxMesaj.TabIndex = 3;
            this.richTextBoxMesaj.Text = "";
            // 
            // textBoxSubiect
            // 
            this.textBoxSubiect.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxSubiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubiect.Location = new System.Drawing.Point(97, 69);
            this.textBoxSubiect.Name = "textBoxSubiect";
            this.textBoxSubiect.Size = new System.Drawing.Size(491, 24);
            this.textBoxSubiect.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subiect:";
            // 
            // buttonTrimite
            // 
            this.buttonTrimite.BackColor = System.Drawing.Color.Peru;
            this.buttonTrimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrimite.Location = new System.Drawing.Point(509, 385);
            this.buttonTrimite.Name = "buttonTrimite";
            this.buttonTrimite.Size = new System.Drawing.Size(114, 45);
            this.buttonTrimite.TabIndex = 6;
            this.buttonTrimite.Text = "Trimite";
            this.buttonTrimite.UseVisualStyleBackColor = false;
            this.buttonTrimite.Click += new System.EventHandler(this.buttonTrimite_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.BackColor = System.Drawing.Color.SeaShell;
            this.comboBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(97, 31);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(339, 24);
            this.comboBoxEmail.TabIndex = 7;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.Peru;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.Location = new System.Drawing.Point(12, 385);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(114, 45);
            this.buttonInapoi.TabIndex = 165;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // CreareMesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(633, 442);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.buttonTrimite);
            this.Controls.Add(this.textBoxSubiect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreareMesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crearea mesajului";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreareMesaj_FormClosing);
            this.Load += new System.EventHandler(this.CreareMesaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxMesaj;
        private System.Windows.Forms.TextBox textBoxSubiect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTrimite;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Button buttonInapoi;
    }
}