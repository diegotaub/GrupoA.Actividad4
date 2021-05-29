using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Actividad4
{
    public class Alumno
    {

        public Alumno()
        {
            MateriasAprobadas = new List<string>();
            ListaNotas = new List<short>();
            ListaCuatrimestres = new List<int>();

            foreach (string alumno in File.ReadAllLines($@"{Environment.CurrentDirectory}\alumno.txt").Skip(1))
            {
                Nombre = alumno.Split('|')[0];
                Apellido = alumno.Split('|')[1];
                Registro = long.Parse(alumno.Split('|')[2]);
                Ranking = double.Parse(alumno.Split('|')[3]);
                Carrera = alumno.Split('|')[4];
                EsRegular = bool.Parse(alumno.Split('|')[5]);
                ConfirmoInscripcion = bool.Parse(alumno.Split('|')[6]);
                ConfirmoDJ = bool.Parse(alumno.Split('|')[7]);
                
            }

            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\materias_aprobadas.txt").Skip(1))
            {
                if(long.Parse(materia.Split('|')[0]) == Registro)
                {
                    MateriasAprobadas.Add(materia.Split('|')[1]);
                    ListaNotas.Add(short.Parse(materia.Split('|')[2]));
                    ListaCuatrimestres.Add(int.Parse(materia.Split('|')[3]));
                }
                
            }

            foreach(int nota in ListaNotas)
            {
                Promedio += nota;
            }

            Promedio = Promedio / ListaNotas.Count();

            foreach(string carrera in File.ReadAllLines($@"{Environment.CurrentDirectory}\carreras.txt").Skip(1))
            {
                if(Carrera == carrera.Split('|')[0])
                {
                    Carrera C = new Carrera(carrera.Split('|')[0]);
                }
            }




        }

        public string Nombre { get; }
        public string Apellido { get; }
        public long Registro { get; }
        public double Ranking { get; }
        public string Carrera { get; }
       
        public double Promedio { get; }
        public List<short> ListaNotas { get; }
        public List<int> ListaCuatrimestres { get; }

        public List<string> MateriasAprobadas {get; set;}

        public bool EsRegular { get; }
        public bool ConfirmoInscripcion { get; set; }
        public bool ConfirmoDJ { get; set; }


       
    }
}
