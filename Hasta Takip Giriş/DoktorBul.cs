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
    public partial class DoktorBul : Form
    {
        public DoktorBul()
        {
            InitializeComponent();
        }

        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        private void RefreshContast()
        {
            doktorBindingSource.DataSource = from Doktor in database.Doktors
                                             orderby Doktor.Doktor_isim, Doktor.Doktor_soyİsim
                                             select Doktor;

            doktorBindingSource.MoveFirst();
            textBox1.Clear();
        }

        private void DoktorBul_Load(object sender, EventArgs e)
        {
            RefreshContast();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorBindingSource.DataSource = from Doktor in database.Doktors
                                             where Doktor.Doktor_isim.StartsWith(textBox1.Text)
                                             orderby Doktor.Doktor_isim, Doktor.Doktor_soyİsim
                                             select Doktor;
            doktorBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshContast();
        }
    }
}
