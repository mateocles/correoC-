using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GoEmail;
namespace demo_GoEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Almacenar las variables necesarias
            string Destino = textBox1.Text;
            string Asunto = textBox2.Text;
            string Mensaje = textBox3.Text;
            string NombreEmisor = textBox4.Text;
            string CorreoEmisor = textBox5.Text;
            string ClaveEmisor = textBox6.Text;
            //Nueva utilidad, variable para indicar si el correo se envia como html
            bool html = comboBox1.SelectedIndex == 0 ? true : false;
            //Instanciar la librería GoEmail
            GoEmailv2 x = new GoEmailv2();
            //Pasar los parámetros al método Enviar
            //La funcion devuelve BOOL si se envió correctamente
            //Por eso la colocaremos en un IF

            if (x.Enviar(Destino, Asunto, Mensaje, NombreEmisor, CorreoEmisor, ClaveEmisor, html))
            {
                //Notificamos OK
                MessageBox.Show("Enviado correctamente");
            }
            else
            {
                //Notificamos ERROR
                MessageBox.Show("Error: " + GoEmailv2.error);
            }
            //AHORA PODEMOS ENVIAR CORREOS EN FORMATEADOS EN HTML, RECUERDEN:
            //-USAR RUTAS DE IMAGENES EXTERNAS, ej. http://www.imagenes.com/imagen1.jpg
            //-APLICAR ESTILOS CSS  EN LAS ETIQUETAS, ej. <p style='color=red'>Hola</p>
        }
    }
}
