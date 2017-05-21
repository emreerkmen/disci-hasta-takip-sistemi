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
    public partial class HastaGörüntüle : Form
    {
        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        public HastaGörüntüle()
        {
            InitializeComponent();
        }

        private void HastaGörüntüle_Load(object sender, EventArgs e)
        {
            hastaBindingSource.DataSource = from Hasta in database.Hastas orderby Hasta.idHasta select Hasta;

            database.Log = Console.Out;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    hastaBindingSource.DataSource = from Hasta in database.Hastas orderby Hasta.idHasta select Hasta;
                    break;
                case 1:
                    hastaBindingSource.DataSource = from Hasta in database.Hastas orderby Hasta.Hasta_isim select Hasta;
                    break;
                case 2:
                    hastaBindingSource.DataSource = from Hasta in database.Hastas orderby Hasta.Hasta_soyİsim select Hasta;
                    break;
                case 3:
                    hastaBindingSource.DataSource = from Hasta in database.Hastas orderby Hasta.Hasta_telefon select Hasta;
                    break;
            }

            hastaBindingSource.MoveFirst();
        }

        private void hastaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
