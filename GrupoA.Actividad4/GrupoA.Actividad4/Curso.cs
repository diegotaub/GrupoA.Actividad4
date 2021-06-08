using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace GrupoA.Actividad4
{
    class Curso
    {
        
        public Curso(string codigoCurso, string codigoMateria, string tipo)
        {
            List<string> AlumnosInscriptos = new List<string>();
            CodigoCurso = codigoCurso;
            CodigoMateria = codigoMateria;
            Tipo = tipo;


        }

        public string CodigoMateria { get; set; }
        public string CodigoCurso { get; set; }
        public string Tipo { get; set; }
        public List<string> AlumnosInscriptos { get; set; }

        static public List<Curso> CargarCursos(string codigoMateria, string tipo)
        {

            List<Curso> ListaDeCursos = new List<Curso>();

            foreach (string curso in File.ReadAllLines($@"{Environment.CurrentDirectory}\cursos.txt").Skip(1))
            {


                if (codigoMateria == curso.Split('|')[1] 
                    && curso.EndsWith(tipo))
                {
                    Curso C = new Curso(curso.Split('|')[0], curso.Split('|')[1], curso.Split('|')[2]);
                    ListaDeCursos.Add(C);
                }
            }

            return ListaDeCursos;
        }

        static public string PedirConfirmacionDeCursos(string materia, string curso1, string curso2)
        {
            


            ComboBox cbMateria = Application.OpenForms["FormSeleccionMaterias"].Controls[materia] as ComboBox;
            ComboBox cbPrimera = Application.OpenForms["FormSeleccionMaterias"].Controls[curso1] as ComboBox;
            ComboBox cbAlternativa = Application.OpenForms["FormSeleccionMaterias"].Controls[curso2] as ComboBox;

            string confirmacionMaterias = "";
            string tipo;

            if(materia == "cbMateria4")
            {
                tipo = "Virtual";
            }
            else
            {
                tipo = "Presencial";
            }

            if(cbMateria.SelectedIndex != -1)
            {

                confirmacionMaterias += $"{cbMateria.Text} - {tipo} | Primera opción: {cbPrimera.Text}";

                if(cbAlternativa.SelectedIndex != -1)
                {
                    confirmacionMaterias += $" | Segunda opción: {cbAlternativa.Text}";
                }
            }

            

            return confirmacionMaterias + Environment.NewLine;
        }

    }
}
