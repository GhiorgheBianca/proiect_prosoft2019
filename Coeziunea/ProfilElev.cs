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
    public partial class ProfilElev : Form
    {
        public ProfilElev()
        {
            InitializeComponent();
        }

        int id, gen;
        bool jocXsi0 = false;

        private void ProfilElev_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTestCoop_Click(object sender, EventArgs e)
        {
            Conectare.TimeCs = 0;
            Conectare.TimeSec = 0;
            Conectare.TimeMin = 0;

            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();

            string querry = @"SELECT COUNT(*) FROM Intrebari";
            SqlCommand com = new SqlCommand(querry, con);
            int row_nr = Int32.Parse(com.ExecuteScalar().ToString());
            con.Close();


            int i;
            int[] ordine = new int[100];


            for (i = 1; i <= row_nr; i++)
                ordine[i] = 0;


            Random rnd = new Random();
            int nr;

            i = 1;
            while (i <= row_nr)
            {
                bool accept = true;
                nr = rnd.Next(1, row_nr + 1);
                ordine[i] = nr;


                for (int k = 1; k < row_nr; k++)
                    for (int j = k + 1; j <= row_nr; j++)
                        if (ordine[k] == ordine[j] && ordine[k] != 0)
                            accept = false;
                            
                i++;
                if (accept == false)
                {
                    ordine[i] = 0;
                    i--;
                }
            }
            

            Conectare.Ordine_Intrebari = ordine;
            Conectare.Numar_Intrebare = 1;
            Conectare.Rezultat = 0;
            Conectare.Total = row_nr;


            this.Hide();
            TestCooperare f = new TestCooperare();
            f.Show();
        }

        private void ProfilElev_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);

            con.Open();
            string querry = @"SELECT * FROM Conturi_elevi";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();

            textBoxEmail.Text = Conectare.conectat;
            while (reader.Read())
            {
                string email = reader["Email"].ToString();
                if (email == Conectare.conectat)
                {
                    textBoxNumPren.Text = reader["Nume"].ToString() + " " + reader["Prenume"].ToString();
                    textBoxClasa.Text = reader["Numar_Clasa"].ToString() + " " + reader["Litera_Clasa"].ToString();
                    textBoxProf.Text = reader["Profesor"].ToString();
                    textBoxScoala.Text = reader["Scoala"].ToString();

                    pictureBoxPoza.Image = imageListPoza.Images[Int32.Parse(reader["Gen"].ToString())];
                    gen = Int32.Parse(reader["Gen"].ToString());
                    id = Int32.Parse(reader["Id"].ToString());
                    textBoxParola.Text = reader["Parola"].ToString();
                    Conectare.Parola = reader["Parola"].ToString();

                    if (reader["Alegeri"].ToString() != "")
                        pictureBoxTestCoop.Image = imageListBifaX.Images[0];
                    else pictureBoxTestCoop.Image = imageListBifaX.Images[1];

                    if (reader["Raspunsuri"].ToString() != "")
                        pictureBoxTestSocio.Image = imageListBifaX.Images[0];
                    else pictureBoxTestSocio.Image = imageListBifaX.Images[1];

                    if (reader["Alegeri"].ToString() != "" && reader["Raspunsuri"].ToString() != "")
                    {
                        buttonXsi0.Enabled = true;
                        jocXsi0 = true;
                    }
                    else
                    {
                        buttonXsi0.Enabled = false;
                        jocXsi0 = false;
                    }
                }
            }

            reader.Close();
            con.Close();



            int meciuri = 0, castigate = 0, pierdute = 0, last_month = 0;
            string[] player = new string[100];

            con.Open();
            querry = @"SELECT * FROM JocXsi0";
            SqlCommand com1 = new SqlCommand(querry, con);
            SqlDataReader reader1 = com1.ExecuteReader();

            while (reader1.Read())
            {
                if (reader1["Email_X"].ToString() == Conectare.conectat || reader1["Email_0"].ToString() == Conectare.conectat)
                {
                    DateTime dateTime = DateTime.Now;
                    DateTime date = Convert.ToDateTime(reader1["Date"]);
                    meciuri++;
                    if (reader1["Email_X"].ToString() == Conectare.conectat)
                    {
                        if (Int32.Parse(reader1["Win_X"].ToString()) == 1)
                            castigate = castigate + Int32.Parse(reader1["Win_X"].ToString());
                        else if (Int32.Parse(reader1["Win_X"].ToString()) == 0 && Int32.Parse(reader1["Win_0"].ToString()) == 1)
                            pierdute = pierdute + Int32.Parse(reader1["Win_0"].ToString());


                        if ((dateTime.Month - date.Month == 1 && date.Day >= dateTime.Day && dateTime.Year - date.Year < 1) || (dateTime.Month - date.Month == 0 && dateTime.Year - date.Year < 1))
                        {
                            last_month++;

                            if (Int32.Parse(reader1["Win_X"].ToString()) == 1)
                                chart1.Series["Meciuri"].Points.AddXY("", 1);
                            else if (Int32.Parse(reader1["Win_X"].ToString()) == 0 && Int32.Parse(reader1["Win_0"].ToString()) == 0)
                                chart1.Series["Meciuri"].Points.AddXY("", 0);
                            else if (Int32.Parse(reader1["Win_X"].ToString()) == 0 && Int32.Parse(reader1["Win_0"].ToString()) == 1)
                                chart1.Series["Meciuri"].Points.AddXY("", -1);
                        }

                        player = reader1["Email_0"].ToString().Split('@').Select(text => text.ToString()).ToArray();
                    }
                    else if (reader1["Email_0"].ToString() == Conectare.conectat)
                    {
                        if (Int32.Parse(reader1["Win_0"].ToString()) == 1)
                            castigate = castigate + Int32.Parse(reader1["Win_0"].ToString());
                        else if (Int32.Parse(reader1["Win_0"].ToString()) == 0 && Int32.Parse(reader1["Win_X"].ToString()) == 1)
                            pierdute = pierdute + Int32.Parse(reader1["Win_X"].ToString());


                        if ((dateTime.Month - date.Month == 1 && date.Day >= dateTime.Day && dateTime.Year - date.Year < 1) || (dateTime.Month - date.Month == 0 && dateTime.Year - date.Year < 1))
                        {
                            last_month++;

                            if (Int32.Parse(reader1["Win_0"].ToString()) == 1)
                                chart1.Series["Meciuri"].Points.AddXY("", 1);
                            else if (Int32.Parse(reader1["Win_X"].ToString()) == 0 && Int32.Parse(reader1["Win_0"].ToString()) == 0)
                                chart1.Series["Meciuri"].Points.AddXY("", 0);
                            else if (Int32.Parse(reader1["Win_0"].ToString()) == 0 && Int32.Parse(reader1["Win_X"].ToString()) == 1)
                                chart1.Series["Meciuri"].Points.AddXY("", -1);
                        }

                        player = reader1["Email_X"].ToString().Split('@').Select(text => text.ToString()).ToArray();
                    }
                }
            }

            chart2.Series["Meciuri"].Points.AddXY("Câștigate", castigate);
            chart2.Series["Meciuri"].Points.AddXY("Pierdute", pierdute);
            chart2.Series["Meciuri"].Points.AddXY("Remiză", meciuri - castigate - pierdute);


            label8.Text = label8.Text + meciuri.ToString();
            label9.Text = label9.Text + player[0];


            if (meciuri == 0)
            {
                chart1.Visible = false;
                chart2.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;

                label5.Text = "Nu ați jucat X și 0 încă.";
                label5.Location = new Point(252, 75);
                
                label5.Font = new Font("Times New Roman", 32, FontStyle.Italic);
                label5.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
                label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            else if (last_month == 0)
            {
                chart1.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                panel1.Visible = false;

                label5.Text = "Nu ați jucat acest joc de mai mult de o lună.";
                label5.Location = new Point(45, 82);
   
                label5.Font = new Font("Times New Roman", 18, FontStyle.Italic);
                label5.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
                label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }

            reader1.Close();
            con.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Editează parola")
            {
                buttonTestCoop.Enabled = false;
                buttonTestSocio.Enabled = false;
                buttonDeconect.Enabled = false;
                buttonInapoi.Enabled = false;
                buttonXsi0.Enabled = false;

                buttonEdit.Text = "Gata";
            }
            else if (buttonEdit.Text == "Gata")
            {
                buttonTestCoop.Enabled = true;
                buttonTestSocio.Enabled = true;
                buttonDeconect.Enabled = true;
                buttonInapoi.Enabled = true;
                if (jocXsi0 == true)
                    buttonXsi0.Enabled = true;

                if (textBoxParola.Text != "" && textBoxParola.ReadOnly == false)
                {
                    textBoxParola.BackColor = System.Drawing.Color.White;
                    textBoxParola.ForeColor = System.Drawing.Color.Black;

                    SqlConnection con = new SqlConnection(Conectare.variabila);

                    con.Open();
                    string querry = @"UPDATE Conturi_elevi SET Parola = @parola WHERE Id = '" + id + "' ";

                    SqlCommand com = new SqlCommand(querry, con);
                    com.Parameters.AddWithValue("parola", textBoxParola.Text);

                    com.ExecuteNonQuery();
                    con.Close();

                    Conectare.Parola = textBoxParola.Text;
                }
                else if (textBoxParola.ReadOnly == false && textBoxParola.Text == "")
                {
                    textBoxParola.BackColor = System.Drawing.Color.Firebrick;
                    textBoxParola.ForeColor = System.Drawing.Color.White;

                    MessageBox.Show("Spațiu corespunzător câmpului pe care doriți să îl actualizați este necompletat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                buttonEdit.Text = "Editează parola";

                textBoxParola.UseSystemPasswordChar = true;
                textBoxParola.ReadOnly = true;
                i = 0;
                buttonViz.Image = imageListOchi.Images[0];
                buttonViz.Visible = false;
                Conectare.VerifPar = false;
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

        int i = 0;

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

        private void buttonTestSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestSociometric f = new TestSociometric();
            f.Show();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f = new PaginaPrincipala();
            f.Show();
        }

        private void buttonXsi0_Click(object sender, EventArgs e)
        {
            this.Hide();
            JocXsi0 f = new JocXsi0();
            f.Show();
        }

        private void buttonDeconect_Click(object sender, EventArgs e)
        {
            if (gen == 0)
            {
                if (MessageBox.Show("Ești sigură că vrei să te deconectezi?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    Conectare.conectat = "";

                    this.Hide();
                    Login f = new Login();
                    f.Show();
                }
            }
            else if (gen == 1)
            {
                if (MessageBox.Show("Ești sigur că vrei să te deconectezi?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    Conectare.conectat = "";

                    this.Hide();
                    Login f = new Login();
                    f.Show();
                }
            }
        }
    }
}
