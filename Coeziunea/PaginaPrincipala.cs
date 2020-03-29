using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coeziunea
{
    public partial class PaginaPrincipala : Form
    {
        public PaginaPrincipala()
        {
            InitializeComponent();
        }

        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {
            if (Conectare.conectat != "")
            {
                labelInregistrare.Visible = false;
                buttonConectare.Image = imageListProfil.Images[1];
            }
            else
            {
                buttonConectare.Image = imageListProfil.Images[0];
            }

            if (Conectare.conectat != "")
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();


                string querry = @"SELECT * FROM Mesaje WHERE Catre = '" + Conectare.conectat + "' ";

                SqlCommand com = new SqlCommand(querry, con);
                SqlDataReader reader = com.ExecuteReader();

                int c = 0;
                while (reader.Read())
                {
                    if (reader["Status"].ToString() == "0")
                        c++;
                }

                reader.Close();
                con.Close();

                buttonMsg.Visible = true;
                if (c == 1)
                    buttonMsg.Text = buttonMsg.Text + " (" + c.ToString() + " necitit)";
                else if (c > 1)
                    buttonMsg.Text = buttonMsg.Text + " (" + c.ToString() + " necitite)";
            }
        }

        private void PaginaPrincipala_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            if (Conectare.status == -2)
            {
                this.Hide();
                Login f = new Login();
                f.Show();
            }
            else
            {
                if (Conectare.status == 0 || Conectare.status == 1)
                {
                    this.Hide();
                    ProfilProfesor_Inspector f = new ProfilProfesor_Inspector();
                    f.Show();
                }
                else if (Conectare.status == -1)
                {
                    this.Hide();
                    ProfilElev f = new ProfilElev();
                    f.Show();
                }
            }
        }

        private void labelProfil_Click(object sender, EventArgs e)
        {
            if (Conectare.status == 0 || Conectare.status == 1)
            {
                this.Hide();
                ProfilProfesor_Inspector f = new ProfilProfesor_Inspector();
                f.Show();
            }
            else if (Conectare.status == -1)
            {
                this.Hide();
                ProfilElev f = new ProfilElev();
                f.Show();
            }
        }

        int contor = 0;

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (contor == 2)
                contor = 0;
            else contor++;

            pictureBoxPoza.Image = imageListImg.Images[contor];
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (contor == 0)
                contor = 2;
            else contor--;

            pictureBoxPoza.Image = imageListImg.Images[contor];
        }

        private void buttonGrupSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrupurileSociale f = new GrupurileSociale();
            f.Show();
        }

        private void buttonCoezEuropeana_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrupurileEuropene f = new GrupurileEuropene();
            f.Show();
        }

        private void buttonGrupMilitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrupurileMilitare f = new GrupurileMilitare();
            f.Show();
        }

        private void buttonMsg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mesaje f = new Mesaje();
            f.Show();
        }
    }
}
