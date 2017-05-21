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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanıcı.Text == "Admin" && sifre.Text == "123456") 
            {
                Admin form1 = new Admin();
                form1.Show();
                
            }

            if (kullanıcı.Text == "User" && sifre.Text == "123456") 
            {
                User form2 = new User();
                form2.Show();
            }
        }

    }
}
