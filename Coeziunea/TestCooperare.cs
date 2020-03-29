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
    public partial class TestCooperare : Form
    {
        public TestCooperare()
        {
            InitializeComponent();
        }

        bool isActive;

        private void DrawTime()
        {
            labelCsec.Text = String.Format("{00:00}", Conectare.TimeCs);
            labelSec.Text = String.Format("{00:00}", Conectare.TimeSec) + " .";
            labelMin.Text = String.Format("{00:00}", Conectare.TimeMin) + " :";
        }

        private void checkBoxNici_Click(object sender, EventArgs e)
        {
            checkBoxPutin.Checked = false;
            checkBoxDepinde.Checked = false;
            checkBoxMulte.Checked = false;
            checkBoxMereu.Checked = false;
            checkBoxNici.Checked = true;

            progressBarRaspuns.Value = 0;
        }

        private void checkBoxPutin_Click(object sender, EventArgs e)
        {
            checkBoxPutin.Checked = true;
            checkBoxDepinde.Checked = false;
            checkBoxMulte.Checked = false;
            checkBoxMereu.Checked = false;
            checkBoxNici.Checked = false;

            progressBarRaspuns.Value = 25;
        }

        private void checkBoxDepinde_Click(object sender, EventArgs e)
        {
            checkBoxPutin.Checked = false;
            checkBoxDepinde.Checked = true;
            checkBoxMulte.Checked = false;
            checkBoxMereu.Checked = false;
            checkBoxNici.Checked = false;

            progressBarRaspuns.Value = 50;
        }

        private void TestCooperare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxMulte_Click(object sender, EventArgs e)
        {
            checkBoxPutin.Checked = false;
            checkBoxDepinde.Checked = false;
            checkBoxMulte.Checked = true;
            checkBoxMereu.Checked = false;
            checkBoxNici.Checked = false;

            progressBarRaspuns.Value = 75;
        }

        private void checkBoxMereu_Click(object sender, EventArgs e)
        {
            checkBoxPutin.Checked = false;
            checkBoxDepinde.Checked = false;
            checkBoxMulte.Checked = false;
            checkBoxMereu.Checked = true;
            checkBoxNici.Checked = false;

            progressBarRaspuns.Value = 100;
        }

        private void TestCooperare_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();

            string querry = @"SELECT * FROM Intrebari WHERE Id = '" + Conectare.Ordine_Intrebari[Conectare.Numar_Intrebare] + "'";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
                if (reader.HasRows == true)
                {
                    groupBoxIntrebare.Text = reader["Intrebare"].ToString();

                    Conectare.Numar_Intrebare++;
                }

            reader.Close();
            con.Close();

            if (Conectare.Numar_Intrebare == Conectare.Total + 1)
                buttonUrmat.Text = "Termină testul";

            timerCronom.Enabled = true;
            isActive = true;
        }

        private void buttonUrmat_Click(object sender, EventArgs e)
        {
            if (checkBoxNici.Checked == true)
                Conectare.Rezultat = Conectare.Rezultat - 1;
            else if (checkBoxPutin.Checked == true)
                Conectare.Rezultat = Conectare.Rezultat - 0.5;
            else if (checkBoxMulte.Checked == true)
                Conectare.Rezultat = Conectare.Rezultat + 0.5;
            else if (checkBoxMereu.Checked == true)
                Conectare.Rezultat = Conectare.Rezultat + 1;


            if ((checkBoxDepinde.Checked == true || checkBoxMereu.Checked == true || checkBoxMulte.Checked == true || checkBoxNici.Checked == true || checkBoxPutin.Checked == true) && Conectare.Numar_Intrebare <= Conectare.Total)
            {
                this.Hide();
                TestCooperare f = new TestCooperare();
                f.Show();
            }
            else if (Conectare.Numar_Intrebare > Conectare.Total)
            {
                timerCronom.Enabled = false;

                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                string querry = @"UPDATE Conturi_elevi SET Alegeri = @aleg WHERE Email = '" + Conectare.conectat + "' ";

                SqlCommand com = new SqlCommand(querry, con);
                com.Parameters.AddWithValue("aleg", (Conectare.Rezultat/Conectare.Total).ToString());

                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Felicitări! Ați terminat testul de cooperare.", "Test terminat", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.Hide();
                ProfilElev f = new ProfilElev();
                f.Show();
            }
        }

        private void timerCronom_Tick(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                Conectare.TimeCs++;

                if (Conectare.TimeCs >= 100)
                {
                    Conectare.TimeSec++;
                    Conectare.TimeCs = 0;

                    if (Conectare.TimeSec >= 60)
                    {
                        Conectare.TimeMin++;
                        Conectare.TimeSec = 0;
                    }
                }
            }
   
            DrawTime();
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
