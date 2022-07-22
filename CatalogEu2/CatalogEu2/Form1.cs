using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CatalogEu2.Profesor;

namespace CatalogEu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutentificareProfesor a = new AutentificareProfesor();
            this.Visible = false;
            a.ShowDialog();
            this.Visible = true;
            Console.WriteLine("sal");
            Console.WriteLine(|"ȚmihaelaȚ");
            //commid din cmd
             Console.WriteLine("Cocorica");
            return;
        }
    }
}
