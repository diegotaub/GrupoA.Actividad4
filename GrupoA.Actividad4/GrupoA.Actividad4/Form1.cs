using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Actividad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInscripciones_Click(object sender, EventArgs e)
        {

            //Validar alumno regular
            //Validar que la fecha esté dentro del rango habilitado para inscripción
            // si ya confirmé la declaración jurada, me lleva directamente a la notificación de la misma

            this.Hide();
            FormDeclaracionJurada Form = new FormDeclaracionJurada();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
