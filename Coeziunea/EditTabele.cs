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
    public partial class EditTabele : Form
    {
        public EditTabele()
        {
            InitializeComponent();
        }

        int id_nou, id_nou2;
        bool first = false;
        int[,] A = new int[1000, 1000];

        private void EditTabele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilProfesor_Inspector f = new ProfilProfesor_Inspector();
            f.Show();
        }

        private void EditTabele_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();


            string querry2 = @"SELECT * FROM Conturi_elevi";
            SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewElevi.DataSource = dt;

            con.Close();

            idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
            prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
            emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
            nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
            litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
            parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

            genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
            profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
            scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
            alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
            answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
            codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();
        }

        private void buttonSterg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.No;
            dialogResult = MessageBox.Show("Urmează să ștergi permanent un cont din baza de date. Continui?", "Atențioare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                string querry = @"DELETE FROM Conturi_elevi WHERE Id = '" + idTextBox.Text + "' ";

                SqlCommand com = new SqlCommand(querry, con);

                com.ExecuteNonQuery();
                con.Close();

                dataGridViewElevi.Rows.RemoveAt(dataGridViewElevi.CurrentCell.RowIndex);


                idTextBox.Text = "";
                nameTextBox.Text = "";
                prenameTextBox.Text = "";
                emailTextBox.Text = "";
                nrClsTextBox.Text = "";
                litClsTextBox.Text = "";
                parolaTextBox.Text = "";

                genderTextBox.Text = "";
                profTextBox.Text = "";
                scoalaTextBox.Text = "";
                alegTextBox.Text = "";
                answerTextBox.Text = "";
                codeTextBox.Text = "";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && prenameTextBox.Text != "" && emailTextBox.Text != "" && parolaTextBox.Text != "" && genderTextBox.Text != "" && nrClsTextBox.Text != "" && litClsTextBox.Text != "" && codeTextBox.Text != "" && profTextBox.Text != "" && scoalaTextBox.Text != "")
            {
                pictureBoxNum.Visible = false;
                pictureBoxPren.Visible = false;
                pictureBoxParola.Visible = false;
                pictureBoxEmail.Visible = false;
                pictureBoxGen.Visible = false;
                pictureBoxProf.Visible = false;
                pictureBoxScoala.Visible = false;
                pictureBoxCod.Visible = false;
                pictureBoxNrcls.Visible = false;
                pictureBoxLitcls.Visible = false;


                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                string querry;

                if (answerTextBox.Text == "" && alegTextBox.Text != "")
                    querry = @"UPDATE Conturi_elevi SET Nume = @name, Prenume = @prename, Email = @email, Numar_Clasa = @nrcls, Litera_Clasa = @litcls, Profesor = @prof, Scoala = @sco, Gen = @gender, Parola = @password, Alegeri = @aleg, Cod = @code WHERE Id = '" + idTextBox.Text + "' ";
                else if (alegTextBox.Text == "" && answerTextBox.Text != "")
                    querry = @"UPDATE Conturi_elevi SET Nume = @name, Prenume = @prename, Email = @email, Numar_Clasa = @nrcls, Litera_Clasa = @litcls, Profesor = @prof, Scoala = @sco, Gen = @gender, Parola = @password, Raspunsuri = @answer, Cod = @code WHERE Id = '" + idTextBox.Text + "' ";
                else if (alegTextBox.Text == "" && answerTextBox.Text == "")
                    querry = @"UPDATE Conturi_elevi SET Nume = @name, Prenume = @prename, Email = @email, Numar_Clasa = @nrcls, Litera_Clasa = @litcls, Profesor = @prof, Scoala = @sco, Gen = @gender, Parola = @password, Cod = @code WHERE Id = '" + idTextBox.Text + "' ";
                else
                    querry = @"UPDATE Conturi_elevi SET Nume = @name, Prenume = @prename, Email = @email, Numar_Clasa = @nrcls, Litera_Clasa = @litcls, Profesor = @prof, Scoala = @sco, Gen = @gender, Parola = @password, Alegeri = @aleg, Raspunsuri = @answer, Cod = @code WHERE Id = '" + idTextBox.Text + "' ";


                SqlCommand com = new SqlCommand(querry, con);
                com.Parameters.AddWithValue("name", nameTextBox.Text);
                com.Parameters.AddWithValue("prename", prenameTextBox.Text);
                com.Parameters.AddWithValue("email", emailTextBox.Text);
                com.Parameters.AddWithValue("nrcls", nrClsTextBox.Text);
                com.Parameters.AddWithValue("litcls", litClsTextBox.Text);
                com.Parameters.AddWithValue("password", parolaTextBox.Text);
                com.Parameters.AddWithValue("gender", genderTextBox.Text);
                com.Parameters.AddWithValue("sco", scoalaTextBox.Text);
                com.Parameters.AddWithValue("prof", profTextBox.Text);
                com.Parameters.AddWithValue("code", codeTextBox.Text);


                if (answerTextBox.Text != "")
                    com.Parameters.AddWithValue("answer", answerTextBox.Text);

                if (alegTextBox.Text != "")
                    com.Parameters.AddWithValue("aleg", alegTextBox.Text);


                com.ExecuteNonQuery();

                string querry2 = @"SELECT * FROM Conturi_elevi";
                SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewElevi.DataSource = dt;

                con.Close();
            }
            else
            {
                if (nameTextBox.Text == "")
                    pictureBoxNum.Visible = true;
                else if (nameTextBox.Text != "")
                    pictureBoxNum.Visible = false;

                if (prenameTextBox.Text == "")
                    pictureBoxPren.Visible = true;
                else if (prenameTextBox.Text != "")
                    pictureBoxPren.Visible = false;

                if (parolaTextBox.Text == "")
                    pictureBoxParola.Visible = true;
                else if (parolaTextBox.Text != "")
                    pictureBoxParola.Visible = false;

                if (emailTextBox.Text == "")
                    pictureBoxEmail.Visible = true;
                else if (emailTextBox.Text != "")
                    pictureBoxEmail.Visible = false;

                if (genderTextBox.Text == "")
                    pictureBoxGen.Visible = true;
                else if (genderTextBox.Text != "")
                    pictureBoxGen.Visible = false;

                if (profTextBox.Text == "")
                    pictureBoxProf.Visible = true;
                else if (profTextBox.Text != "")
                    pictureBoxProf.Visible = false;

                if (scoalaTextBox.Text == "")
                    pictureBoxScoala.Visible = true;
                else if (scoalaTextBox.Text != "")
                    pictureBoxScoala.Visible = false;

                if (codeTextBox.Text == "")
                    pictureBoxCod.Visible = true;
                else if (codeTextBox.Text != "")
                    pictureBoxCod.Visible = false;

                if (nrClsTextBox.Text == "")
                    pictureBoxNrcls.Visible = true;
                else if (nrClsTextBox.Text != "")
                    pictureBoxNrcls.Visible = false;

                if (litClsTextBox.Text == "")
                    pictureBoxLitcls.Visible = true;
                else if (litClsTextBox.Text != "")
                    pictureBoxLitcls.Visible = false;


                MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && prenameTextBox.Text != "" && emailTextBox.Text != "" && parolaTextBox.Text != "" && genderTextBox.Text != "" && nrClsTextBox.Text != "" && litClsTextBox.Text != "" && codeTextBox.Text != "" && profTextBox.Text != "" && scoalaTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry1 = @"SELECT * FROM Conturi_elevi WHERE Email = '" + emailTextBox.Text + "' ";

                SqlCommand com1 = new SqlCommand(querry1, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                if (reader1.HasRows == true)
                {
                    reader1.Close();

                    MessageBox.Show("Email-ul există deja în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reader1.HasRows == false)
                {
                    reader1.Close();


                    string Name, Prename, Email, Password, Answers, Alegeri, LitCls, Prof, Scoala;
                    int Gender, Code, NrCls;
                    Name = nameTextBox.Text;
                    Prename = prenameTextBox.Text;
                    Email = emailTextBox.Text;
                    Password = parolaTextBox.Text;
                    Gender = Int32.Parse(genderTextBox.Text);
                    Answers = answerTextBox.Text;
                    Alegeri = alegTextBox.Text;
                    Code = Int32.Parse(codeTextBox.Text);
                    NrCls = Int32.Parse(nrClsTextBox.Text);
                    LitCls = litClsTextBox.Text;
                    Prof = profTextBox.Text;
                    Scoala = scoalaTextBox.Text;


                    string querry;
                    if (Answers == "" && Alegeri != "")
                        querry = @"INSERT INTO Conturi_elevi (Nume, Prenume, Email, Numar_Clasa, Litera_Clasa, Profesor, Scoala, Gen, Parola, Alegeri, Cod) VALUES ('" + Name + "' , '" + Prename + "' , '" + Email + "' , '" + NrCls + "' , '" + LitCls + "' , '" + Prof + "' , '" + Scoala + "' , '" + Gender + "' , '" + Password + "' , '" + Alegeri + "' , '" + Code + "')";
                    else if (Alegeri == "" && Answers != "")
                        querry = @"INSERT INTO Conturi_elevi (Nume, Prenume, Email, Numar_Clasa, Litera_Clasa, Profesor, Scoala, Gen, Parola, Raspunsuri, Cod) VALUES ('" + Name + "' , '" + Prename + "' , '" + Email + "' , '" + NrCls + "' , '" + LitCls + "' , '" + Prof + "' , '" + Scoala + "' , '" + Gender + "' , '" + Password + "' , '" + Answers + "' , '" + Code + "')";
                    else if (Alegeri == "" && Answers == "")
                        querry = @"INSERT INTO Conturi_elevi (Nume, Prenume, Email, Numar_Clasa, Litera_Clasa, Profesor, Scoala, Gen, Parola, Cod) VALUES ('" + Name + "' , '" + Prename + "' , '" + Email + "' , '" + NrCls + "' , '" + LitCls + "' , '" + Prof + "' , '" + Scoala + "' , '" + Gender + "' , '" + Password + "' , '" + Code + "')";
                    else
                        querry = @"INSERT INTO Conturi_elevi (Nume, Prenume, Email, Numar_Clasa, Litera_Clasa, Profesor, Scoala, Gen, Parola, Alegeri, Raspunsuri, Cod) VALUES ('" + Name + "' , '" + Prename + "' , '" + Email + "' , '" + NrCls + "' , '" + LitCls + "' , '" + Prof + "' , '" + Scoala + "' , '" + Gender + "' , '" + Password + "' , '" + Alegeri + "' , '" + Answers + "' , '" + Code + "')";

                    SqlCommand com = new SqlCommand(querry, con);
                    com.ExecuteNonQuery();


                    string querry2 = @"SELECT * FROM Conturi_elevi";
                    SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewElevi.DataSource = dt;

                    con.Close();

                    idTextBox.Text = dataGridViewElevi.Rows[id_nou].Cells[0].Value.ToString();
                }

                reader1.Close();
                con.Close();
            }
            else
            {
                if (nameTextBox.Text == "")
                    pictureBoxNum.Visible = true;
                else if (nameTextBox.Text != "")
                    pictureBoxNum.Visible = false;

                if (prenameTextBox.Text == "")
                    pictureBoxPren.Visible = true;
                else if (prenameTextBox.Text != "")
                    pictureBoxPren.Visible = false;

                if (parolaTextBox.Text == "")
                    pictureBoxParola.Visible = true;
                else if (parolaTextBox.Text != "")
                    pictureBoxParola.Visible = false;

                if (emailTextBox.Text == "")
                    pictureBoxEmail.Visible = true;
                else if (emailTextBox.Text != "")
                    pictureBoxEmail.Visible = false;

                if (genderTextBox.Text == "")
                    pictureBoxGen.Visible = true;
                else if (genderTextBox.Text != "")
                    pictureBoxGen.Visible = false;

                if (profTextBox.Text == "")
                    pictureBoxProf.Visible = true;
                else if (profTextBox.Text != "")
                    pictureBoxProf.Visible = false;

                if (scoalaTextBox.Text == "")
                    pictureBoxScoala.Visible = true;
                else if (scoalaTextBox.Text != "")
                    pictureBoxScoala.Visible = false;

                if (codeTextBox.Text == "")
                    pictureBoxCod.Visible = true;
                else if (codeTextBox.Text != "")
                    pictureBoxCod.Visible = false;

                if (nrClsTextBox.Text == "")
                    pictureBoxNrcls.Visible = true;
                else if (nrClsTextBox.Text != "")
                    pictureBoxNrcls.Visible = false;

                if (litClsTextBox.Text == "")
                    pictureBoxLitcls.Visible = true;
                else if (litClsTextBox.Text != "")
                    pictureBoxLitcls.Visible = false;


                MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewElevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[1].Value.ToString();
            prenameTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[2].Value.ToString();
            emailTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[3].Value.ToString();
            nrClsTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[4].Value.ToString();
            litClsTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[5].Value.ToString();
            parolaTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[9].Value.ToString();

            genderTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[8].Value.ToString();
            profTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[6].Value.ToString();
            scoalaTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[7].Value.ToString();
            alegTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[10].Value.ToString();
            answerTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[11].Value.ToString();
            codeTextBox.Text = dataGridViewElevi.Rows[dataGridViewElevi.CurrentCell.RowIndex].Cells[12].Value.ToString();

            id_nou = dataGridViewElevi.CurrentCell.RowIndex;
        }

        private void buttonReven1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();
            string querry2 = @"SELECT * FROM Conturi_elevi";
            SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewElevi.DataSource = dt;

            con.Close();


            label20.Visible = false;
            textBoxCautare.Text = "Nume/Prenume/Email";

            textBoxCautare.ForeColor = System.Drawing.Color.Gray;
            textBoxCautare.Font = new Font(textBoxCautare.Font.FontFamily, textBoxCautare.Font.Size, FontStyle.Italic);

            buttonReven1.Visible = false;

            idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
            prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
            emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
            nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
            litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
            parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

            genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
            profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
            scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
            alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
            answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
            codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBoxCautare.Text == "Nume/Prenume/Email")
                textBoxCautare.Text = "";

            textBoxCautare.ForeColor = System.Drawing.Color.Black;
            textBoxCautare.Font = new Font(textBoxCautare.Font.FontFamily, textBoxCautare.Font.Size, FontStyle.Regular);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            prenameTextBox.Text = "";
            emailTextBox.Text = "";
            nrClsTextBox.Text = "";
            litClsTextBox.Text = "";
            parolaTextBox.Text = "";

            genderTextBox.Text = "";
            profTextBox.Text = "";
            scoalaTextBox.Text = "";
            alegTextBox.Text = "";
            answerTextBox.Text = "";
            codeTextBox.Text = "";

            buttonReven1.Visible = true;

            int results = 0;
            DataTable tabel = new DataTable();


            tabel.Columns.Add("Id", typeof(int));
            tabel.Columns.Add("Nume", typeof(string));
            tabel.Columns.Add("Prenume", typeof(string));
            tabel.Columns.Add("Email", typeof(string));
            tabel.Columns.Add("Număr_Clasă", typeof(int));
            tabel.Columns.Add("Litera_Clasă", typeof(string));
            tabel.Columns.Add("Profesor", typeof(string));
            tabel.Columns.Add("Școală", typeof(string));
            tabel.Columns.Add("Gen", typeof(int));
            tabel.Columns.Add("Parolă", typeof(string));
            tabel.Columns.Add("Alegeri", typeof(string));
            tabel.Columns.Add("Răspunsuri", typeof(string));
            tabel.Columns.Add("Cod", typeof(int));



            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();
            string querry = @"SELECT * FROM Conturi_elevi";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();

            string[] nume_prenume = new string[50];
            string[] nume_tabel = new string[50];
            while (reader.Read())
            {
                nume_prenume = textBoxCautare.Text.Split(' ').Select(text => text.ToString()).ToArray();
                nume_tabel = reader["Prenume"].ToString().Split(' ').Select(text => text.ToString()).ToArray();

                if (textBoxCautare.Text != "")
                {
                    if (nume_prenume.Length == 1)
                    {
                        if (reader["Nume"].ToString() == nume_prenume[0])
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                        else if (nume_tabel.Length == 1 && reader["Prenume"].ToString() == nume_prenume[0])
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                        else if (nume_tabel.Length == 2)
                        {
                            if (nume_prenume[0] == nume_tabel[1])
                            {
                                results++;

                                if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                                else
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            }
                            else if (nume_prenume[0] == nume_tabel[0])
                            {
                                results++;

                                if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                                else
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            }
                        }
                    }
                    else if (nume_prenume.Length == 2)
                    {
                        if (nume_tabel.Length == 1 && reader["Nume"].ToString() + " " + reader["Prenume"].ToString() == nume_prenume[0] + " " + nume_prenume[1])
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                        else if (nume_tabel.Length == 2 && (reader["Nume"].ToString() + " " + nume_tabel[0] == nume_prenume[0] + " " + nume_prenume[1] || reader["Nume"].ToString() + " " + nume_tabel[1] == nume_prenume[0] + " " + nume_prenume[1]))
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                        else if (nume_tabel.Length == 2)
                        {
                            if ((nume_tabel[0] + " " + nume_tabel[1] == nume_prenume[0] + " " + nume_prenume[1]) || (nume_tabel[1] + " " + nume_tabel[0] == nume_prenume[0] + " " + nume_prenume[1]))
                            {
                                results++;

                                if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                                else
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            }
                            else if ((reader["Nume"].ToString() + " " + nume_tabel[0] == nume_prenume[0] + " " + nume_prenume[1]) || (nume_tabel[0] + " " + reader["Nume"].ToString() == nume_prenume[0] + " " + nume_prenume[1]))
                            {
                                results++;

                                if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                                else
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            }
                            else if ((reader["Nume"].ToString() + " " + nume_tabel[1] == nume_prenume[0] + " " + nume_prenume[1]) || (nume_tabel[1] + " " + reader["Nume"].ToString() == nume_prenume[0] + " " + nume_prenume[1]))
                            {
                                results++;

                                if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                                else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                                else
                                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            }
                        }
                    }
                    else if (nume_prenume.Length == 3 && nume_tabel.Length == 2)
                    {
                        if ((reader["Nume"].ToString() + " " + nume_tabel[0] + " " + nume_tabel[1] == nume_prenume[0] + " " + nume_prenume[1] + " " + nume_prenume[2]) || (reader["Nume"].ToString() + " " + nume_tabel[1] + " " + nume_tabel[0] == nume_prenume[0] + " " + nume_prenume[1] + " " + nume_prenume[2]))
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                        else if ((nume_tabel[0] + " " + nume_tabel[1] + " " + reader["Nume"].ToString() == nume_prenume[0] + " " + nume_prenume[1] + " " + nume_prenume[2]) || (nume_tabel[1] + " " + nume_tabel[0] + " " + reader["Nume"].ToString() == nume_prenume[0] + " " + nume_prenume[1] + " " + nume_prenume[2]))
                        {
                            results++;

                            if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                            else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                            else
                                tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        }
                    }
                    else if (reader["Email"].ToString() == textBoxCautare.Text)
                    {
                        results++;

                        if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                            tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                        else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                            tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                        else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                            tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                        else
                            tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                    }
                }
            }

            reader.Close();
            con.Close();

            dataGridViewElevi.DataSource = tabel;

            if (results == 0)
            {
                label20.Visible = true;

                label20.Text = "Nu s-a găsit niciun cont cu datele menționate.";
            }
            else if (results == 1)
            {
                idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
                nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
                prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
                emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
                nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
                litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
                parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

                genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
                profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
                scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
                alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
                answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
                codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();

                label20.Visible = true;

                label20.Text = "S-a găsit " + results.ToString() + " rezultat.";
            }
            else if (results > 1)
            {
                idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
                nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
                prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
                emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
                nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
                litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
                parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

                genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
                profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
                scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
                alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
                answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
                codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();

                label20.Visible = true;

                label20.Text = "S-au găsit " + results.ToString() + " rezultate.";
            }
        }

        private void textBoxNumar_Click(object sender, EventArgs e)
        {
            if (textBoxNumar.Text == "Numărul")
                textBoxNumar.Text = "";

            textBoxNumar.ForeColor = System.Drawing.Color.Black;
            textBoxNumar.Font = new Font(textBoxNumar.Font.FontFamily, textBoxNumar.Font.Size, FontStyle.Regular);
        }

        private void textBoxLitera_Click(object sender, EventArgs e)
        {
            if (textBoxLitera.Text == "Litera")
                textBoxLitera.Text = "";

            textBoxLitera.ForeColor = System.Drawing.Color.Black;
            textBoxLitera.Font = new Font(textBoxLitera.Font.FontFamily, textBoxLitera.Font.Size, FontStyle.Regular);
        }

        private void buttonRevin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();
            string querry2 = @"SELECT * FROM Conturi_elevi";
            SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewElevi.DataSource = dt;

            con.Close();


            labelRez1.Visible = false;
            textBoxNumar.Text = "Numărul";
            textBoxLitera.Text = "Litera";

            textBoxNumar.ForeColor = System.Drawing.Color.Gray;
            textBoxNumar.Font = new Font(textBoxNumar.Font.FontFamily, textBoxNumar.Font.Size, FontStyle.Italic);

            textBoxLitera.ForeColor = System.Drawing.Color.Gray;
            textBoxLitera.Font = new Font(textBoxLitera.Font.FontFamily, textBoxLitera.Font.Size, FontStyle.Italic);


            buttonRevin.Visible = false;

            idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
            prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
            emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
            nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
            litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
            parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

            genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
            profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
            scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
            alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
            answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
            codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();
        }

        private void buttonCaut1_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            prenameTextBox.Text = "";
            emailTextBox.Text = "";
            nrClsTextBox.Text = "";
            litClsTextBox.Text = "";
            parolaTextBox.Text = "";

            genderTextBox.Text = "";
            profTextBox.Text = "";
            scoalaTextBox.Text = "";
            alegTextBox.Text = "";
            answerTextBox.Text = "";
            codeTextBox.Text = "";

            buttonRevin.Visible = true;

            int results = 0;
            DataTable tabel = new DataTable();


            tabel.Columns.Add("Id", typeof(int));
            tabel.Columns.Add("Nume", typeof(string));
            tabel.Columns.Add("Prenume", typeof(string));
            tabel.Columns.Add("Email", typeof(string));
            tabel.Columns.Add("Număr_Clasă", typeof(int));
            tabel.Columns.Add("Litera_Clasă", typeof(string));
            tabel.Columns.Add("Profesor", typeof(string));
            tabel.Columns.Add("Școală", typeof(string));
            tabel.Columns.Add("Gen", typeof(int));
            tabel.Columns.Add("Parolă", typeof(string));
            tabel.Columns.Add("Alegeri", typeof(string));
            tabel.Columns.Add("Răspunsuri", typeof(string));
            tabel.Columns.Add("Cod", typeof(int));



            SqlConnection con = new SqlConnection(Conectare.variabila);
            con.Open();
            string querry = @"SELECT * FROM Conturi_elevi";

            SqlCommand com = new SqlCommand(querry, con);
            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {
                if (reader["Numar_Clasa"].ToString() == textBoxNumar.Text && reader["Litera_Clasa"].ToString() == textBoxLitera.Text)
                {
                    results++;

                    if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                    else
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                }
                else if (reader["Numar_Clasa"].ToString() == textBoxNumar.Text && (textBoxLitera.Text == "Litera" || textBoxLitera.Text == ""))
                {
                    results++;

                    if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                    else
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                }
                else if ((textBoxNumar.Text == "Numărul" || textBoxNumar.Text == "") && reader["Litera_Clasa"].ToString() == textBoxLitera.Text)
                {
                    results++;

                    if (reader["Raspunsuri"].ToString() == "" && reader["Alegeri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), null, reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() != "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                    else if (reader["Alegeri"].ToString() == "" && reader["Raspunsuri"].ToString() == "")
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), null, null, reader["Cod"].ToString());
                    else
                        tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Email"].ToString(), reader["Numar_Clasa"].ToString(), reader["Litera_Clasa"].ToString(), reader["Profesor"].ToString(), reader["Scoala"].ToString(), reader["Gen"].ToString(), reader["Parola"].ToString(), reader["Alegeri"].ToString(), reader["Raspunsuri"].ToString(), reader["Cod"].ToString());
                }
            }

            reader.Close();
            con.Close();

            dataGridViewElevi.DataSource = tabel;

            if (results == 0)
            {
                labelRez1.Visible = true;

                labelRez1.Text = "Nu s-a găsit niciun cont cu datele menționate.";
            }
            else if (results == 1)
            {
                idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
                nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
                prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
                emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
                nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
                litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
                parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

                genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
                profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
                scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
                alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
                answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
                codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();

                labelRez1.Visible = true;

                labelRez1.Text = "S-a găsit " + results.ToString() + " rezultat.";
            }
            else if (results > 1)
            {
                idTextBox.Text = dataGridViewElevi.Rows[0].Cells[0].Value.ToString();
                nameTextBox.Text = dataGridViewElevi.Rows[0].Cells[1].Value.ToString();
                prenameTextBox.Text = dataGridViewElevi.Rows[0].Cells[2].Value.ToString();
                emailTextBox.Text = dataGridViewElevi.Rows[0].Cells[3].Value.ToString();
                nrClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[4].Value.ToString();
                litClsTextBox.Text = dataGridViewElevi.Rows[0].Cells[5].Value.ToString();
                parolaTextBox.Text = dataGridViewElevi.Rows[0].Cells[9].Value.ToString();

                genderTextBox.Text = dataGridViewElevi.Rows[0].Cells[8].Value.ToString();
                profTextBox.Text = dataGridViewElevi.Rows[0].Cells[6].Value.ToString();
                scoalaTextBox.Text = dataGridViewElevi.Rows[0].Cells[7].Value.ToString();
                alegTextBox.Text = dataGridViewElevi.Rows[0].Cells[10].Value.ToString();
                answerTextBox.Text = dataGridViewElevi.Rows[0].Cells[11].Value.ToString();
                codeTextBox.Text = dataGridViewElevi.Rows[0].Cells[12].Value.ToString();

                labelRez1.Visible = true;

                labelRez1.Text = "S-au găsit " + results.ToString() + " rezultate.";
            }
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 1 && first == false)
            {
                if (Conectare.status == 0)
                {
                    buttonSterg1.Enabled = false;
                    buttonUpdate1.Enabled = false;
                    buttonAdd1.Enabled = false;
                }


                first = true;

                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();


                string querry2 = @"SELECT * FROM Conturi_profesori_inspectori";
                SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProfi.DataSource = dt;

                con.Close();

                idTextBox1.Text = dataGridViewProfi.Rows[0].Cells[0].Value.ToString();
                nameTextBox1.Text = dataGridViewProfi.Rows[0].Cells[1].Value.ToString();
                prenameTextBox1.Text = dataGridViewProfi.Rows[0].Cells[2].Value.ToString();
                parolaTextBox1.Text = dataGridViewProfi.Rows[0].Cells[3].Value.ToString();
                emailTextBox1.Text = dataGridViewProfi.Rows[0].Cells[4].Value.ToString();
                scoalaTextBox1.Text = dataGridViewProfi.Rows[0].Cells[5].Value.ToString();
                claseTextBox1.Text = dataGridViewProfi.Rows[0].Cells[6].Value.ToString();


                SqlConnection con1 = new SqlConnection(Conectare.variabila);
                con1.Open();


                SqlCommand com1 = new SqlCommand(querry2, con1);
                SqlDataReader reader = com1.ExecuteReader();

                while (reader.Read())
                {
                    listBoxProfi.Items.Add(reader["Nume"].ToString() + " " + reader["Prenume"].ToString());
                }

                reader.Close();
                con.Close();
            }
        }

        private void buttonSterg1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.No;
            dialogResult = MessageBox.Show("Urmează să ștergi permanent un cont din baza de date. Continui?", "Atențioare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                string querry = @"DELETE FROM Conturi_profesori_inspectori WHERE Id = '" + idTextBox1.Text + "' ";

                SqlCommand com = new SqlCommand(querry, con);

                com.ExecuteNonQuery();
                con.Close();

                dataGridViewProfi.Rows.RemoveAt(dataGridViewProfi.CurrentCell.RowIndex);


                idTextBox1.Text = "";
                nameTextBox1.Text = "";
                prenameTextBox1.Text = "";
                emailTextBox1.Text = "";

                parolaTextBox1.Text = "";
                scoalaTextBox1.Text = "";
                claseTextBox1.Text = "";
            }
        }

        int cMarg = 0, cPop = 0, cDis = 0;

        private void buttonUpdate1_Click(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "" && prenameTextBox1.Text != "" && emailTextBox1.Text != "" && parolaTextBox1.Text != "")
            {
                pictureBoxNum1.Visible = false;
                pictureBoxPren1.Visible = false;
                pictureBoxParola1.Visible = false;
                pictureBoxEmail1.Visible = false;


                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                string querry;

                if (scoalaTextBox1.Text == "" && claseTextBox1.Text != "")
                    querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Clase = @clase WHERE Id = '" + idTextBox1.Text + "' ";
                else if (claseTextBox1.Text == "" && scoalaTextBox1.Text != "")
                    querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Scoala = @sco WHERE Id = '" + idTextBox1.Text + "' ";
                else if (claseTextBox1.Text == "" && scoalaTextBox1.Text == "")
                    querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email WHERE Id = '" + idTextBox1.Text + "' ";
                else
                    querry = @"UPDATE Conturi_profesori_inspectori SET Nume = @name, Prenume = @prename, Parola = @password, Email = @email, Scoala = @sco, Clase = @clase WHERE Id = '" + idTextBox1.Text + "' ";


                SqlCommand com = new SqlCommand(querry, con);
                com.Parameters.AddWithValue("name", nameTextBox1.Text);
                com.Parameters.AddWithValue("prename", prenameTextBox1.Text);
                com.Parameters.AddWithValue("email", emailTextBox1.Text);
                com.Parameters.AddWithValue("password", parolaTextBox1.Text);


                if (scoalaTextBox1.Text != "")
                    com.Parameters.AddWithValue("sco", scoalaTextBox1.Text);

                if (claseTextBox1.Text != "")
                    com.Parameters.AddWithValue("clase", claseTextBox1.Text);


                com.ExecuteNonQuery();

                string querry2 = @"SELECT * FROM Conturi_profesori_inspectori";
                SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProfi.DataSource = dt;

                con.Close();
            }
            else
            {
                if (nameTextBox1.Text == "")
                    pictureBoxNum1.Visible = true;
                else if (nameTextBox.Text != "")
                    pictureBoxNum1.Visible = false;

                if (prenameTextBox1.Text == "")
                    pictureBoxPren1.Visible = true;
                else if (prenameTextBox.Text != "")
                    pictureBoxPren1.Visible = false;

                if (parolaTextBox1.Text == "")
                    pictureBoxParola1.Visible = true;
                else if (parolaTextBox.Text != "")
                    pictureBoxParola1.Visible = false;

                if (emailTextBox1.Text == "")
                    pictureBoxEmail1.Visible = true;
                else if (emailTextBox.Text != "")
                    pictureBoxEmail1.Visible = false;


                MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int lungime = 0, incep = 0;
        int[] popular = new int[30];
        int[] displacut = new int[30];
        int[] ignorat = new int[30];

        private void buttonCautacls_Click(object sender, EventArgs e)
        {
            if ((textBoxNumarCls.Text != "Numărul" && textBoxNumarCls.Text != "") && (textBoxLiteraCls.Text != "Litera" && textBoxLiteraCls.Text != ""))
            {
                cPop = 0;
                pop = 0;
                cDis = 0;
                dis = 0;
                cMarg = 0;
                marg = 0;

                listBoxEchipa2.Items.Clear();
                listBoxEchipa3.Items.Clear();

                for (int p = 1; p <= lungime; p++)
                    for (int q = 1; q <= lungime; q++)
                        A[p, q] = 0;

                string[] vector = new string[10];
                int elevi = 0, elevi_cu_raspunsuri = 0, maxim = 0, maxim1 = 0, numar = 0, numar1 = 0;
                

                double media_aritmetica = 0;
                int nr_testcoop = 0;

                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com = new SqlCommand(querry, con);
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    elevi++;

                    if (reader["Alegeri"].ToString() != "")
                    {
                        media_aritmetica = media_aritmetica + double.Parse(reader["Alegeri"].ToString());
                        nr_testcoop++;
                    }

                    if (reader["Raspunsuri"].ToString() != "")
                    {
                        if (incep == 0)
                            incep = Int32.Parse(reader["Id"].ToString());

                        elevi_cu_raspunsuri++;
                        vector = reader["Raspunsuri"].ToString().Split(' ').Select(text => text.ToString()).ToArray();

                        A[Int32.Parse(reader["Id"].ToString()), Int32.Parse(vector[0])] = 1;
                        A[Int32.Parse(reader["Id"].ToString()), Int32.Parse(vector[1])] = 1;
                        A[Int32.Parse(reader["Id"].ToString()), Int32.Parse(vector[2])] = -1;
                        A[Int32.Parse(reader["Id"].ToString()), Int32.Parse(vector[3])] = -1;

                        lungime = Int32.Parse(reader["Id"].ToString());
                    }
                }

                reader.Close();
                con.Close();

                int i, j, echipe2 = 0;
                for (i = incep; i <= lungime; i++)
                {
                    numar = 0;
                    numar1 = 0;

                    for (j = incep; j <= lungime; j++)
                    {
                        if (A[i, j] == A[j, i] && A[i, j] == 1 && i < j)
                        {
                            listBoxEchipa2.Items.Add(i.ToString() + "-" + j.ToString());
                            echipe2++;
                        }

                        if (A[j, i] == 1)
                            numar++;

                        if (A[j, i] == -1)
                            numar1++;
                    }

                    if (maxim <= numar)
                    {
                        maxim = numar;
                    }

                    if (maxim1 <= numar1)
                    {
                        maxim1 = numar1;
                    }

                    if (numar == 0 && numar1 == 0)
                    {
                        ignorat[cMarg] = i;
                        cMarg++;
                    }
                }


                for (i = incep; i <= lungime; i++)
                {
                    numar = 0;
                    numar1 = 0;

                    for (j = incep; j <= lungime; j++)
                    {
                        if (A[j, i] == 1)
                            numar++;

                        if (A[j, i] == -1)
                            numar1++;
                    }

                    if (maxim == numar)
                    {
                        popular[cPop] = i;
                        cPop++;
                    }

                    if (maxim1 == numar1)
                    {
                        displacut[cDis] = i;
                        cDis++;
                    }
                }

                if (cPop != 0)
                {
                    buttonPopulari.Visible = true;
                    buttonPopulari.Text = cPop.ToString();
                }
                else buttonPopulari.Visible = false;

                if (cDis != 0)
                {
                    buttonDisplacuti.Visible = true;
                    buttonDisplacuti.Text = cDis.ToString();
                }
                else buttonDisplacuti.Visible = false;

                if (cMarg != 0)
                {
                    buttonMarginalizati.Visible = true;
                    buttonMarginalizati.Text = cMarg.ToString();
                }
                else buttonMarginalizati.Visible = false;


                int k, echipe3 = 0;
                for (i = incep; i <= lungime; i++)
                    for (j = incep; j <= lungime; j++)
                        for (k = incep; k <= lungime; k++)
                            if (A[i, j] == A[j, i] && A[i, k] == A[k, i] && A[k, j] == A[j, k] && A[i, j] == 1 && A[k, j] == 1 && A[i, k] == 1 && i < j && j < k)
                            {
                                listBoxEchipa3.Items.Add(i.ToString() + "-" + j.ToString() + "-" + k.ToString());
                                echipe3++;
                            }


                con.Open();

                querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com1 = new SqlCommand(querry, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                string elev_popular = "", elev_displacut = "", elev_ignorat = "";

                while (reader1.Read())
                {
                    string[] grupuri = new string[5];

                    for (i = 0; i < echipe2; i++)
                    {
                        grupuri = listBoxEchipa2.Items[i].ToString().Split('-').Select(text => text.ToString()).ToArray();

                        for (j = 0; j <= 1; j++)
                            if (reader1["Id"].ToString() == grupuri[j])
                            {
                                grupuri[j] = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                            }
                        listBoxEchipa2.Items[i] = grupuri[0].ToString() + "-" + grupuri[1].ToString();
                    }

                    for (i = 0; i < echipe3; i++)
                    {
                        grupuri = listBoxEchipa3.Items[i].ToString().Split('-').Select(text => text.ToString()).ToArray();

                        for (j = 0; j <= 2; j++)
                            if (reader1["Id"].ToString() == grupuri[j])
                            {
                                grupuri[j] = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                            }
                        listBoxEchipa3.Items[i] = grupuri[0].ToString() + "-" + grupuri[1].ToString() + "-" + grupuri[2].ToString();
                    }

                    if (reader1["Id"].ToString() == popular[0].ToString())
                        elev_popular = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                    if (reader1["Id"].ToString() == displacut[0].ToString())
                        elev_displacut = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                    if (reader1["Id"].ToString() == ignorat[0].ToString())
                        elev_ignorat = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                }

                reader1.Close();
                con.Close();

                labelEleviRezult.Visible = true;

                if (elevi == 0)
                {
                    labelEleviRezult.Text = "Clasa căutată nu se regăsește în baza de date.";
                    labelElevPopular.Text = "Elevul popular.";
                    labelElevDisplacut.Text = "Elevul displăcut.";
                    labelElevIgnorat.Text = "Elevul marginalizat.";

                    buttonPopulari.Visible = false;
                    buttonDisplacuti.Visible = false;
                    buttonMarginalizati.Visible = false;
                }
                else if (elevi_cu_raspunsuri == 0)
                {
                    labelEleviRezult.Text = "Niciun elev nu a făcut testul sociometric.";
                    labelElevPopular.Text = "Elevul popular.";
                    labelElevDisplacut.Text = "Elevul displăcut.";
                    labelElevIgnorat.Text = "Elevul marginalizat.";
                }
                else if (elevi > elevi_cu_raspunsuri)
                    labelEleviRezult.Text = "Dintre cei " + elevi.ToString() + " elevi, " + elevi_cu_raspunsuri.ToString() + " au făcut testul sociometric.";
                else if (elevi == elevi_cu_raspunsuri)
                {
                    if (elevi > 19)
                        labelEleviRezult.Text = "Toți cei " + elevi.ToString() + " de elevi ai clasei căutate au făcut testul sociometric.";
                    else
                        labelEleviRezult.Text = "Toți cei " + elevi.ToString() + " elevi ai clasei căutate au făcut testul sociometric.";
                }

                if (elevi_cu_raspunsuri != 0)
                {

                    if (ignorat[0] == 0)
                        labelElevIgnorat.Text = "Nu există niciun elev marginalizat.";
                    else labelElevIgnorat.Text = "Elevul " + elev_ignorat + " este marginalizat.";

                    labelElevPopular.Text = "Cel mai popular elev este " + elev_popular + ".";
                    labelElevDisplacut.Text = "Cel mai displăcut elev este " + elev_displacut + ".";
                }


                DataTable tabel = new DataTable();

                tabel.Columns.Add("Id", typeof(int));
                tabel.Columns.Add("Nume", typeof(string));
                tabel.Columns.Add("Prenume", typeof(string));
                tabel.Columns.Add("Alegeri", typeof(string));

                con.Open();

                querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com2 = new SqlCommand(querry, con);
                reader = com2.ExecuteReader();

                while (reader.Read())
                {
                    tabel.Rows.Add(reader["Id"].ToString(), reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Alegeri"].ToString());
                }

                reader.Close();
                con.Close();

                dataGridViewTestColaborare.DataSource = tabel;

                if (nr_testcoop != 0)
                {
                    textBoxTestCoop.Text = ((media_aritmetica / nr_testcoop) * 100).ToString() + "%";
                }
                else textBoxTestCoop.Text = "";
            }
            else MessageBox.Show("Nu ați completat toate câmpurile pentru căutare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            if (nameTextBox1.Text != "" && prenameTextBox1.Text != "" && emailTextBox1.Text != "" && parolaTextBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry1 = @"SELECT * FROM Conturi_profesori_inspectori WHERE Email = '" + emailTextBox1.Text + "' ";

                SqlCommand com1 = new SqlCommand(querry1, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                if (reader1.HasRows == true)
                {
                    reader1.Close();

                    MessageBox.Show("Email-ul există deja în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reader1.HasRows == false)
                {
                    reader1.Close();


                    string Name, Prename, Email, Password, Clase, Scoala;
                    Name = nameTextBox1.Text;
                    Prename = prenameTextBox1.Text;
                    Email = emailTextBox1.Text;
                    Password = parolaTextBox1.Text;

                    Scoala = scoalaTextBox1.Text;
                    Clase = claseTextBox1.Text;


                    string querry;
                    if (Scoala == "" && Clase != "")
                        querry = @"INSERT INTO Conturi_profesori_inspectori (Nume, Prenume, Parola, Email, Clase) VALUES ('" + Name + "' , '" + Prename + "' , '" + Password + "' , '" + Email + "' , '" + Clase + "')";
                    else if (Clase == "" && Scoala != "")
                        querry = @"INSERT INTO Conturi_profesori_inspectori (Nume, Prenume, Parola, Email, Scoala) VALUES ('" + Name + "' , '" + Prename + "' , '" + Password + "' , '" + Email + "' , '" + Scoala + "')";
                    else if (Clase == "" && Scoala == "")
                        querry = @"INSERT INTO Conturi_profesori_inspectori (Nume, Prenume, Parola, Email) VALUES ('" + Name + "' , '" + Prename + "' , '" + Password + "' , '" + Email + "')";
                    else
                        querry = @"INSERT INTO Conturi_profesori_inspectori (Nume, Prenume, Parola, Email, Scoala, Clase) VALUES ('" + Name + "' , '" + Prename + "' , '" + Password + "' , '" + Email + "' , '" + Scoala + "' , '" + Clase + "')";

                    SqlCommand com = new SqlCommand(querry, con);
                    com.ExecuteNonQuery();


                    string querry2 = @"SELECT * FROM Conturi_profesori_inspectori";
                    SqlDataAdapter sda = new SqlDataAdapter(querry2, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewProfi.DataSource = dt;

                    con.Close();

                    idTextBox1.Text = dataGridViewProfi.Rows[id_nou2].Cells[0].Value.ToString();

                    listBoxProfi.Items.Add(Name + " " + Prename);
                }

                reader1.Close();
                con.Close();
            }
            else
            {
                if (nameTextBox1.Text == "")
                    pictureBoxNum1.Visible = true;
                else if (nameTextBox.Text != "")
                    pictureBoxNum1.Visible = false;

                if (prenameTextBox1.Text == "")
                    pictureBoxPren1.Visible = true;
                else if (prenameTextBox.Text != "")
                    pictureBoxPren1.Visible = false;

                if (parolaTextBox1.Text == "")
                    pictureBoxParola1.Visible = true;
                else if (parolaTextBox.Text != "")
                    pictureBoxParola1.Visible = false;

                if (emailTextBox1.Text == "")
                    pictureBoxEmail1.Visible = true;
                else if (emailTextBox.Text != "")
                    pictureBoxEmail1.Visible = false;


                MessageBox.Show("Există spații necompletate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNumarCls_Click(object sender, EventArgs e)
        {
            if (textBoxNumarCls.Text == "Numărul")
                textBoxNumarCls.Text = "";

            textBoxNumarCls.ForeColor = System.Drawing.Color.Black;
            textBoxNumarCls.Font = new Font(textBoxNumarCls.Font.FontFamily, textBoxNumarCls.Font.Size, FontStyle.Regular);
        }

        int pop = 0, dis = 0, marg = 0;

        private void buttonPopulari_Click(object sender, EventArgs e)
        {
            if (cPop > 1)
            {
                if (pop == cPop - 1)
                    pop = 0;
                else pop++;


                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com1 = new SqlCommand(querry, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                string elev_popular = "";

                while (reader1.Read())
                {
                    if (reader1["Id"].ToString() == popular[pop].ToString())
                        elev_popular = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                }

                reader1.Close();
                con.Close();


                labelElevPopular.Text = "Cel mai popular elev este " + elev_popular + ".";
            }
        }

        private void buttonDisplacuti_Click(object sender, EventArgs e)
        {
            if (cDis > 1)
            {
                if (dis == cDis - 1)
                    dis = 0;
                else dis++;


                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com1 = new SqlCommand(querry, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                string elev_displacut = "";

                while (reader1.Read())
                {
                    if (reader1["Id"].ToString() == displacut[dis].ToString())
                        elev_displacut = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                }

                reader1.Close();
                con.Close();


                labelElevDisplacut.Text = "Cel mai displăcut elev este " + elev_displacut + ".";
            }
        }

        private void buttonMarginalizati_Click(object sender, EventArgs e)
        {
            if (cMarg > 1)
            {
                if (marg == cMarg - 1)
                    marg = 0;
                else marg++;


                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();

                string querry = @"SELECT * FROM Conturi_elevi WHERE Numar_Clasa = '" + Int32.Parse(textBoxNumarCls.Text) + "' AND Litera_Clasa = '" + textBoxLiteraCls.Text + "' ";
                SqlCommand com1 = new SqlCommand(querry, con);
                SqlDataReader reader1 = com1.ExecuteReader();

                string elev_ignorat = "";

                while (reader1.Read())
                {
                    if (reader1["Id"].ToString() == ignorat[marg].ToString())
                        elev_ignorat = reader1["Nume"].ToString() + " " + reader1["Prenume"].ToString();
                }

                reader1.Close();
                con.Close();

                labelElevIgnorat.Text = "Elevul " + elev_ignorat + " este marginalizat.";
            }
        }

        private void textBoxLiteraCls_Click(object sender, EventArgs e)
        {
            if (textBoxLiteraCls.Text == "Litera")
                textBoxLiteraCls.Text = "";

            textBoxLiteraCls.ForeColor = System.Drawing.Color.Black;
            textBoxLiteraCls.Font = new Font(textBoxLiteraCls.Font.FontFamily, textBoxLiteraCls.Font.Size, FontStyle.Regular);
        }

        private void buttonGenereaza_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nr = rnd.Next(1000, 10000);
            codeTextBox.Text = nr.ToString();
        }

        private void dataGridViewProfi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[0].Value.ToString();
            nameTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[1].Value.ToString();
            prenameTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[2].Value.ToString();
            emailTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[4].Value.ToString();

            parolaTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[3].Value.ToString();
            scoalaTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[5].Value.ToString();
            claseTextBox1.Text = dataGridViewProfi.Rows[dataGridViewProfi.CurrentCell.RowIndex].Cells[6].Value.ToString();

            id_nou2 = dataGridViewProfi.CurrentCell.RowIndex;
        }
    }
}
