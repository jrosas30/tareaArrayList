using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList datos = new ArrayList();
        int[] notas = new int[4];

        private void button1_Click(object sender, EventArgs e)
        {
            datos.Add(txtRut);
            datos.Add(txtNombre);
            datos.Add(int.Parse(txtNota.Text));

            string salida = "";
            for(int i = 0; i < datos.Count; i++)
            {
                salida += datos[i].ToString();
            }
            lblResultado.Text = salida;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
