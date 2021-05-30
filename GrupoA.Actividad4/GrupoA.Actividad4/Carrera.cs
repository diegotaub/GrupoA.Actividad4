using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupoA.Actividad4
{
    class Carrera
    {


        public Carrera(string codigoCarrera)
        {
            foreach (string carrera in File.ReadAllLines($@"{Environment.CurrentDirectory}\carreras.txt").Skip(1))
            {
                if (codigoCarrera == carrera.Split('|')[0])
                {
                    CodigoCarrera = carrera.Split('|')[0];
                    NombreCarrera = carrera.Split('|')[1];
                    CantidadMaterias = int.Parse(carrera.Split('|')[2]);
                    DiccionarioDeMaterias = new Dictionary<string, string>();
                    DiccionarioDeCorrelativas = new Dictionary<string, List<string>>();
                }
            }

            DiccionarioDeMaterias = CargarMaterias(codigoCarrera);
            
        }

        public Dictionary<string, string> CargarMaterias(string codigoCarrera)
        {
            string nombreArchivo = "";
            switch (codigoCarrera)
            {
                case "1":
                    nombreArchivo = "materias_contador.txt";
                    break;
                case "2":
                    nombreArchivo = "materias_administracion.txt";
                    break;
                case "3":
                    nombreArchivo = "materias_economia.txt";
                    break;
                case "4":
                    nombreArchivo = "materias_sistemas.txt";
                    break;
                case "5":
                    nombreArchivo = "materias_actuario.txt";
                    break;

            }

            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\{nombreArchivo}").Skip(1))
            {

                DiccionarioDeMaterias.Add(materia.Split('|')[0], materia.Split('|')[1]);
                    
            }

            return DiccionarioDeMaterias;
        }

        public Dictionary<string, List<string>> CargarCorrelativas(string codigoCarrera)
        {
            string nombreArchivo = "";
            switch (codigoCarrera)
            {
                case "1":
                    nombreArchivo = "materias_contador.txt";
                    break;
                case "2":
                    nombreArchivo = "materias_administracion.txt";
                    break;
                case "3":
                    nombreArchivo = "materias_economia.txt";
                    break;
                case "4":
                    nombreArchivo = "materias_sistemas.txt";
                    break;
                case "5":
                    nombreArchivo = "materias_actuario.txt";
                    break;

            }

            List<string> correlativas = new List<string>();

            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\{nombreArchivo}").Skip(1))
            {

                 correlativas = materia.Split('|')[2].Split(',').ToList();

                DiccionarioDeCorrelativas.Add(materia.Split('|')[0], correlativas);

            }
            return DiccionarioDeCorrelativas;
        }




        public string CodigoCarrera { get; }
        public string NombreCarrera { get; }
        public int CantidadMaterias { get; }
        public Dictionary<string, string> DiccionarioDeMaterias { get; }
        public Dictionary<string, List<string>> DiccionarioDeCorrelativas { get; }
    }
}
