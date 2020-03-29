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
    public partial class JocXsi0 : Form
    {
        public JocXsi0()
        {
            InitializeComponent();
        }

        int i = 1, x = 0, o = 0, terminat = 0;
        bool b = false;

        private void JocXsi0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void JocXsi0_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;

            if (Conectare.conectat != "")
                textBox3.Text = Conectare.conectat;
            else if (Conectare.conectat == "")
                textBox3.ReadOnly = false;

            Random rnd = new Random();
            int nr = rnd.Next(0, 2);
            if (nr == 0)
                textBox1.Text = "X";
            else
            {
                textBox1.Text = "0";
                b = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button1.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button1.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button1.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }


            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button2.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button2.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button2.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

         
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button5.Text == "X" && button2.Text == "X" && button8.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button5.Text == "0" && button2.Text == "0" && button8.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button3.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button3.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button3.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }


            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button4.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button4.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button4.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button5.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button5.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button5.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

  
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button5.Text == "X" && button2.Text == "X" && button8.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button5.Text == "0" && button2.Text == "0" && button8.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button6.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button6.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button6.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button7.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button7.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button7.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button8.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button8.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button8.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button5.Text == "X" && button2.Text == "X" && button8.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button5.Text == "0" && button2.Text == "0" && button8.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false && button9.Text == "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text != textBox4.Text)
            {
                textBox3.BackColor = System.Drawing.Color.White;
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox4.ForeColor = System.Drawing.Color.Black;

                if (b == false)
                {
                    button9.Text = "X";
                    textBox1.Text = "0";
                    b = true;
                }
                else
                {
                    button9.Text = "0";
                    textBox1.Text = "X";
                    b = false;
                }
                i++;
            }
            

            else if (textBox2.Visible == true)
            {
                MessageBox.Show("Joc terminat. Nu se mai pot efectua modificări.", "Sfârșit de joc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text == "")
                {
                    textBox3.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox3.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox3.Text != "")
                {
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.ForeColor = System.Drawing.Color.Black;
                }

                if (textBox4.Text == "")
                {
                    textBox4.BackColor = System.Drawing.Color.SaddleBrown;
                    textBox4.ForeColor = System.Drawing.Color.White;
                }
                else if (textBox4.Text != "")
                {
                    textBox4.BackColor = System.Drawing.Color.White;
                    textBox4.ForeColor = System.Drawing.Color.Black;
                }
                

                MessageBox.Show("Completați datele înainte de a începe jocul.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("Nu poți juca cu tine însuți.", "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu X a câştigat!";
                x++;

                terminat++;
            }
            else if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Jucătorul cu 0 a câştigat!";
                o++;

                terminat++;
            }
            

            else if (i > 9 && textBox2.Visible == false)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                textBox2.Text = "Nimeni nu a câştigat.";

                terminat++;
            }
            

            if (textBox2.Visible == true && terminat == 1)
            {
                SqlConnection con = new SqlConnection(Conectare.variabila);
                con.Open();
                DateTime dateTime = DateTime.Now;
                string querry = @"INSERT INTO JocXsi0 (Email_X, Email_0, Win_X, Win_0, Overall, Date) VALUES ('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + x + "' , '" + o + "' , '" + 1 + "' , '" + dateTime.Month.ToString() + "/" + dateTime.Day.ToString() + "/" + dateTime.Year.ToString() + "')";

                SqlCommand com = new SqlCommand(querry, con);
                com.ExecuteNonQuery();
                con.Close();

                terminat++;
            }
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilElev f = new ProfilElev();
            f.Show();
        }

        private void buttonRemake_Click(object sender, EventArgs e)
        {
            this.Hide();
            JocXsi0 f = new JocXsi0();
            f.Show();
        }
    }
}
