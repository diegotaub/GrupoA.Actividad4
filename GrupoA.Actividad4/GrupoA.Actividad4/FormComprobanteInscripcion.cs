using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GrupoA.Actividad4
{
    public partial class FormComprobanteInscripcion : Form
    {
        public FormComprobanteInscripcion()
        {
            InitializeComponent();


            //traer de ultimo registro 
            //lblCodigoInscripcion.Text = "Código de inscripción: " + codigo.ToString("00000");

            string confirmacionMaterias = "";


            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria1", "cbPrimera1", "cbAlternativa1") ;
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria2", "cbPrimera2", "cbAlternativa2") ;
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria3", "cbPrimera3", "cbAlternativa3") ;
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria4", "cbPrimera4", "cbAlternativa4") ;



            string lastLine = File.ReadLines($@"{Environment.CurrentDirectory}\inscripciones.txt").Last();

            lblCodigoInscripcion.Text = "Código de inscripción: " + lastLine.Split('|')[0];

            txtComprobanteInscripcion.Text = (confirmacionMaterias);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
