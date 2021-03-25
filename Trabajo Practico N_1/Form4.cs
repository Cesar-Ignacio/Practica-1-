using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_N_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            string contenido;

            contenido = "SEXO:" + (string)(rbfemen.Checked ? "FEMENINO" : "Masculino") + "\r\n";
            contenido += "ESTADO CIVIL:" + (string)(rbcasda.Checked ? "CASADX" : "SOLTERX") + "\r\n";
            contenido += "TRABAJO:" + "\r\n";
            foreach(int indice in checkedListBox1.CheckedIndices)
            {
                contenido +="-"+checkedListBox1.Items[indice].ToString()+"\r\n";
            }

            label1.Text = contenido;

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fmunu = new Form1();
            fmunu.Show();
        }
    }
}
