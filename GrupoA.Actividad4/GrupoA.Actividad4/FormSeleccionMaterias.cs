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
            cbPrimera1.Enabled = false;
            cbPrimera2.Enabled = false;
            cbPrimera3.Enabled = false;
            cbPrimera4.Enabled = false;  
            cbAlternativa1.Enabled = false;
            cbAlternativa2.Enabled = false;
            cbAlternativa3.Enabled = false;
            cbAlternativa4.Enabled = false;
            btnAceptarSeleccionMaterias.Enabled = false;
            

            foreach (KeyValuePair<string, string> materias in C.DiccionarioDeMaterias)
            {

                bool NoPuedeCursar;

                 

                if (A.CuatroUltimas)
                {
                    NoPuedeCursar = false;
                }
                else
                {
                    NoPuedeCursar = C.DiccionarioDeCorrelativas[materias.Key].Except(A.MateriasAprobadas).Any();
                   
                }

                if (A.MateriasAprobadas.Contains(materias.Key) || A.MateriasAprobadasDJ.Contains(materias.Key))
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

            
            cbPrimera2.Items.Add(Curso.CargarCursos(cbMateria2.Text, "P"));
            cbPrimera3.Items.Add(Curso.CargarCursos(cbMateria3.Text, "P"));
            
            cbAlternativa2.Items.Add(Curso.CargarCursos(cbMateria2.Text, "P"));
            cbAlternativa3.Items.Add(Curso.CargarCursos(cbMateria3.Text, "P"));
            cbPrimera4.Items.Add(Curso.CargarCursos(cbMateria4.Text, "V"));
            cbAlternativa4.Items.Add(Curso.CargarCursos(cbMateria4.Text, "V"));




        }

        private void btnAtrasSeleccionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeclaracionJuradaNotificacion Form = new FormDeclaracionJuradaNotificacion();
            Form.Show();
        }

        private void btnAceptarSeleccionMaterias_Click(object sender, EventArgs e)
        {

            string error = "";



            if((cbPrimera1.SelectedIndex == -1 && cbAlternativa1.SelectedIndex != -1) ||
                (cbPrimera2.SelectedIndex == -1 && cbAlternativa2.SelectedIndex != -1) ||
                (cbPrimera3.SelectedIndex == -1 && cbAlternativa3.SelectedIndex != -1) ||
                (cbPrimera4.SelectedIndex == -1 && cbAlternativa4.SelectedIndex != -1))
            {
                error += "No puede elegir un curso alternativo sin elegir la primera opción\n";
            }

            if(
                (cbMateria1.SelectedIndex != -1 && cbMateria1.Text == cbMateria2.Text) ||
                (cbMateria1.SelectedIndex != -1 && cbMateria1.Text == cbMateria3.Text) ||
                (cbMateria1.SelectedIndex != -1 && cbMateria1.Text == cbMateria4.Text) ||
                (cbMateria2.SelectedIndex != -1 && cbMateria2.Text == cbMateria3.Text) ||
                (cbMateria2.SelectedIndex != -1 && cbMateria2.Text == cbMateria4.Text) ||
                (cbMateria3.SelectedIndex != -1 && cbMateria3.Text == cbMateria4.Text) 
                )
            {
                error += "No puede inscribirse más de una vez en la misma materia\n";
            }

            if((cbMateria1.SelectedIndex != -1 && cbPrimera1.SelectedIndex == -1 && cbAlternativa1.SelectedIndex == -1)||
                (cbMateria2.SelectedIndex != -1 && cbPrimera2.SelectedIndex == -1 && cbAlternativa2.SelectedIndex == -1)||
                (cbMateria3.SelectedIndex != -1 && cbPrimera3.SelectedIndex == -1 && cbAlternativa3.SelectedIndex == -1) ||
                (cbMateria4.SelectedIndex != -1 && cbPrimera4.SelectedIndex == -1 && cbAlternativa4.SelectedIndex == -1))
            {
                error += "Debe seleccionar al menos un curso para las materias seleccionadas\n";
            }

            if (error == "")
            {

               


                this.Hide();
                FormConfirmacionMaterias Form = new FormConfirmacionMaterias();
                Form.Show();
            }
            else
            {
                MessageBox.Show(error, "Error");
            }
            
        }

        private void cbMateria1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrimera1.Items.Clear();
            cbAlternativa1.Items.Clear();
            cbPrimera1.Text = "";
            cbAlternativa1.Text = "";
            cbPrimera1.Enabled = true;
            cbAlternativa1.Enabled = true;
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            string CodigoMateria = "";

            foreach(KeyValuePair<string, string> materia in C.DiccionarioDeMaterias)
            {
                if(cbMateria1.Text == materia.Value)
                {
                    CodigoMateria = materia.Key;
                }
            }

            foreach(Curso curso in Curso.CargarCursos(CodigoMateria, "P"))
            {
                cbPrimera1.Items.Add(curso.CodigoCurso);
                cbAlternativa1.Items.Add(curso.CodigoCurso);
            }
            
        }

        private void cbMateria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrimera2.Items.Clear();
            cbAlternativa2.Items.Clear();
            cbPrimera2.Text = "";
            cbAlternativa2.Text = "";
            cbPrimera2.Enabled = true;
            cbAlternativa2.Enabled = true;
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            string CodigoMateria = "";

            foreach (KeyValuePair<string, string> materia in C.DiccionarioDeMaterias)
            {
                if (cbMateria2.Text == materia.Value)
                {
                    CodigoMateria = materia.Key;
                }
            }

            foreach (Curso curso in Curso.CargarCursos(CodigoMateria, "P"))
            {
                cbPrimera2.Items.Add(curso.CodigoCurso);
                cbAlternativa2.Items.Add(curso.CodigoCurso);
            }
        }

        private void cbMateria3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrimera3.Items.Clear();
            cbAlternativa3.Items.Clear();
            cbPrimera3.Text = "";
            cbAlternativa3.Text = "";
            cbPrimera3.Enabled = true;
            cbAlternativa3.Enabled = true;
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            string CodigoMateria = "";

            foreach (KeyValuePair<string, string> materia in C.DiccionarioDeMaterias)
            {
                if (cbMateria3.Text == materia.Value)
                {
                    CodigoMateria = materia.Key;
                }
            }

            foreach (Curso curso in Curso.CargarCursos(CodigoMateria, "P"))
            {
                cbPrimera3.Items.Add(curso.CodigoCurso);
                cbAlternativa3.Items.Add(curso.CodigoCurso);
            }
        }

        private void cbMateria4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrimera4.Items.Clear();
            cbAlternativa4.Items.Clear();
            cbPrimera4.Text = "";
            cbAlternativa4.Text = "";
            cbPrimera4.Enabled = true;
            cbAlternativa4.Enabled = true;
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            string CodigoMateria = "";

            if(cbMateria4.Text != "")
            {
                foreach (KeyValuePair<string, string> materia in C.DiccionarioDeMaterias)
                {
                    if (cbMateria4.Text == materia.Value)
                    {
                        CodigoMateria = materia.Key;
                    }
                }

                foreach (Curso curso in Curso.CargarCursos(CodigoMateria, "V"))
                {
                    cbPrimera4.Items.Add(curso.CodigoCurso);
                    cbAlternativa4.Items.Add(curso.CodigoCurso);
                }
            }
            
        }

        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            cbMateria1.SelectedIndex = -1;
            cbMateria2.SelectedIndex = -1;
            cbMateria3.SelectedIndex = -1;
            cbMateria4.SelectedIndex = -1;
            cbPrimera1.SelectedIndex = -1;
            cbPrimera2.SelectedIndex = -1;
            cbPrimera3.SelectedIndex = -1;
            cbPrimera4.SelectedIndex = -1;
            cbAlternativa1.SelectedIndex = -1;
            cbAlternativa2.SelectedIndex = -1;
            cbAlternativa3.SelectedIndex = -1;
            cbAlternativa4.SelectedIndex = -1;

            cbPrimera1.Enabled = false;
            cbPrimera2.Enabled = false;
            cbPrimera3.Enabled = false;
            cbPrimera4.Enabled = false;
            cbAlternativa1.Enabled = false;
            cbAlternativa2.Enabled = false;
            cbAlternativa3.Enabled = false;
            cbAlternativa4.Enabled = false;
            btnAceptarSeleccionMaterias.Enabled = false;

        }

        private void cbPrimera1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPrimera1.SelectedIndex != -1)
            {
                btnAceptarSeleccionMaterias.Enabled = true;
            }
        }

        private void cbPrimera2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrimera2.SelectedIndex != -1)
            {
                btnAceptarSeleccionMaterias.Enabled = true;
            }
        }

        private void cbPrimera3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrimera3.SelectedIndex != -1)
            {
                btnAceptarSeleccionMaterias.Enabled = true;
            }
        }

        private void cbPrimera4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrimera4.SelectedIndex != -1)
            {
                btnAceptarSeleccionMaterias.Enabled = true;
            }
        }
    }
}
