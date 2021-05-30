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
    public partial class FormSeleccionMaterias : Form
    {
        public FormSeleccionMaterias()
        {
            InitializeComponent();
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            C.CargarCorrelativas(A.Carrera);
            txtCarrera1.Text = C.NombreCarrera;
            txtCarrera2.Text = C.NombreCarrera;
            txtCarrera3.Text = C.NombreCarrera;
            txtCarrera4.Text = C.NombreCarrera;

            foreach (KeyValuePair<string, string> materias in C.DiccionarioDeMaterias)
            {

                

                 bool NoPuedeCursar = C.DiccionarioDeCorrelativas[materias.Key].Except(A.MateriasAprobadas).Any();

                if (A.MateriasAprobadas.Contains(materias.Key))
                {
                    continue;
                }else if (A.MateriasRegularizadas.Contains(materias.Key))
                {
                    cbMateria1.Items.Add(materias.Value);
                    cbMateria2.Items.Add(materias.Value);
                    cbMateria3.Items.Add(materias.Value);
                    cbMateria4.Items.Add(materias.Value);
                }
                else if(C.DiccionarioDeCorrelativas[materias.Key].Count == 1 && C.DiccionarioDeCorrelativas[materias.Key][0] == "")
                {
                    cbMateria1.Items.Add(materias.Value);
                    cbMateria2.Items.Add(materias.Value);
                    cbMateria3.Items.Add(materias.Value);
                    cbMateria4.Items.Add(materias.Value);
                }
                else if(!NoPuedeCursar)
                {
                    cbMateria1.Items.Add(materias.Value);
                    cbMateria2.Items.Add(materias.Value);
                    cbMateria3.Items.Add(materias.Value);
                    cbMateria4.Items.Add(materias.Value);
                }
                
            }

            
        }

        private void btnAtrasSeleccionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeclaracionJuradaNotificacion Form = new FormDeclaracionJuradaNotificacion();
            Form.Show();
        }

        private void btnAceptarSeleccionMaterias_Click(object sender, EventArgs e)
        {

            if(
                (cbMateria1.Text != "" && cbMateria1.Text == cbMateria2.Text) ||
                (cbMateria1.Text != "" && cbMateria1.Text == cbMateria3.Text) ||
                (cbMateria1.Text != "" && cbMateria1.Text == cbMateria4.Text) ||
                (cbMateria2.Text != "" && cbMateria1.Text == cbMateria3.Text) ||
                (cbMateria2.Text != "" && cbMateria1.Text == cbMateria4.Text) ||
                (cbMateria3.Text != "" && cbMateria1.Text == cbMateria4.Text) 
                )
            {
                MessageBox.Show("No puede inscribirse más de una vez en la misma materia", "Error");
            }
            else
            {
                this.Hide();
                FormConfirmacionMaterias Form = new FormConfirmacionMaterias();
                Form.Show();
            }
            
        }
    }
}
