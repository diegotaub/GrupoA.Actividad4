using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupoA.Actividad4
{
    class Curso
    {
        
        public Curso(string codigoCurso, string codigoMateria, List<string> listaAlumnos, string tipo)
        {
            List<string> AlumnosInscriptos = new List<string>();
            CodigoCurso = codigoCurso;
            CodigoMateria = codigoMateria;
            AlumnosInscriptos = listaAlumnos;
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
                    Curso C = new Curso(curso.Split('|')[0], curso.Split('|')[1], curso.Split('|')[2].Split(',').ToList(), curso.Split('|')[3]);
                    ListaDeCursos.Add(C);
                }
            }

            return ListaDeCursos;
        }

    }
}
