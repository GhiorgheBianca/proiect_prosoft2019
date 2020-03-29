namespace Coeziunea
{
    partial class TestCooperare
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
            this.groupBoxIntrebare = new System.Windows.Forms.GroupBox();
            this.progressBarRaspuns = new System.Windows.Forms.ProgressBar();
            this.checkBoxMulte = new System.Windows.Forms.CheckBox();
            this.checkBoxNici = new System.Windows.Forms.CheckBox();
            this.checkBoxMereu = new System.Windows.Forms.CheckBox();
            this.checkBoxPutin = new System.Windows.Forms.CheckBox();
            this.checkBoxDepinde = new System.Windows.Forms.CheckBox();
            this.buttonUrmat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCsec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.timerCronom = new System.Windows.Forms.Timer(this.components);
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.groupBoxIntrebare.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIntrebare
            // 
            this.groupBoxIntrebare.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxIntrebare.Controls.Add(this.progressBarRaspuns);
            this.groupBoxIntrebare.Controls.Add(this.checkBoxMulte);
            this.groupBoxIntrebare.Controls.Add(this.checkBoxNici);
            this.groupBoxIntrebare.Controls.Add(this.checkBoxMereu);
            this.groupBoxIntrebare.Controls.Add(this.checkBoxPutin);
            this.groupBoxIntrebare.Controls.Add(this.checkBoxDepinde);
            this.groupBoxIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIntrebare.Location = new System.Drawing.Point(12, 76);
            this.groupBoxIntrebare.Name = "groupBoxIntrebare";
            this.groupBoxIntrebare.Size = new System.Drawing.Size(764, 127);
            this.groupBoxIntrebare.TabIndex = 0;
            this.groupBoxIntrebare.TabStop = false;
            this.groupBoxIntrebare.Text = "Întrebare";
            // 
            // progressBarRaspuns
            // 
            this.progressBarRaspuns.Location = new System.Drawing.Point(51, 95);
            this.progressBarRaspuns.Name = "progressBarRaspuns";
            this.progressBarRaspuns.Size = new System.Drawing.Size(659, 16);
            this.progressBarRaspuns.TabIndex = 5;
            // 
            // checkBoxMulte
            // 
            this.checkBoxMulte.AutoSize = true;
            this.checkBoxMulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMulte.Location = new System.Drawing.Point(480, 52);
            this.checkBoxMulte.Name = "checkBoxMulte";
            this.checkBoxMulte.Size = new System.Drawing.Size(120, 24);
            this.checkBoxMulte.TabIndex = 3;
            this.checkBoxMulte.Text = "De multe ori";
            this.checkBoxMulte.UseVisualStyleBackColor = true;
            this.checkBoxMulte.Click += new System.EventHandler(this.checkBoxMulte_Click);
            // 
            // checkBoxNici
            // 
            this.checkBoxNici.AutoSize = true;
            this.checkBoxNici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNici.Location = new System.Drawing.Point(51, 52);
            this.checkBoxNici.Name = "checkBoxNici";
            this.checkBoxNici.Size = new System.Drawing.Size(98, 24);
            this.checkBoxNici.TabIndex = 0;
            this.checkBoxNici.Text = "Niciodată";
            this.checkBoxNici.UseVisualStyleBackColor = true;
            this.checkBoxNici.Click += new System.EventHandler(this.checkBoxNici_Click);
            // 
            // checkBoxMereu
            // 
            this.checkBoxMereu.AutoSize = true;
            this.checkBoxMereu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMereu.Location = new System.Drawing.Point(635, 52);
            this.checkBoxMereu.Name = "checkBoxMereu";
            this.checkBoxMereu.Size = new System.Drawing.Size(75, 24);
            this.checkBoxMereu.TabIndex = 4;
            this.checkBoxMereu.Text = "Mereu";
            this.checkBoxMereu.UseVisualStyleBackColor = true;
            this.checkBoxMereu.Click += new System.EventHandler(this.checkBoxMereu_Click);
            // 
            // checkBoxPutin
            // 
            this.checkBoxPutin.AutoSize = true;
            this.checkBoxPutin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPutin.Location = new System.Drawing.Point(191, 52);
            this.checkBoxPutin.Name = "checkBoxPutin";
            this.checkBoxPutin.Size = new System.Drawing.Size(124, 24);
            this.checkBoxPutin.TabIndex = 1;
            this.checkBoxPutin.Text = "De puține ori";
            this.checkBoxPutin.UseVisualStyleBackColor = true;
            this.checkBoxPutin.Click += new System.EventHandler(this.checkBoxPutin_Click);
            // 
            // checkBoxDepinde
            // 
            this.checkBoxDepinde.AutoSize = true;
            this.checkBoxDepinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDepinde.Location = new System.Drawing.Point(357, 52);
            this.checkBoxDepinde.Name = "checkBoxDepinde";
            this.checkBoxDepinde.Size = new System.Drawing.Size(90, 24);
            this.checkBoxDepinde.TabIndex = 2;
            this.checkBoxDepinde.Text = "Depinde";
            this.checkBoxDepinde.UseVisualStyleBackColor = true;
            this.checkBoxDepinde.Click += new System.EventHandler(this.checkBoxDepinde_Click);
            // 
            // buttonUrmat
            // 
            this.buttonUrmat.BackColor = System.Drawing.Color.LightGray;
            this.buttonUrmat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUrmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUrmat.Location = new System.Drawing.Point(621, 231);
            this.buttonUrmat.Name = "buttonUrmat";
            this.buttonUrmat.Size = new System.Drawing.Size(157, 49);
            this.buttonUrmat.TabIndex = 1;
            this.buttonUrmat.Text = "Următoarea întrebare";
            this.buttonUrmat.UseVisualStyleBackColor = false;
            this.buttonUrmat.Click += new System.EventHandler(this.buttonUrmat_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelCsec);
            this.panel5.Controls.Add(this.labelMin);
            this.panel5.Controls.Add(this.labelSec);
            this.panel5.Location = new System.Drawing.Point(657, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 39);
            this.panel5.TabIndex = 9;
            // 
            // labelCsec
            // 
            this.labelCsec.AutoSize = true;
            this.labelCsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCsec.Location = new System.Drawing.Point(81, 7);
            this.labelCsec.Name = "labelCsec";
            this.labelCsec.Size = new System.Drawing.Size(30, 24);
            this.labelCsec.TabIndex = 7;
            this.labelCsec.Text = "00";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(9, 7);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(40, 24);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "00 :";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.Location = new System.Drawing.Point(45, 7);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(40, 24);
            this.labelSec.TabIndex = 6;
            this.labelSec.Text = "00 .";
            // 
            // timerCronom
            // 
            this.timerCronom.Tick += new System.EventHandler(this.timerCronom_Tick);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.LightGray;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.Location = new System.Drawing.Point(12, 239);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(114, 45);
            this.buttonInapoi.TabIndex = 165;
            this.buttonInapoi.Text = "Ieși din test";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // TestCooperare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(790, 296);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonUrmat);
            this.Controls.Add(this.groupBoxIntrebare);
            this.Name = "TestCooperare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testul de Cooperare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestCooperare_FormClosing);
            this.Load += new System.EventHandler(this.TestCooperare_Load);
            this.groupBoxIntrebare.ResumeLayout(false);
            this.groupBoxIntrebare.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIntrebare;
        private System.Windows.Forms.ProgressBar progressBarRaspuns;
        private System.Windows.Forms.Button buttonUrmat;
        private System.Windows.Forms.CheckBox checkBoxMereu;
        private System.Windows.Forms.CheckBox checkBoxMulte;
        private System.Windows.Forms.CheckBox checkBoxDepinde;
        private System.Windows.Forms.CheckBox checkBoxPutin;
        private System.Windows.Forms.CheckBox checkBoxNici;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelCsec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Timer timerCronom;
        private System.Windows.Forms.Button buttonInapoi;
    }
}