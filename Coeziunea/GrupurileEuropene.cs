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
    public partial class GrupurileEuropene : Form
    {
        public GrupurileEuropene()
        {
            InitializeComponent();
        }

        private void GrupurileEuropene_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipala f = new PaginaPrincipala();
            f.Show();
        }
    }
}
