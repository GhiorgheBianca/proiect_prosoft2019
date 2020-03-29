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
    public partial class ProfilProfesor_Inspector : Form
    {
        public ProfilProfesor_Inspector()
        {
            InitializeComponent();
        }

        private void ProfilProfesor_Inspector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int id;

        private void ProfilProfesor_Inspector_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);

            con.Open();
            string querry = @"SELECT * FROM Conturi_profesori_inspectori";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();

            textBoxEmail.Text = Conectare.conectat;
            while (reader.Read())
            {
                string email = reader["Email"].ToString();
                if (email == Conectare.conectat)
                {
                    textBoxNume.Text = reader["Nume"].ToString();
                    textBoxPrenume.Text = reader["Prenume"].ToString();
                    textBoxClasa.Text = reader["Clase"].ToString();
                    textBoxScoala.Text = reader["Scoala"].ToString();

                    id = Int32.Parse(reader["Id"].ToString());
                    textBoxParola.Text = reader["Parola"].ToString();
                    Conectare.Parola = reader["Parola"].ToString();
                }
            }

            reader.Close();
            con.Close();
        }

        private void buttonSterg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să îți ștergi contul?", "Șterge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    SqlConnection con = new SqlConnection(Conectare.variabila);

                    con.Open();
                    string querry = @"DELETE FROM Conturi_profesori_inspectori WHERE Id = '" + id + "' ";

                    SqlCommand com = new SqlCommand(querry, con);

                    com.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                    Login f = new Login();
                    f.Show();
            }
        }

        private void buttonDeconect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să te deconectezi?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    Conectare.conectat = "";

                    this.Hide();
                    Login f = new Login();
                    f.Show();
            }
        }

        int i = 0;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Editare")
            {
                textBoxNume.ReadOnly = false;
                textBoxPrenume.ReadOnly = false;
                textBoxEmail.ReadOnly = false;
                textBoxScoala.ReadOnly = false;
                textBoxClasa.ReadOnly = false;

                buttonDeconect.Enabled = false;
                buttonSterg.Enabled = false;
                buttonInapoi.Enabled = false;
                buttonAdmin.Enabled = false;

                buttonEdit.Text = "Gata";
            }
            else if (buttonEdit.Text == "Gata")
            {
                if (textBoxNume.Text != "" && textBoxPrenume.Text != "" && textBoxParola.Text != "" && textBoxEmail.Text != "")
                {
                    textBoxNume.BackColor = System.Drawing.Color.White;
                    textBoxNume.ForeColor = System.Drawing.Color.Black;
                    textBoxPrenume.BackColor = System.Drawing.Color.White;
                    textBoxPrenume.ForeColor = System.Drawing.Color.Black;
                    textBoxEmail.BackColor = System.Drawing.Color.White;
                    textBoxEmail.ForeColor = System.Drawing.Color.Black;
                    textBoxParola.BackColor = System.Drawing.Color.White;
                    textBoxParola.ForeColor = System.Drawing.Color.Black;


                    SqlConnection con = new SqlConnection(Conectare.variabila);

                    con.Open();
                    string querry;
                    if (textBoxScoala.Text == "" && textBoxClasa.Text != "")
                        querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Clase = @clase WHERE Id = '" + id + "' ";
                    else if (textBoxClasa.Text == "" && textBoxScoala.Text != "")
                        querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Scoala = @sco WHERE Id = '" + id + "' ";
                    else if (textBoxClasa.Text == "" && textBoxScoala.Text == "")
                        querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email WHERE Id = '" + id + "' ";
                    else
                        querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Scoala = @sco, Clase = @clase WHERE Id = '" + id + "' ";

                    SqlCommand com = new SqlCommand(querry, con);
                    com.Parameters.AddWithValue("name", textBoxNume.Text);
                    com.Parameters.AddWithValue("prename", textBoxPrenume.Text);
                    com.Parameters.AddWithValue("email", textBoxEmail.Text);
                    com.Parameters.AddWithValue("password", textBoxParola.Text);

                    if (textBoxScoala.Text != "")
                        com.Parameters.AddWithValue("sco", textBoxScoala.Text);

                    if (textBoxClasa.Text != "")
                        com.Parameters.AddWithValue("clase", textBoxClasa.Text);

                    com.ExecuteNonQuery();
                    con.Close();


                    buttonDeconect.Enabled = true;
                    buttonSterg.Enabled = true;
                    buttonInapoi.Enabled = true;
                    buttonAdmin.Enabled = true;

                    textBoxNume.ReadOnly = true;
                    textBoxPrenume.ReadOnly = true;
                    textBoxEmail.ReadOnly = true;
                    textBoxScoala.ReadOnly = true;
                    textBoxClasa.ReadOnly = true;
                    textBoxParola.ReadOnly = true;

                    buttonViz.Visible = false;

                    Conectare.VerifPar = false;
                    Conectare.Parola = textBoxParola.Text;
                    Conectare.conectat = textBoxEmail.Text;

                    textBoxParola.UseSystemPasswordChar = true;
                    i = 0;
                    buttonViz.Image = imageListOchi.Images[0];
                    

                    buttonEdit.Text = "Editare";
                }
                else
                {
                    if (textBoxNume.Text == "")
                    {
                        textBoxNume.BackColor = System.Drawing.Color.Firebrick;
                        textBoxNume.ForeColor = System.Drawing.Color.White;
                    }
                    else if (textBoxNume.Text != "")
                    {
                        textBoxNume.BackColor = System.Drawing.Color.White;
                        textBoxNume.ForeColor = System.Drawing.Color.Black;
                    }

                    if (textBoxPrenume.Text == "")
                    {
                        textBoxPrenume.BackColor = System.Drawing.Color.Firebrick;
                        textBoxPrenume.ForeColor = System.Drawing.Color.White;
                    }
                    else if (textBoxPrenume.Text != "")
                    {
                        textBoxPrenume.BackColor = System.Drawing.Color.White;
                        textBoxPrenume.ForeColor = System.Drawing.Color.Black;
                    }

                    if (textBoxEmail.Text == "")
                    {
                        textBoxEmail.BackColor = System.Drawing.Color.Firebrick;
                        textBoxEmail.ForeColor = System.Drawing.Color.White;
                    }
                    else if (textBoxEmail.Text != "")
                    {
                        textBoxEmail.BackColor = System.Drawing.Color.White;
                        textBoxEmail.ForeColor = System.Drawing.Color.Black;
                    }

                    if (textBoxParola.Text == "")
                    {
                        textBoxParola.BackColor = System.Drawing.Color.Firebrick;
                        textBoxParola.ForeColor = System.Drawing.Color.White;
                    }
                    else if (textBoxParola.Text != "")
                    {
                        textBoxParola.BackColor = System.Drawing.Color.White;
                        textBoxParola.ForeColor = System.Drawing.Color.Black;
                    }


                    MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonViz_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                buttonViz.Image = imageListOchi.Images[1];
                textBoxParola.UseSystemPasswordChar = false;
                i = 1;
            }
            else if (i == 1)
            {
                buttonViz.Image = imageListOchi.Images[0];
                textBoxParola.UseSystemPasswordChar = true;
                i = 0;
            }
        }

        private void textBoxParola_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Gata")
            {
                if (Conectare.VerifPar == false)
                {
                    SchimbParola f = new SchimbParola();
                    f.Show();
                }
                else if (Conectare.VerifPar == true)
                {
                    textBoxParola.ReadOnly = false;
                    buttonViz.Visible = true;
                }
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditTabele f = new EditTabele();
            f.Show();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f = new PaginaPrincipala();
            f.Show();
        }
    }
}
