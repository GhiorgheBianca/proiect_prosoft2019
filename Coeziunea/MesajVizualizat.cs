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
    public partial class MesajVizualizat : Form
    {
        public MesajVizualizat()
        {
            InitializeComponent();
        }

        private void MesajVizualizat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MesajVizualizat_Load(object sender, EventArgs e)
        {
            bool zero = false;

            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry = @"SELECT * FROM Mesaje WHERE Id = '" + Conectare.Mesaje.ToString() + "' ";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                if (reader["Catre"].ToString() == Conectare.conectat)
                {
                    label1.Text = "De la:";
                    comboBoxEmail.Text = reader["De_la"].ToString();

                    if (reader["Status"].ToString() == "0")
                        zero = true;
                }
                else
                {
                    comboBoxEmail.Text = reader["Catre"].ToString();


                    if (reader["Status"].ToString() == "0")
                    {
                        textBoxSubiect.ReadOnly = false;
                        richTextBoxMesaj.ReadOnly = false;

                        buttonEdit.Visible = true;
                    }
                    else
                    {
                        textBoxSubiect.ReadOnly = true;
                        richTextBoxMesaj.ReadOnly = true;

                        buttonEdit.Visible = false;
                    }
                }

                textBoxSubiect.Text = reader["Titlu"].ToString();
                richTextBoxMesaj.Text = reader["Mesaj"].ToString();
                textBoxData.Text = reader["Data_expedierii"].ToString();
            }

            reader.Close();



            if (textBoxSubiect.ReadOnly == false)
            {
                querry = @"SELECT * FROM Conturi_elevi";
                SqlCommand com1 = new SqlCommand(querry, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                while (reader1.Read())
                {
                    if (Conectare.conectat != reader1["Email"].ToString())
                    {
                        comboBoxEmail.Items.Add(reader1["Email"].ToString());
                    }
                }

                reader1.Close();

                querry = @"SELECT * FROM Conturi_profesori_inspectori";

                SqlCommand com2 = new SqlCommand(querry, con);
                reader1 = com2.ExecuteReader();

                while (reader1.Read())
                {
                    if (Conectare.conectat != reader1["Email"].ToString())
                    {
                        comboBoxEmail.Items.Add(reader1["Email"].ToString());
                    }
                }

                reader1.Close();
            }



            if (label1.Text == "De la:" && zero == true)
            {
                querry = @"UPDATE Mesaje SET Status = @status WHERE Id = '" + Conectare.Mesaje.ToString() + "' ";
                SqlCommand com1 = new SqlCommand(querry, con);

                com1.Parameters.AddWithValue("status", "1");

                com1.ExecuteNonQuery();
            }

            con.Close();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mesaje f = new Mesaje();
            f.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmail.Text != "" && textBoxSubiect.Text != "" && richTextBoxMesaj.Text != "")
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"UPDATE Mesaje SET Mesaj = @msg, Catre = @catre, Titlu = @titlu, Data_expedierii = @data WHERE Id = '" + Conectare.Mesaje.ToString() + "' ";


                SqlCommand com = new SqlCommand(querry, con);

                DateTime dateTime = DateTime.Now;

                com.Parameters.AddWithValue("msg", richTextBoxMesaj.Text);
                com.Parameters.AddWithValue("catre", comboBoxEmail.Text);
                com.Parameters.AddWithValue("titlu", textBoxSubiect.Text);
                com.Parameters.AddWithValue("data", dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + " " + dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString());

                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Mesajul dumneavoastră a fost retrimis.", "Retrimitere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxData.Text = dateTime.ToString();
            }
            else MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
