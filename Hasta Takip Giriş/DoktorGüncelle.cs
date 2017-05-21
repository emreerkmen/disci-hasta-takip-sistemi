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
    public partial class DoktorGüncelle : Form
    {
        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        public DoktorGüncelle()
        {
            InitializeComponent();
        }

        private void DoktorGüncelle_Load(object sender, EventArgs e)
        {
            doktorBindingSource.DataSource = from Doktor in database.Doktors orderby Doktor.idDoktor select Doktor;

            database.Log = Console.Out;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    doktorBindingSource.DataSource = from Doktor in database.Doktors orderby Doktor.idDoktor select Doktor;
                    break;
                case 1:
                    doktorBindingSource.DataSource = from Doktor in database.Doktors orderby Doktor.Doktor_isim select Doktor;
                    break;
                case 2:
                    doktorBindingSource.DataSource = from Doktor in database.Doktors orderby Doktor.Doktor_soyİsim select Doktor;
                    break;
                case 3:
                    doktorBindingSource.DataSource = from Doktor in database.Doktors orderby Doktor.Doktor_maas select Doktor;
                    break;

            }

            doktorBindingSource.MoveFirst();
        }

        private void doktorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            doktorBindingSource.EndEdit();
            database.SubmitChanges();
        }

        private void doktorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
