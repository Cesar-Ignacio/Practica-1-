using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Trabajo_Practico_N_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /**FUNCIONES CREADAS*/
        
        private bool RecorrecList1(string nombre)
        {
            for(int x=0;x<listBox1.Items.Count;x++)
            {
                if(listBox1.Items[x].ToString().ToUpper()==nombre.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        private void Existenombre(string nombre)
        {   
            bool val =RecorrecList1(nombre);//recorre lista y devuelve true si se encontro false si no existe.
            if(!val)
            {
                listBox1.Items.Add(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nombre));
            }
            else
            {
                MessageBox.Show("EL NOMBRE YA EXISTE", "ATENCIÓN");
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
                Existenombre(textBox1.Text.Trim());
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
            if (listBox1.Items.Count != 0)///Pregunta si hay items en lista 1
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

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                if (e.KeyChar == 32)
                {
                    MessageBox.Show("No");
                    e.Handled = true;
                }
            }
        }
    }
}
