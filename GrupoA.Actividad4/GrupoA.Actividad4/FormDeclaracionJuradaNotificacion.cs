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
    public partial class FormDeclaracionJuradaNotificacion : Form
    {
        public FormDeclaracionJuradaNotificacion()
        {
            InitializeComponent();
            Alumno A = new Alumno();
            if (A.CuatroUltimas)
            {
                lblMarcoCuatroUltimas.Text = "Marcó que se encuentra en las cuatro últimas materias";
            }
            else
            {
                lblMarcoCuatroUltimas.Text = "No se encuentra en las cuatro últimas materias";
            }

            foreach(string materia in A.MateriasAprobadasDJ)
            {
                lbNotificacionDJ.Items.Add(materia + " - Aprobada");
            }

            Carrera C = new Carrera(A.Carrera);

            foreach (string materia in A.MateriasRegularizadas)
            {

                lbNotificacionDJ.Items.Add(C.DiccionarioDeMaterias[materia] + " - Regularizada");
            }

            if(A.MateriasAprobadasDJ.Count == 0 && A.MateriasRegularizadas.Count == 0)
            {
                lbNotificacionDJ.Items.Add("No marcó ninguna aprobada/regularizada");
            }
        }

        private void btnAtrasNotificacionDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void btnContinuarNotificacionDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeleccionMaterias Form = new FormSeleccionMaterias();
            Form.Show();
        }
    }
}
