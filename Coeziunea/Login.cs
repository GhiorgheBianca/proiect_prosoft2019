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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int i = 0;

        private void buttonAcces_Click(object sender, EventArgs e)
        {
            if (comboBoxTip.SelectedIndex == 0)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_profesori_inspectori WHERE Email = '" + textBoxEmail.Text + "' ";

                SqlCommand com = new SqlCommand(querry, con);
                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows == true)
                {
                    textBoxEmail.BackColor = System.Drawing.Color.White;
                    textBoxEmail.ForeColor = System.Drawing.Color.Black;
                    textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Regular);

                    con.Close();
                    con.Open();
                    querry = @"SELECT * FROM Conturi_profesori_inspectori WHERE Email = '" + textBoxEmail.Text + "' AND Parola = '" + textBoxParola.Text + "' ";

                    SqlCommand com1 = new SqlCommand(querry, con);
                    reader = com1.ExecuteReader();


                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                            if (reader["Scoala"].ToString() == "" || reader["Clase"].ToString() == "")
                                Conectare.status = 1;
                            else Conectare.status = 0;

                        reader.Close();

                        Conectare.conectat = textBoxEmail.Text;
                        textBoxParola.BackColor = System.Drawing.Color.White;
                        textBoxParola.ForeColor = System.Drawing.Color.Black;

                        this.Hide();
                        ProfilProfesor_Inspector f = new ProfilProfesor_Inspector();
                        f.Show();
                    }
                    else
                    {
                        textBoxParola.BackColor = System.Drawing.Color.DarkOrange;
                        textBoxParola.ForeColor = System.Drawing.Color.White;
                        textBoxEmail.BackColor = System.Drawing.Color.White;
                        textBoxEmail.ForeColor = System.Drawing.Color.Black;
                        textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Regular);

                        MessageBox.Show("Parolă incorectă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    textBoxEmail.BackColor = System.Drawing.Color.DarkOrange;
                    textBoxEmail.ForeColor = System.Drawing.Color.White;
                    textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Bold);

                    MessageBox.Show("Email sau ocupație invalidă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            else if (comboBoxTip.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Email = '" + textBoxEmail.Text + "' ";

                SqlCommand com = new SqlCommand(querry, con);
                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows == true)
                {
                    textBoxEmail.BackColor = System.Drawing.Color.White;
                    textBoxEmail.ForeColor = System.Drawing.Color.Black;
                    textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Regular);

                    con.Close();
                    con.Open();
                    querry = @"SELECT * FROM Conturi_elevi WHERE Email = '" + textBoxEmail.Text + "' AND Parola = '" + textBoxParola.Text + "' ";

                    SqlCommand com1 = new SqlCommand(querry, con);
                    reader = com1.ExecuteReader();

                    if (reader.HasRows == true)
                    {
                        Conectare.status = -1;

                        while (reader.Read())
                            Conectare.Clase = reader["Numar_Clasa"].ToString() + " " + reader["Litera_Clasa"].ToString();

                        reader.Close();

                        Conectare.conectat = textBoxEmail.Text;
                        textBoxParola.BackColor = System.Drawing.Color.White;
                        textBoxParola.ForeColor = System.Drawing.Color.Black;

                        this.Hide();
                        ProfilElev f = new ProfilElev();
                        f.Show();
                    }
                    else
                    {
                        textBoxParola.BackColor = System.Drawing.Color.DarkOrange;
                        textBoxParola.ForeColor = System.Drawing.Color.White;
                        textBoxEmail.BackColor = System.Drawing.Color.White;
                        textBoxEmail.ForeColor = System.Drawing.Color.Black;
                        textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Regular);

                        MessageBox.Show("Parolă incorectă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    textBoxEmail.BackColor = System.Drawing.Color.DarkOrange;
                    textBoxEmail.ForeColor = System.Drawing.Color.White;
                    textBoxEmail.Font = new Font(textBoxEmail.Font.FontFamily, textBoxEmail.Font.Size, FontStyle.Bold);

                    MessageBox.Show("Email sau ocupație invalidă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            else
            {
                comboBoxTip.BackColor = System.Drawing.Color.DarkOrange;

                MessageBox.Show("Alegeți o ocupație!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVezi_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                buttonVezi.Image = imageListButoane.Images[1];
                textBoxParola.UseSystemPasswordChar = false;
                i = 1;
            }
            else if (i == 1)
            {
                buttonVezi.Image = imageListButoane.Images[0];
                textBoxParola.UseSystemPasswordChar = true;
                i = 0;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTip.BackColor = System.Drawing.Color.White;
        }

        private void labelParolaUitata_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParolaUitata f1 = new ParolaUitata();
            f1.Show();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f1 = new PaginaPrincipala();
            f1.Show();
        }
    }
}
