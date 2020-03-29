using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coeziunea
{
    public partial class Coperta : Form
    {
        public Coperta()
        {
            InitializeComponent();
        }

        private void Coperta_Load(object sender, EventArgs e)
        {
            string a = Application.StartupPath;
            a = a.Substring(0, a.Length - 10);
            a = a + @"\Tabele.mdf";

            string b = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + a + "; Integrated Security = True";

            Conectare.variabila = b;

            Conectare.conectat = "";
        }

        private void Coperta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTitlu_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f = new PaginaPrincipala();
            f.Show();
        }
    }
}
