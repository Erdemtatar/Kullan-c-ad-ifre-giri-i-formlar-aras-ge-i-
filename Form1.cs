using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_adı_şifre_girişi_formlar_arası_geçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Tatar_1071" && textBox2.Text == "05436194835cepE")
            {
                Form2 yeni=new Form2();
                yeni.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı Kullanıcı Girişi"); };
        }
    }
}
