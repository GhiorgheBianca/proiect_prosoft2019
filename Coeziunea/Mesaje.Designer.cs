namespace Coeziunea
{
    partial class Mesaje
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMesPrimite = new System.Windows.Forms.TabPage();
            this.buttonViz = new System.Windows.Forms.Button();
            this.comboBoxOptiuni = new System.Windows.Forms.ComboBox();
            this.buttonSterg = new System.Windows.Forms.Button();
            this.checkedListBoxMesPrimite = new System.Windows.Forms.CheckedListBox();
            this.tabPageMesTrimise = new System.Windows.Forms.TabPage();
            this.tabPageMesSterse = new System.Windows.Forms.TabPage();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonScrie = new System.Windows.Forms.Button();
            this.buttonVadTrim = new System.Windows.Forms.Button();
            this.comboBoxOptiuniTrim = new System.Windows.Forms.ComboBox();
            this.buttonStergTrim = new System.Windows.Forms.Button();
            this.checkedListBoxMesTrimise = new System.Windows.Forms.CheckedListBox();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.comboBoxOptiuniSterg = new System.Windows.Forms.ComboBox();
            this.buttonStergDef = new System.Windows.Forms.Button();
            this.checkedListBoxMesSterse = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMesPrimite.SuspendLayout();
            this.tabPageMesTrimise.SuspendLayout();
            this.tabPageMesSterse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMesPrimite);
            this.tabControl1.Controls.Add(this.tabPageMesTrimise);
            this.tabControl1.Controls.Add(this.tabPageMesSterse);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMesPrimite
            // 
            this.tabPageMesPrimite.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPageMesPrimite.Controls.Add(this.buttonViz);
            this.tabPageMesPrimite.Controls.Add(this.comboBoxOptiuni);
            this.tabPageMesPrimite.Controls.Add(this.buttonSterg);
            this.tabPageMesPrimite.Controls.Add(this.checkedListBoxMesPrimite);
            this.tabPageMesPrimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMesPrimite.Location = new System.Drawing.Point(4, 25);
            this.tabPageMesPrimite.Name = "tabPageMesPrimite";
            this.tabPageMesPrimite.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMesPrimite.Size = new System.Drawing.Size(768, 360);
            this.tabPageMesPrimite.TabIndex = 0;
            this.tabPageMesPrimite.Text = "Mesaje primite";
            // 
            // buttonViz
            // 
            this.buttonViz.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonViz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViz.Location = new System.Drawing.Point(142, 16);
            this.buttonViz.Name = "buttonViz";
            this.buttonViz.Size = new System.Drawing.Size(163, 35);
            this.buttonViz.TabIndex = 3;
            this.buttonViz.Text = "Vizualizează mesajul";
            this.buttonViz.UseVisualStyleBackColor = false;
            this.buttonViz.Click += new System.EventHandler(this.buttonViz_Click);
            // 
            // comboBoxOptiuni
            // 
            this.comboBoxOptiuni.FormattingEnabled = true;
            this.comboBoxOptiuni.Items.AddRange(new object[] {
            "Selectează toate căsuțele",
            "Deselectează toate căsuțele"});
            this.comboBoxOptiuni.Location = new System.Drawing.Point(336, 22);
            this.comboBoxOptiuni.Name = "comboBoxOptiuni";
            this.comboBoxOptiuni.Size = new System.Drawing.Size(197, 24);
            this.comboBoxOptiuni.TabIndex = 2;
            this.comboBoxOptiuni.Text = "Opțiuni";
            this.comboBoxOptiuni.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptiuni_SelectedIndexChanged);
            // 
            // buttonSterg
            // 
            this.buttonSterg.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSterg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSterg.Location = new System.Drawing.Point(15, 16);
            this.buttonSterg.Name = "buttonSterg";
            this.buttonSterg.Size = new System.Drawing.Size(108, 35);
            this.buttonSterg.TabIndex = 1;
            this.buttonSterg.Text = "Șterge";
            this.buttonSterg.UseVisualStyleBackColor = false;
            this.buttonSterg.Click += new System.EventHandler(this.buttonSterg_Click);
            // 
            // checkedListBoxMesPrimite
            // 
            this.checkedListBoxMesPrimite.BackColor = System.Drawing.Color.FloralWhite;
            this.checkedListBoxMesPrimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMesPrimite.FormattingEnabled = true;
            this.checkedListBoxMesPrimite.Location = new System.Drawing.Point(15, 59);
            this.checkedListBoxMesPrimite.Name = "checkedListBoxMesPrimite";
            this.checkedListBoxMesPrimite.Size = new System.Drawing.Size(737, 270);
            this.checkedListBoxMesPrimite.TabIndex = 0;
            // 
            // tabPageMesTrimise
            // 
            this.tabPageMesTrimise.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPageMesTrimise.Controls.Add(this.buttonVadTrim);
            this.tabPageMesTrimise.Controls.Add(this.comboBoxOptiuniTrim);
            this.tabPageMesTrimise.Controls.Add(this.buttonStergTrim);
            this.tabPageMesTrimise.Controls.Add(this.checkedListBoxMesTrimise);
            this.tabPageMesTrimise.Location = new System.Drawing.Point(4, 25);
            this.tabPageMesTrimise.Name = "tabPageMesTrimise";
            this.tabPageMesTrimise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMesTrimise.Size = new System.Drawing.Size(768, 360);
            this.tabPageMesTrimise.TabIndex = 1;
            this.tabPageMesTrimise.Text = "Mesaje trimise";
            // 
            // tabPageMesSterse
            // 
            this.tabPageMesSterse.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPageMesSterse.Controls.Add(this.buttonRestore);
            this.tabPageMesSterse.Controls.Add(this.comboBoxOptiuniSterg);
            this.tabPageMesSterse.Controls.Add(this.buttonStergDef);
            this.tabPageMesSterse.Controls.Add(this.checkedListBoxMesSterse);
            this.tabPageMesSterse.Location = new System.Drawing.Point(4, 25);
            this.tabPageMesSterse.Name = "tabPageMesSterse";
            this.tabPageMesSterse.Size = new System.Drawing.Size(768, 360);
            this.tabPageMesSterse.TabIndex = 2;
            this.tabPageMesSterse.Text = "Mesaje șterse";
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.Olive;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInapoi.Location = new System.Drawing.Point(12, 407);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(114, 45);
            this.buttonInapoi.TabIndex = 167;
            this.buttonInapoi.Text = "Înapoi";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonScrie
            // 
            this.buttonScrie.BackColor = System.Drawing.Color.Olive;
            this.buttonScrie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScrie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonScrie.Location = new System.Drawing.Point(674, 407);
            this.buttonScrie.Name = "buttonScrie";
            this.buttonScrie.Size = new System.Drawing.Size(114, 45);
            this.buttonScrie.TabIndex = 166;
            this.buttonScrie.Text = "Scrie";
            this.buttonScrie.UseVisualStyleBackColor = false;
            this.buttonScrie.Click += new System.EventHandler(this.buttonScrie_Click);
            // 
            // buttonVadTrim
            // 
            this.buttonVadTrim.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonVadTrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVadTrim.Location = new System.Drawing.Point(142, 16);
            this.buttonVadTrim.Name = "buttonVadTrim";
            this.buttonVadTrim.Size = new System.Drawing.Size(163, 35);
            this.buttonVadTrim.TabIndex = 7;
            this.buttonVadTrim.Text = "Vizualizează mesajul";
            this.buttonVadTrim.UseVisualStyleBackColor = false;
            this.buttonVadTrim.Click += new System.EventHandler(this.buttonVadTrim_Click);
            // 
            // comboBoxOptiuniTrim
            // 
            this.comboBoxOptiuniTrim.FormattingEnabled = true;
            this.comboBoxOptiuniTrim.Items.AddRange(new object[] {
            "Selectează toate căsuțele",
            "Deselectează toate căsuțele"});
            this.comboBoxOptiuniTrim.Location = new System.Drawing.Point(336, 22);
            this.comboBoxOptiuniTrim.Name = "comboBoxOptiuniTrim";
            this.comboBoxOptiuniTrim.Size = new System.Drawing.Size(197, 24);
            this.comboBoxOptiuniTrim.TabIndex = 6;
            this.comboBoxOptiuniTrim.Text = "Opțiuni";
            this.comboBoxOptiuniTrim.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptiuniTrim_SelectedIndexChanged);
            // 
            // buttonStergTrim
            // 
            this.buttonStergTrim.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStergTrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStergTrim.Location = new System.Drawing.Point(15, 16);
            this.buttonStergTrim.Name = "buttonStergTrim";
            this.buttonStergTrim.Size = new System.Drawing.Size(108, 35);
            this.buttonStergTrim.TabIndex = 5;
            this.buttonStergTrim.Text = "Șterge";
            this.buttonStergTrim.UseVisualStyleBackColor = false;
            this.buttonStergTrim.Click += new System.EventHandler(this.buttonStergTrim_Click);
            // 
            // checkedListBoxMesTrimise
            // 
            this.checkedListBoxMesTrimise.BackColor = System.Drawing.Color.FloralWhite;
            this.checkedListBoxMesTrimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMesTrimise.FormattingEnabled = true;
            this.checkedListBoxMesTrimise.Location = new System.Drawing.Point(15, 59);
            this.checkedListBoxMesTrimise.Name = "checkedListBoxMesTrimise";
            this.checkedListBoxMesTrimise.Size = new System.Drawing.Size(737, 270);
            this.checkedListBoxMesTrimise.TabIndex = 4;
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestore.Location = new System.Drawing.Point(178, 16);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(127, 35);
            this.buttonRestore.TabIndex = 11;
            this.buttonRestore.Text = "Recuperează";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // comboBoxOptiuniSterg
            // 
            this.comboBoxOptiuniSterg.FormattingEnabled = true;
            this.comboBoxOptiuniSterg.Items.AddRange(new object[] {
            "Selectează toate căsuțele",
            "Deselectează toate căsuțele"});
            this.comboBoxOptiuniSterg.Location = new System.Drawing.Point(336, 22);
            this.comboBoxOptiuniSterg.Name = "comboBoxOptiuniSterg";
            this.comboBoxOptiuniSterg.Size = new System.Drawing.Size(197, 24);
            this.comboBoxOptiuniSterg.TabIndex = 10;
            this.comboBoxOptiuniSterg.Text = "Opțiuni";
            this.comboBoxOptiuniSterg.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptiuniSterg_SelectedIndexChanged);
            // 
            // buttonStergDef
            // 
            this.buttonStergDef.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonStergDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStergDef.Location = new System.Drawing.Point(15, 16);
            this.buttonStergDef.Name = "buttonStergDef";
            this.buttonStergDef.Size = new System.Drawing.Size(145, 35);
            this.buttonStergDef.TabIndex = 9;
            this.buttonStergDef.Text = "Șterge definitiv";
            this.buttonStergDef.UseVisualStyleBackColor = false;
            this.buttonStergDef.Click += new System.EventHandler(this.buttonStergDef_Click);
            // 
            // checkedListBoxMesSterse
            // 
            this.checkedListBoxMesSterse.BackColor = System.Drawing.Color.FloralWhite;
            this.checkedListBoxMesSterse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMesSterse.FormattingEnabled = true;
            this.checkedListBoxMesSterse.Location = new System.Drawing.Point(15, 59);
            this.checkedListBoxMesSterse.Name = "checkedListBoxMesSterse";
            this.checkedListBoxMesSterse.Size = new System.Drawing.Size(737, 270);
            this.checkedListBoxMesSterse.TabIndex = 8;
            // 
            // Mesaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonScrie);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mesaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mesaje_FormClosing);
            this.Load += new System.EventHandler(this.Mesaje_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMesPrimite.ResumeLayout(false);
            this.tabPageMesTrimise.ResumeLayout(false);
            this.tabPageMesSterse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMesPrimite;
        private System.Windows.Forms.TabPage tabPageMesTrimise;
        private System.Windows.Forms.TabPage tabPageMesSterse;
        private System.Windows.Forms.CheckedListBox checkedListBoxMesPrimite;
        private System.Windows.Forms.Button buttonSterg;
        private System.Windows.Forms.ComboBox comboBoxOptiuni;
        private System.Windows.Forms.Button buttonViz;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonScrie;
        private System.Windows.Forms.Button buttonVadTrim;
        private System.Windows.Forms.ComboBox comboBoxOptiuniTrim;
        private System.Windows.Forms.Button buttonStergTrim;
        private System.Windows.Forms.CheckedListBox checkedListBoxMesTrimise;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.ComboBox comboBoxOptiuniSterg;
        private System.Windows.Forms.Button buttonStergDef;
        private System.Windows.Forms.CheckedListBox checkedListBoxMesSterse;
    }
}