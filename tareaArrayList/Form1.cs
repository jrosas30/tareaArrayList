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
            datos.Add(txtRut.Text);
            datos.Add(txtNombre.Text);
            notas[0] = int.Parse(txtNota1.Text);
            notas[1] = int.Parse(txtNota2.Text);
            notas[2] = int.Parse(txtNota3.Text);
            notas[3] = int.Parse(txtNota4.Text);
            datos.Add(notas);

            string salida = "";
            int[] aux = new int[4];
            for(int i = 0; i < datos.Count; i++)
            {
                if(i == 2)
                {
                    aux = (int[]) datos[2];
                    for(int j = 0; j < 4; j++)
                    {
                        salida += aux[j].ToString() + "\n";
                    }
                }
                else
                {
                    salida += datos[i].ToString() + "\n";
                }
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
