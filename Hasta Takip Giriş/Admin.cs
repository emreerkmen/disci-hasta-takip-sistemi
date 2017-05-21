using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasta_Takip_Giriş
{
    public partial class Admin : User
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ekleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorGüncelle form = new DoktorGüncelle();
            form.MdiParent = this;
            form.Show();
        }

        private void ekleSilGüncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HastaGüncelle form = new HastaGüncelle();
            form.MdiParent = this;
            form.Show();

        }

        private void ekleSilGüncelleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UygulamaGüncelle form = new UygulamaGüncelle();
            form.MdiParent = this;
            form.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diş Hekimi Hasta Takip Sistemi" + '\n' + "Win. Prog. Dönem Projesi");
        }
    }
}
