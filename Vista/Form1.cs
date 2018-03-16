using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validador va = new Validador();
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;

            int val = 0;
            int inval = 0;

            if (va.esEntero(a)==true)
            {
                val++;
            }
            else
            {
                inval++;
            }
            if (va.esDecimal(b) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }

            if (va.esEdad(c) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }



            MessageBox.Show("Valuidos:\t" + val +"\nIvalidos:\t" + inval);
            
        }
    }
}
