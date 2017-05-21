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
    public partial class UygulamaBul : Form
    {
        public UygulamaBul()
        {
            InitializeComponent();
        }

        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        private void RefreshContast()
        {
            uygulamaBindingSource.DataSource = from Uygulama in database.Uygulamas
                                               orderby Uygulama.Uygulama_idDoktor, Uygulama.Uygulama_idHasta
                                               select Uygulama;

            uygulamaBindingSource.MoveFirst();
        }


        private void UygulamaBul_Load(object sender, EventArgs e)
        {
            RefreshContast();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uygulamaBindingSource.DataSource = from Uygulama in database.Uygulamas
                                               where Uygulama.Uygulama_tarihSaat.Equals(dateTimePicker1)
                                               orderby Uygulama.Uygulama_idDoktor, Uygulama.Uygulama_idHasta
                                               select Uygulama;
            uygulamaBindingSource.MoveFirst();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
