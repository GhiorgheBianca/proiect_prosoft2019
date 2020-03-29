namespace Coeziunea
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelParolaUitata = new System.Windows.Forms.Label();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonAcces = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttonVezi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.imageListButoane = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelParolaUitata
            // 
            this.labelParolaUitata.AutoSize = true;
            this.labelParolaUitata.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelParolaUitata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelParolaUitata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParolaUitata.ForeColor = System.Drawing.Color.Navy;
            this.labelParolaUitata.Location = new System.Drawing.Point(3, 174);
            this.labelParolaUitata.Name = "labelParolaUitata";
            this.labelParolaUitata.Size = new System.Drawing.Size(233, 16);
            this.labelParolaUitata.TabIndex = 121;
            this.labelParolaUitata.Text = "*Mi-am uitat parola. (doar pentru elevi)";
            this.labelParolaUitata.Click += new System.EventHandler(this.labelParolaUitata_Click);
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInapoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInapoi.BackgroundImage")));
            this.buttonInapoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInapoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInapoi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInapoi.Location = new System.Drawing.Point(11, 298);
            this.buttonInapoi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(61, 40);
            this.buttonInapoi.TabIndex = 120;
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonAcces
            // 
            this.buttonAcces.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAcces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAcces.Location = new System.Drawing.Point(513, 298);
            this.buttonAcces.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAcces.Name = "buttonAcces";
            this.buttonAcces.Size = new System.Drawing.Size(102, 39);
            this.buttonAcces.TabIndex = 119;
            this.buttonAcces.Text = "Accesează";
            this.buttonAcces.UseVisualStyleBackColor = false;
            this.buttonAcces.Click += new System.EventHandler(this.buttonAcces_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(527, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "Principalul beneficiu al conectării e că datele dumneavoastră vor fi salvate.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "Pentru a vă conecta, vă rugăm să introduceţi:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.labelParolaUitata);
            this.panel1.Controls.Add(this.comboBoxTip);
            this.panel1.Controls.Add(this.labelTip);
            this.panel1.Controls.Add(this.buttonVezi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxParola);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelParola);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Location = new System.Drawing.Point(27, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 197);
            this.panel1.TabIndex = 116;
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Profesor/Inspector",
            "Elev"});
            this.comboBoxTip.Location = new System.Drawing.Point(100, 115);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(164, 23);
            this.comboBoxTip.TabIndex = 122;
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_SelectedIndexChanged);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTip.Location = new System.Drawing.Point(10, 118);
            this.labelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(77, 20);
            this.labelTip.TabIndex = 123;
            this.labelTip.Text = "Ocupație:";
            // 
            // buttonVezi
            // 
            this.buttonVezi.BackColor = System.Drawing.Color.DarkGray;
            this.buttonVezi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVezi.BackgroundImage")));
            this.buttonVezi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVezi.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonVezi.Location = new System.Drawing.Point(350, 66);
            this.buttonVezi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVezi.Name = "buttonVezi";
            this.buttonVezi.Size = new System.Drawing.Size(34, 29);
            this.buttonVezi.TabIndex = 135;
            this.buttonVezi.UseVisualStyleBackColor = false;
            this.buttonVezi.Click += new System.EventHandler(this.buttonVezi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxParola.Location = new System.Drawing.Point(100, 68);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(246, 24);
            this.textBoxParola.TabIndex = 104;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.Location = new System.Drawing.Point(100, 22);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(246, 24);
            this.textBoxEmail.TabIndex = 102;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelParola.Location = new System.Drawing.Point(10, 72);
            this.labelParola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(58, 20);
            this.labelParola.TabIndex = 105;
            this.labelParola.Text = "Parolă:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(10, 26);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 103;
            this.labelEmail.Text = "Email:";
            // 
            // imageListButoane
            // 
            this.imageListButoane.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButoane.ImageStream")));
            this.imageListButoane.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButoane.Images.SetKeyName(0, "eye1.png");
            this.imageListButoane.Images.SetKeyName(1, "eye2.png");
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(626, 349);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.buttonAcces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagină de autentificare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParolaUitata;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonAcces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVezi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ImageList imageListButoane;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label labelTip;
    }
}