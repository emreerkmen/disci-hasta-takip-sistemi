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
    public partial class HastaBul : Form
    {
        public HastaBul()
        {
            InitializeComponent();
        }
        
        private DisciHastaLinqDataContext database = new DisciHastaLinqDataContext();

        private void RefreshContast()
        {
            hastaBindingSource.DataSource = from Hasta in database.Hastas
                                            orderby Hasta.Hasta_isim, Hasta.Hasta_soyİsim
                                            select Hasta;

            hastaBindingSource.MoveFirst();
            textBox1.Clear();
        }


        private void HastaBul_Load(object sender, EventArgs e)
        {
            RefreshContast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastaBindingSource.DataSource = from Hasta in database.Hastas
                                            where Hasta.Hasta_isim.StartsWith(textBox1.Text)
                                            orderby Hasta.Hasta_isim, Hasta.Hasta_soyİsim
                                            select Hasta;
            hastaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshContast();
        }
    }
}
