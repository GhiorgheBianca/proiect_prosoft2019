using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coeziunea
{
    public partial class SchimbParola : Form
    {
        public SchimbParola()
        {
            InitializeComponent();
        }

        int i = 0;

        private void buttonOchi_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                buttonOchi.Image = imageListOchi.Images[1];
                textBoxParola.UseSystemPasswordChar = false;
                i = 1;
            }
            else if (i == 1)
            {
                buttonOchi.Image = imageListOchi.Images[0];
                textBoxParola.UseSystemPasswordChar = true;
                i = 0;
            }
        }

        private void textBoxParola_KeyDown(object sender, KeyEventArgs e)
        {
            Conectare.VerifPar = false;
            if (e.KeyCode == Keys.Enter)
            {
                if (Conectare.Parola == textBoxParola.Text)
                {
                    Conectare.VerifPar = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Parolă incorectă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
