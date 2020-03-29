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
    public partial class TestSociometric : Form
    {
        public TestSociometric()
        {
            InitializeComponent();
        }

        private void TestSociometric_Load(object sender, EventArgs e)
        {
            string[] numar_litera = new string[5];
            numar_litera = Conectare.Clase.Split(' ').Select(text => text.ToString()).ToArray();

            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(numar_litera[0]) + "' AND Litera_Clasa = '" + numar_litera[1] + "' ";


            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                if (Conectare.conectat != reader["Email"].ToString())
                {
                    comboBoxAlegPoz1.Items.Add(reader["Nume"].ToString() + " " + reader["Prenume"].ToString());
                    comboBoxAlegPoz2.Items.Add(reader["Nume"].ToString() + " " + reader["Prenume"].ToString());
                    comboBoxAlegResp1.Items.Add(reader["Nume"].ToString() + " " + reader["Prenume"].ToString());
                    comboBoxAlegResp2.Items.Add(reader["Nume"].ToString() + " " + reader["Prenume"].ToString());
                }
            }

            reader.Close();
            con.Close();
        }

        private void TestSociometric_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGata_Click(object sender, EventArgs e)
        {
            if (comboBoxAlegPoz1.Text == "" || comboBoxAlegPoz2.Text == "" || comboBoxAlegResp1.Text == "" || comboBoxAlegResp2.Text == "")
            {
                MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxAlegPoz1.Text == comboBoxAlegPoz2.Text || comboBoxAlegPoz1.Text == comboBoxAlegResp1.Text || comboBoxAlegPoz1.Text == comboBoxAlegResp2.Text || comboBoxAlegPoz2.Text == comboBoxAlegResp1.Text || comboBoxAlegPoz2.Text == comboBoxAlegResp2.Text || comboBoxAlegResp1.Text == comboBoxAlegResp2.Text)
            {
                MessageBox.Show("Nu puteți răspunde cu același elev mai mult de o dată.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int[] vect_alegeri = new int[5];

                string[] numar_litera = new string[5];
                numar_litera = Conectare.Clase.Split(' ').Select(text => text.ToString()).ToArray();

                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(numar_litera[0]) + "' AND Litera_Clasa = '" + numar_litera[1] + "' ";


                SqlCommand com = new SqlCommand(querry, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    if (reader["Nume"].ToString() + " " + reader["Prenume"].ToString() == comboBoxAlegPoz1.Text)
                    {
                        vect_alegeri[0] = Int32.Parse(reader["Id"].ToString());
                    }
                    else if (reader["Nume"].ToString() + " " + reader["Prenume"].ToString() == comboBoxAlegPoz2.Text)
                    {
                        vect_alegeri[1] = Int32.Parse(reader["Id"].ToString());
                    }
                    else if (reader["Nume"].ToString() + " " + reader["Prenume"].ToString() == comboBoxAlegResp1.Text)
                    {
                        vect_alegeri[2] = Int32.Parse(reader["Id"].ToString());
                    }
                    else if (reader["Nume"].ToString() + " " + reader["Prenume"].ToString() == comboBoxAlegResp2.Text)
                    {
                        vect_alegeri[3] = Int32.Parse(reader["Id"].ToString());
                    }
                }

                reader.Close();
                con.Close();

                con.Open();
                string querry1 = @"UPDATE Conturi_elevi SET Raspunsuri = @rasp WHERE Email = '" + Conectare.conectat + "' ";

                SqlCommand com1 = new SqlCommand(querry1, con);
                com1.Parameters.AddWithValue("rasp", vect_alegeri[0].ToString() + " " + vect_alegeri[1].ToString() + " " + vect_alegeri[2].ToString() + " " +vect_alegeri[3].ToString());

                com1.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Felicitări! Ați terminat testul sociometric.", "Test terminat", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Hide();
                ProfilElev f = new ProfilElev();
                f.Show();
            }
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur că vrei să întrerupi testul?", "Ieșire din test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ProfilElev f = new ProfilElev();
                f.Show();
            }
        }
    }
}
