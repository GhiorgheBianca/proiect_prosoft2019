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
    public partial class ParolaUitata : Form
    {
        public ParolaUitata()
        {
            InitializeComponent();
        }

        int greseli = 0;

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f25 = new Login();
            f25.Show();
        }

        private void buttonVerif_Click(object sender, EventArgs e)
        {
            bool gasit = false;

            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry = @"SELECT * FROM Conturi_elevi WHERE Email = '" + textBoxEmail.Text + "' ";
            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
                if (reader.HasRows == true)
                {
                    gasit = true;

                    textBoxSecur.Visible = true;
                    textBoxRaspuns.Visible = true;
                    labelSecur.Visible = true;
                    labelRaspuns.Visible = true;

                    if (textBoxRaspuns.Text == reader["Cod"].ToString())
                    {
                        textBoxParola.Text = reader["Parola"].ToString();
                    }
                    else if (textBoxRaspuns.Text != reader["Cod"].ToString() && textBoxRaspuns.Text != "" && greseli < 2)
                    {
                        greseli++;

                        MessageBox.Show("Răspuns incorect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (greseli >= 2)
                    {
                        MessageBox.Show("Răspuns incorect! Ați greșit de prea multe ori.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.Hide();
                        Login f32 = new Login();
                        f32.Show();
                    }
                }
            if (gasit == false)
            {
                MessageBox.Show("Email invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParolaUitata_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nr = rnd.Next(1000, 10000);


            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();

            string querry = @"UPDATE Conturi_elevi SET Cod = @cod WHERE Email = '" + textBoxEmail.Text + "' ";
            SqlCommand com = new SqlCommand(querry, con);


            com.Parameters.AddWithValue("cod", nr.ToString());

            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
