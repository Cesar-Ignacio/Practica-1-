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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //funciones mias

        private string PrimMay(string nombApell)///Convierte la primera letra en mayuscula
        {
            string nom;
            nom = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nombApell);
            return nom;
        }

        private int ValidacionNomApll()///0 =iguales 1=distintos
        {
            string nom = textBox1.Text.ToUpper();
            string apell = textBox2.Text.ToUpper();
            if(nom==apell)
            {
                return 0;
            }
            return 1;
        }

        private int ExisteNomApll()///0= si existe el nombre 1=no existe el nombre en la lista
        {
            foreach (string NomA in listBox1.Items)
            {
                ///Cargamos en un string lo contenido los textbox, con un espacio como esta en el lisbox.
                string nomA;
                nomA = textBox1.Text;
                nomA +=" " +textBox2.Text;
                if (NomA.ToUpper() == nomA.ToUpper())
                {
                    return 0;
                }
            }

            return 1;
        }

        private void CopiaEnList()///Copiamos el nombre y apellido en lista
        {
            string nombApell;
            ///Convertimos la primera letra en mayuscula(PrimMay(string)) y lo agremos al lista
            nombApell = PrimMay(textBox1.Text);
            nombApell += " " + PrimMay(textBox2.Text);
            listBox1.Items.Add(nombApell);
        }


        //VA
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Fmenu = new Form1();
            Fmenu.Show();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
          if(textBox1.Text.Trim()!=string.Empty && textBox2.Text.Trim()!=string.Empty)
            {
           
                if (ValidacionNomApll() != 0)///Verificamos si son distintos
                    {
                        if(ExisteNomApll()!=0)///Verifica que el nombre no exista en lista
                            {
                            CopiaEnList();
                            }
                        else  
                            {
                            MessageBox.Show("EL NOMBRE YA EXISTE", "ATENCIÓN");
                            }
                    
                       

                    }
                else
                    {
                    MessageBox.Show("EL NOMBRE Y APELLIDO IGULES", "ATENCION");
                    }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();

            }
          else
            {
                ///SE MOSTRAR EL SIGUIENTE MENSAJE SI FALTA COMPLETAR (NOMBRE O APELLIDO)
                MessageBox.Show("DEBE COMPLETAR EL NOMBRE Y EL APELLIDO", "ATECNIÓN");
            }
         


        }

        private void btbirrar_Click(object sender, EventArgs e)
        {
           
            if(listBox1.SelectedItems.Count>0)
            {
                foreach(int indice in listBox1.SelectedIndices)
                {
                    listBox1.Items.RemoveAt(indice);
                }
            }
            else
            {
                MessageBox.Show("NO SE LECCIONO NINGUN NOMBRE", "ATENCIÓN");
            }
        }
    }
}
