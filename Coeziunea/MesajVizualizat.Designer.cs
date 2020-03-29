namespace Coeziunea
{
    partial class MesajVizualizat
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
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSubiect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxMesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.Peru;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.Location = new System.Drawing.Point(12, 372);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(114, 45);
            this.buttonInapoi.TabIndex = 173;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.BackColor = System.Drawing.Color.Linen;
            this.comboBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(94, 22);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(339, 24);
            this.comboBoxEmail.TabIndex = 172;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Peru;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(527, 372);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 45);
            this.buttonEdit.TabIndex = 171;
            this.buttonEdit.Text = "Retrimite";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSubiect
            // 
            this.textBoxSubiect.BackColor = System.Drawing.Color.Linen;
            this.textBoxSubiect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubiect.Location = new System.Drawing.Point(94, 60);
            this.textBoxSubiect.Name = "textBoxSubiect";
            this.textBoxSubiect.ReadOnly = true;
            this.textBoxSubiect.Size = new System.Drawing.Size(491, 24);
            this.textBoxSubiect.TabIndex = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "Subiect:";
            // 
            // richTextBoxMesaj
            // 
            this.richTextBoxMesaj.BackColor = System.Drawing.Color.Linen;
            this.richTextBoxMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMesaj.Location = new System.Drawing.Point(25, 141);
            this.richTextBoxMesaj.Name = "richTextBoxMesaj";
            this.richTextBoxMesaj.ReadOnly = true;
            this.richTextBoxMesaj.Size = new System.Drawing.Size(599, 212);
            this.richTextBoxMesaj.TabIndex = 168;
            this.richTextBoxMesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "Mesaj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "Către:";
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.Color.Linen;
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(439, 107);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(185, 22);
            this.textBoxData.TabIndex = 174;
            // 
            // MesajVizualizat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(653, 428);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSubiect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MesajVizualizat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizarea mesajului";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MesajVizualizat_FormClosing);
            this.Load += new System.EventHandler(this.MesajVizualizat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSubiect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxData;
    }
}