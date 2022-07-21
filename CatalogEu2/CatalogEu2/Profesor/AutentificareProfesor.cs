using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CatalogEu2.DbTools;

namespace CatalogEu2.Profesor
{
    public partial class AutentificareProfesor : Form
    {
        public static string CNPProfLogat;   //o accesez FormProfesor.CNPProfLogat

        public AutentificareProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string parola = textBox2.Text;
            
            Logare l = new Logare();
            CNPProfLogat = l.logareCont(3, email, parola);
            if (String.Compare(CNPProfLogat, "0") != 0)
            {
                this.Hide();
                AnSemestru ss = new AnSemestru();
                ss.Show();
            }
        }
    }
}
