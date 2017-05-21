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
    public partial class UygulamaGüncelle : Form
    {
        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        public UygulamaGüncelle()
        {
            InitializeComponent();
        }

        private void UygulamaGüncelle_Load(object sender, EventArgs e)
        {
            uygulamaBindingSource.DataSource = from Uygulama in database.Uygulamas orderby Uygulama.Uygulama_idDoktor select Uygulama;

            database.Log = Console.Out;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    uygulamaBindingSource.DataSource = from Uygulama in database.Uygulamas orderby Uygulama.Uygulama_idDoktor select Uygulama;
                    break;
                case 1:
                    uygulamaBindingSource.DataSource = from Uygulama in database.Uygulamas orderby Uygulama.Uygulama_idHasta select Uygulama;
                    break;
                
            }

            uygulamaBindingSource.MoveFirst();
        }

        private void uygulamaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            uygulamaBindingSource.EndEdit();
            database.SubmitChanges();
        }
    }
}
