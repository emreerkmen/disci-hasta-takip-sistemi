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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorGörüntüle form = new DoktorGörüntüle();
            form.MdiParent = this;
            form.Show();
        }

        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaGörüntüle form = new HastaGörüntüle();
            form.MdiParent = this;
            form.Show();

        }

        private void uygulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UygulamaGörüntüle form = new UygulamaGörüntüle();
            form.MdiParent = this;
            form.Show();
        }

        private void doktorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoktorBul form = new DoktorBul();
            form.MdiParent = this;
            form.Show();
        }

        private void hastaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HastaBul form = new HastaBul();
            form.MdiParent = this;
            form.Show();
        }

        private void uygulamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UygulamaBul form = new UygulamaBul();
            form.MdiParent = this;
            form.Show();
        }
    }
}
