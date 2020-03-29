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
    public partial class Mesaje : Form
    {
        public Mesaje()
        {
            InitializeComponent();
        }

        private void Mesaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Mesaje_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry = @"SELECT * FROM Mesaje WHERE Catre = '" + Conectare.conectat + "' OR De_la = '" + Conectare.conectat + "' ";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                /*
                
                1 - mesaj văzut
                0 - mesaj nevăzut
                -1 - mesaj șters de cel care l-a primit
                -2 - mesaj șters de cel care l-a trimis
                -3 - mesaj șters de amândoi
                -4 - mesaj șters definitiv de cel care l-a primit
                -5 - mesaj șters definitiv de cel care l-a trimis
                -6 - mesaj șters definitiv de amândoi

                */

                if (reader["Catre"].ToString() == Conectare.conectat)
                {
                    if (reader["Status"].ToString() == "-5" || reader["Status"].ToString() == "-2" || reader["Status"].ToString() == "0" || reader["Status"].ToString() == "1")
                    {
                        checkedListBoxMesPrimite.Items.Add(reader["Id"].ToString() + ")   " + reader["Titlu"].ToString() + "                            De la: " + reader["De_la"].ToString());
                    }
                    else if (reader["Status"].ToString() == "-1" || reader["Status"].ToString() == "-3")
                    {
                        checkedListBoxMesSterse.Items.Add(reader["Id"].ToString() + ")   " + reader["Titlu"].ToString() + "                            De la: " + reader["De_la"].ToString());
                    }
                }
                else if (reader["De_la"].ToString() == Conectare.conectat)
                {
                    if (reader["Status"].ToString() == "-4" || reader["Status"].ToString() == "-1" || reader["Status"].ToString() == "0" || reader["Status"].ToString() == "1")
                    {
                        checkedListBoxMesTrimise.Items.Add(reader["Id"].ToString() + ")   " + reader["Titlu"].ToString() + "                            Către: " + reader["Catre"].ToString());
                    }
                    else if (reader["Status"].ToString() == "-2" || reader["Status"].ToString() == "-3")
                    {
                        checkedListBoxMesSterse.Items.Add(reader["Id"].ToString() + ")   " + reader["Titlu"].ToString() + "                            Către: " + reader["De_la"].ToString());
                    }
                }
            }

            reader.Close();
            con.Close();
        }

        string[] id = new string[100];

        private void buttonSterg_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesPrimite.SelectedIndex > -1)
            {
                int i = 0;
                while (i < checkedListBoxMesPrimite.Items.Count)
                {
                    if (checkedListBoxMesPrimite.GetItemChecked(i))
                    {
                        id = checkedListBoxMesPrimite.Items[i].ToString().Split(')').Select(text => text.ToString()).ToArray();

                        string status = "";

                        SqlConnection con = new SqlConnection(Conectare.variabila);
                        con.Open();

                        string querry = @"SELECT * FROM Mesaje WHERE Id = '" + id[0].ToString() + "' ";

                        SqlCommand com = new SqlCommand(querry, con);
                        SqlDataReader reader = com.ExecuteReader();


                        while (reader.Read())
                        {
                            status = reader["Status"].ToString();
                        }

                        reader.Close();
                        con.Close();



                        con.Open();

                        querry = @"UPDATE Mesaje SET Status = @status WHERE Id = '" + id[0].ToString() + "' ";


                        SqlCommand com1 = new SqlCommand(querry, con);


                        if (status == "0" || status == "1")
                            com1.Parameters.AddWithValue("status", "-1");
                        else if (status == "-2")
                            com1.Parameters.AddWithValue("status", "-3");

                        com1.ExecuteNonQuery();
                        con.Close();

                        checkedListBoxMesSterse.Items.Add(checkedListBoxMesPrimite.Items[i].ToString());
                        checkedListBoxMesPrimite.Items.Remove(checkedListBoxMesPrimite.Items[i].ToString());
                    }
                    else i++;
                }
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxOptiuni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOptiuni.SelectedIndex == 0)
            {
                for (int i = 0; i < checkedListBoxMesPrimite.Items.Count; i++)
                    checkedListBoxMesPrimite.SetItemChecked(i, true);
            }
            else if (comboBoxOptiuni.SelectedIndex == 1)
            {
                for (int i = 0; i < checkedListBoxMesPrimite.Items.Count; i++)
                    checkedListBoxMesPrimite.SetItemChecked(i, false);
            }
        }

        private void buttonViz_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesPrimite.SelectedIndex > -1)
            {
                id = checkedListBoxMesPrimite.Items[checkedListBoxMesPrimite.SelectedIndex].ToString().Split(')').Select(text => text.ToString()).ToArray();
                Conectare.Mesaje = Int32.Parse(id[0]);

                this.Hide();
                MesajVizualizat f = new MesajVizualizat();
                f.Show();
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f = new PaginaPrincipala();
            f.Show();
        }

        private void buttonScrie_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreareMesaj f = new CreareMesaj();
            f.Show();
        }

        private void buttonVadTrim_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesTrimise.SelectedIndex > -1)
            {
                id = checkedListBoxMesTrimise.Items[checkedListBoxMesTrimise.SelectedIndex].ToString().Split(')').Select(text => text.ToString()).ToArray();
                Conectare.Mesaje = Int32.Parse(id[0]);

                this.Hide();
                MesajVizualizat f = new MesajVizualizat();
                f.Show();
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxOptiuniTrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOptiuniTrim.SelectedIndex == 0)
            {
                for (int i = 0; i < checkedListBoxMesTrimise.Items.Count; i++)
                    checkedListBoxMesTrimise.SetItemChecked(i, true);
            }
            else if (comboBoxOptiuniTrim.SelectedIndex == 1)
            {
                for (int i = 0; i < checkedListBoxMesTrimise.Items.Count; i++)
                    checkedListBoxMesTrimise.SetItemChecked(i, false);
            }
        }

        private void buttonStergTrim_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesTrimise.SelectedIndex > -1)
            {
                int i = 0;
                while (i < checkedListBoxMesTrimise.Items.Count)
                {
                    if (checkedListBoxMesTrimise.GetItemChecked(i))
                    {
                        id = checkedListBoxMesTrimise.Items[i].ToString().Split(')').Select(text => text.ToString()).ToArray();

                        string status = "";

                        SqlConnection con = new SqlConnection(Conectare.variabila);
                        con.Open();

                        string querry = @"SELECT * FROM Mesaje WHERE Id = '" + id[0].ToString() + "' ";

                        SqlCommand com = new SqlCommand(querry, con);
                        SqlDataReader reader = com.ExecuteReader();


                        while (reader.Read())
                        {
                            status = reader["Status"].ToString();
                        }

                        reader.Close();
                        con.Close();



                        con.Open();

                        querry = @"UPDATE Mesaje SET Status = @status WHERE Id = '" + id[0].ToString() + "' ";


                        SqlCommand com1 = new SqlCommand(querry, con);


                        if (status == "0" || status == "1")
                            com1.Parameters.AddWithValue("status", "-2");
                        else if (status == "-1")
                            com1.Parameters.AddWithValue("status", "-3");

                        com1.ExecuteNonQuery();
                        con.Close();

                        checkedListBoxMesSterse.Items.Add(checkedListBoxMesTrimise.Items[i].ToString());
                        checkedListBoxMesTrimise.Items.Remove(checkedListBoxMesTrimise.Items[i].ToString());
                    }
                    else i++;
                }
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxOptiuniSterg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOptiuniSterg.SelectedIndex == 0)
            {
                for (int i = 0; i < checkedListBoxMesSterse.Items.Count; i++)
                    checkedListBoxMesSterse.SetItemChecked(i, true);
            }
            else if (comboBoxOptiuniSterg.SelectedIndex == 1)
            {
                for (int i = 0; i < checkedListBoxMesSterse.Items.Count; i++)
                    checkedListBoxMesSterse.SetItemChecked(i, false);
            }
        }

        private void buttonStergDef_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesSterse.SelectedIndex > -1)
            {
                int i = 0;
                while (i < checkedListBoxMesSterse.Items.Count)
                {
                    if (checkedListBoxMesSterse.GetItemChecked(i))
                    {
                        id = checkedListBoxMesSterse.Items[i].ToString().Split(')').Select(text => text.ToString()).ToArray();

                        checkedListBoxMesSterse.Items.Remove(checkedListBoxMesSterse.Items[i].ToString());


                        string status = "";

                        SqlConnection con = new SqlConnection(Conectare.variabila);
                        con.Open();

                        string querry = @"SELECT * FROM Mesaje WHERE Id = '" + id[0].ToString() + "' ";

                        SqlCommand com = new SqlCommand(querry, con);
                        SqlDataReader reader = com.ExecuteReader();


                        while (reader.Read())
                        {
                            status = reader["Status"].ToString();
                        }

                        reader.Close();
                        con.Close();



                        con.Open();

                        querry = @"UPDATE Mesaje SET Status = @status WHERE Id = '" + id[0].ToString() + "' ";


                        SqlCommand com1 = new SqlCommand(querry, con);


                        if (status == "-1" || status == "-3")
                            com1.Parameters.AddWithValue("status", "-4");
                        else if (status == "-2" || status == "-3")
                            com1.Parameters.AddWithValue("status", "-5");
                        else if (status == "-4" || status == "-5")
                            com1.Parameters.AddWithValue("status", "-6");

                        com1.ExecuteNonQuery();
                        con.Close();
                    }
                    else i++;
                }
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMesSterse.SelectedIndex > -1)
            {
                int i = 0;
                while (i < checkedListBoxMesSterse.Items.Count)
                {
                    if (checkedListBoxMesSterse.GetItemChecked(i))
                    {
                        id = checkedListBoxMesSterse.Items[i].ToString().Split(')').Select(text => text.ToString()).ToArray();


                        string status = "";

                        SqlConnection con = new SqlConnection(Conectare.variabila);
                        con.Open();

                        string querry = @"SELECT * FROM Mesaje WHERE Id = '" + id[0].ToString() + "' ";

                        SqlCommand com = new SqlCommand(querry, con);
                        SqlDataReader reader = com.ExecuteReader();

                        bool primitor = false;
                        while (reader.Read())
                        {
                            status = reader["Status"].ToString();

                            if (reader["De_la"].ToString() == Conectare.conectat)
                                primitor = false;
                            else if (reader["Catre"].ToString() == Conectare.conectat)
                                primitor = true;
                        }

                        reader.Close();
                        con.Close();



                        con.Open();

                        querry = @"UPDATE Mesaje SET Status = @status WHERE Id = '" + id[0].ToString() + "' ";


                        SqlCommand com1 = new SqlCommand(querry, con);


                        if (primitor == true)
                        {
                            if (status == "-1")
                                com1.Parameters.AddWithValue("status", "1");
                            else if (status == "-3")
                                com1.Parameters.AddWithValue("status", "-2");

                            checkedListBoxMesPrimite.Items.Add(checkedListBoxMesSterse.Items[i].ToString());
                        }
                        else if (primitor == false)
                        {
                            if (status == "-2")
                                com1.Parameters.AddWithValue("status", "1");
                            else if (status == "-3")
                                com1.Parameters.AddWithValue("status", "-1");

                            checkedListBoxMesTrimise.Items.Add(checkedListBoxMesSterse.Items[i].ToString());
                        }

                        com1.ExecuteNonQuery();
                        con.Close();

                        checkedListBoxMesSterse.Items.Remove(checkedListBoxMesSterse.Items[i].ToString());
                    }
                    else i++;
                }
            }
            else MessageBox.Show("Nu ați selectat niciun mesaj.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
