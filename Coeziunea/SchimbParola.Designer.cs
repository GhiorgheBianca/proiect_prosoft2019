namespace Coeziunea
{
    partial class SchimbParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchimbParola));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOchi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.imageListOchi = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 15);
            this.label2.TabIndex = 141;
            this.label2.Text = "Notă: La terminare, apăsați tasta Enter.";
            // 
            // buttonOchi
            // 
            this.buttonOchi.BackColor = System.Drawing.Color.DarkGray;
            this.buttonOchi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOchi.BackgroundImage")));
            this.buttonOchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOchi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOchi.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonOchi.Location = new System.Drawing.Point(364, 88);
            this.buttonOchi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOchi.Name = "buttonOchi";
            this.buttonOchi.Size = new System.Drawing.Size(34, 29);
            this.buttonOchi.TabIndex = 140;
            this.buttonOchi.UseVisualStyleBackColor = false;
            this.buttonOchi.Click += new System.EventHandler(this.buttonOchi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 139;
            this.label1.Text = "Pentru a schimba parola, rescrieți-o pe cea veche:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Parolă:";
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxParola.Location = new System.Drawing.Point(103, 91);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(256, 24);
            this.textBoxParola.TabIndex = 137;
            this.textBoxParola.UseSystemPasswordChar = true;
            this.textBoxParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxParola_KeyDown);
            // 
            // imageListOchi
            // 
            this.imageListOchi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOchi.ImageStream")));
            this.imageListOchi.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOchi.Images.SetKeyName(0, "eye1.png");
            this.imageListOchi.Images.SetKeyName(1, "eye2.png");
            // 
            // SchimbParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(455, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOchi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxParola);
            this.Name = "SchimbParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOchi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.ImageList imageListOchi;
    }
}