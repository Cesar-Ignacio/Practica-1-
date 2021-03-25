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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /**FUNCIONES CREADAS*/
        private void Existenombre(string nombre)
        {   

            int val = listBox1.FindStringExact(nombre);
            if(val!=0)
            {
                listBox1.Items.Add(nombre);
            }
        }

        private void ExistenombreL2(string nombre)
        {
            int val = listBox2.FindStringExact(nombre);
            if(val!=0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("EL NOMBRE YA EXISTE ", "ATENCIÓN");
            }
        }

        private int ValidarDupli(string nom)/*Devolvera 0 si son iguales -1 si son distintos*/
        {
            foreach(string nombre in listBox2.Items)
            {
                if(nombre==nom)
                {
                    return 0;
                }
            }
            return -1;
        }
         

        /**VA*/
        private void button1_Click(object sender, EventArgs e)///boton agregar
        {
            if(textBox1.Text.Trim()!=string.Empty)
            {
                Existenombre(textBox1.Text);
            }
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btuno_Click(object sender, EventArgs e)
        {
            
            if(listBox1.SelectedIndex!=-1)
            {
                ExistenombreL2(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("SELECCIONE UN NOMBRE", "ATENCIÓN");
            }
            textBox1.Focus();
        }

        private void bttodos_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
               foreach(string nom in listBox1.Items)
                {
                    int val = ValidarDupli(nom);
                    if(val!=0)
                    {
                        listBox2.Items.Add(nom);
                    }
                }
                listBox1.Items.Clear();/*Limpiamos los items de la lista uno*/
            }
            else
            {
                MessageBox.Show("No existen nombres", "ATENCIÓN");
                
            }

           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fmenu = new Form1();
            fmenu.Show();
        }
    }
}
