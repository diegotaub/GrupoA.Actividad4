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
            
            
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            lblBienvenido.Text = $"Bienvenido, {A.Nombre}";
            lblRegistro.Text = $"Registro: {A.Registro}";
            lblRanking.Text = $"Ranking: {A.Ranking}";
            lblPromedio.Text = $"Promedio: {A.Promedio}";
            lblCarrera.Text = $"Carrera: {C.NombreCarrera}";
            lblMateriasAprobadas.Text = $"Materias Aprobadas: {A.MateriasAprobadas.Count}/{C.CantidadMaterias} ({Math.Round(Convert.ToDouble(A.MateriasAprobadas.Count) / Convert.ToDouble(C.CantidadMaterias)*100, 2)}%)";
            foreach (string materia in A.MateriasAprobadas)
            {
                foreach(KeyValuePair<string, string> claveValor in C.DiccionarioDeMaterias)
                {
                    if(materia == claveValor.Key)
                    {
                        lbMateriasAprobadas.Items.Add(claveValor.Value);
                    }
                }
            }
        }


        private void btnInscripciones_Click(object sender, EventArgs e)

        {

            Alumno A = new Alumno();
            string error = "";

            // si ya confirmé la declaración jurada, me lleva directamente a la notificación de la misma
            Inscripcion I = new Inscripcion();
            if (I.VerificarInscripcion() && A.EsRegular)
            {
                this.Hide();
                FormDeclaracionJurada Form = new FormDeclaracionJurada();
                Form.Show();
            }
            else
            {

                if (!A.EsRegular)
                {
                    error += $"Debés ser un alumno regular para ingresar a la inscripción\n";

                }
                if (!I.VerificarInscripcion())
                {
                    error += $"La inscripción no está disponible en este momento\n Fecha de inicio: {I.FechaInicio:d}\n Fecha de fin: {I.FechaFin:d}\n";

                }

                MessageBox.Show(error, "Error");

            }

            
            
            
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

        private void lbMateriasAprobadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
