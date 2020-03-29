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
    public partial class CreareMesaj : Form
    {
        public CreareMesaj()
        {
            InitializeComponent();
        }

        private void CreareMesaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreareMesaj_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry = @"SELECT * FROM Conturi_elevi";


            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                if (Conectare.conectat != reader["Email"].ToString())
                {
                    comboBoxEmail.Items.Add(reader["Email"].ToString());
                }
            }

            reader.Close();
            con.Close();


            con.Open();

            querry = @"SELECT * FROM Conturi_profesori_inspectori";

            SqlCommand com1 = new SqlCommand(querry, con);
            reader = com1.ExecuteReader();

            while (reader.Read())
            {
                if (Conectare.conectat != reader["Email"].ToString())
                {
                    comboBoxEmail.Items.Add(reader["Email"].ToString());
                }
            }

            reader.Close();
            con.Close();
        }

        private void buttonTrimite_Click(object sender, EventArgs e)
        {
            if (comboBoxEmail.Text != "" && textBoxSubiect.Text != "" && richTextBoxMesaj.Text != "")
            {
                DateTime dateTime = DateTime.Now;

                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"INSERT INTO Mesaje (Mesaj, De_la, Catre, Titlu, Status, Data_Expedierii) VALUES ('" + richTextBoxMesaj.Text + "' , '" + Conectare.conectat + "' , '" + comboBoxEmail.Text + "' , '" + textBoxSubiect.Text + "' , '" + 0 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Mesajul dumneavoastră a fost trimis.", "Expediat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBoxEmail.Text = "";
                textBoxSubiect.Text = "";
                richTextBoxMesaj.Text = "";
            }
            else MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mesaje f = new Mesaje();
            f.Show();
        }
    }
}
