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

            /*foreach (string carrera in File.ReadAllLines($@"{Environment.CurrentDirectory}\carreras.txt").Skip(1))
            {
                if (Carrera == carrera.Split('|')[0])
                {
                    Carrera C = new Carrera(carrera.Split('|')[0]);
                }
            }*/

            MateriasAprobadas = new List<string>();
            ListaNotas = new List<short>();
            ListaCuatrimestres = new List<int>();
            MateriasAprobadasDJ = new List<string>();
            MateriasRegularizadas = new List<string>();
            MateriasDisponibles = new List<string>();
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
                CuatroUltimas = bool.Parse(alumno.Split('|')[8]);

            }

            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\condicion_materias.txt").Skip(1))
            {
                if(long.Parse(materia.Split('|')[0]) == Registro)
                {
                    if(int.Parse(materia.Split('|')[2]) != 0 && materia.Split('|')[4] == "A")
                    {
                        MateriasAprobadas.Add(materia.Split('|')[1]);
                    }
                    else if (materia.Split('|')[4] == "A")
                    {
                        //Carrera C = new Carrera(Carrera);
                        MateriasAprobadasDJ.Add(materia.Split('|')[1]);
                    } else if (materia.Split('|')[4] == "R")
                    {
                        //Carrera C = new Carrera(Carrera);
                        MateriasRegularizadas.Add(materia.Split('|')[1]);
                    }
                    
                    if(short.Parse(materia.Split('|')[2]) != 0 && materia.Split('|')[4] == "A")
                    {
                        ListaNotas.Add(short.Parse(materia.Split('|')[2]));
                    }
                    
                    ListaCuatrimestres.Add(int.Parse(materia.Split('|')[3]));
                    
                }
                
            }

            foreach(int nota in ListaNotas)
            {
                Promedio += nota;
            }

            Promedio = Promedio / ListaNotas.Count();

            

            if (!MateriasAprobadas.Contains("241") ||
                !MateriasAprobadas.Contains("242") ||
                !MateriasAprobadas.Contains("243") ||
                !MateriasAprobadas.Contains("244") ||
                !MateriasAprobadas.Contains("245") ||
                !MateriasAprobadas.Contains("246"))
            {
                AproboCBC = false;
            }
            else
            {
                AproboCBC = true;
            }

            Inscripcion I = new Inscripcion();
            MateriasCursadasCuatriAnterior = new List<string>();
            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\materias_cursadas.txt").Skip(1))
            {


                if (Registro == long.Parse(materia.Split('|')[0]))
                {
                    string cuatrimestre = materia.Split('|')[2];
                    if ((cuatrimestre.EndsWith("1") && int.Parse(cuatrimestre) == I.Cuatrimestre - 1)
                        ||
                        ((cuatrimestre.EndsWith("2")) && I.Cuatrimestre.ToString().EndsWith("1") && (int.Parse(cuatrimestre.Substring(0, 4))
                        == int.Parse(I.Cuatrimestre.ToString().Substring(0, 4)) - 1)))
                    {
                        MateriasCursadasCuatriAnterior.Add(materia.Split('|')[1]);
                    }
                }
            }

            if (!MateriasCursadasCuatriAnterior.Contains("241") &&
                !MateriasCursadasCuatriAnterior.Contains("242") &&
                !MateriasCursadasCuatriAnterior.Contains("243") &&
                !MateriasCursadasCuatriAnterior.Contains("244") &&
                !MateriasCursadasCuatriAnterior.Contains("245") &&
                !MateriasCursadasCuatriAnterior.Contains("246") &&
                MateriasCursadasCuatriAnterior.Count() > 0)
            {
                NecesitaDJ = true;
            }
            else
            {
                NecesitaDJ = false;
            }

        }

        public void GuardarAlumno()
        {

            List<string> archivotemporal = new List<string>();


            var lineas_alumno = File.ReadLines($@"{Environment.CurrentDirectory}\alumno.txt");
            foreach (var line in lineas_alumno)
            {
                archivotemporal.Add(line);
            }

            for (int i = 1; i < archivotemporal.Count; i++)
            {
                if (Registro == long.Parse(archivotemporal[i].Split('|')[2]))
                {
                    archivotemporal[i] = ($"{Nombre}|{Apellido}|{Registro}|{Ranking}|{Carrera}|{EsRegular}|{ConfirmoInscripcion}|{ConfirmoDJ}|{CuatroUltimas}");
                    break;
                }
            }

            string cuatrimestreAnterior = "";
            Inscripcion I = new Inscripcion();
            if (I.Cuatrimestre.ToString().EndsWith("2"))
            {
                 cuatrimestreAnterior = (I.Cuatrimestre - 1).ToString();
            }
            else
            {
                cuatrimestreAnterior = (int.Parse(I.Cuatrimestre.ToString().Substring(0, 4)) - 1).ToString() + "2";
            }
            File.Delete($@"{Environment.CurrentDirectory}\alumno.txt");
            File.WriteAllLines(($@"{Environment.CurrentDirectory}\alumno.txt"), archivotemporal);

            archivotemporal.Clear();

            foreach (string materia in MateriasAprobadasDJ)
            {
                File.AppendAllText($@"{Environment.CurrentDirectory}\condicion_materias.txt", Environment.NewLine + $"{Registro}|{materia}|{0}|{cuatrimestreAnterior}|A");

            }

            foreach (string materia in MateriasRegularizadas)
            {
                File.AppendAllText($@"{Environment.CurrentDirectory}\condicion_materias.txt", Environment.NewLine + $"{Registro}|{materia}|{0}|{cuatrimestreAnterior}|R");

            }


            //Se guarda en archivo permanente

            lineas_alumno = File.ReadLines($@"{Environment.CurrentDirectory}\alumnos.txt");
            foreach (var line in lineas_alumno)
            {
                archivotemporal.Add(line);
            }

            for (int i = 1; i < archivotemporal.Count; i++)
            {
                if (Registro == long.Parse(archivotemporal[i].Split('|')[2]))
                {
                    archivotemporal[i] = ($"{Nombre}|{Apellido}|{Registro}|{Ranking}|{Carrera}|{EsRegular}|{ConfirmoInscripcion}|{ConfirmoDJ}|{CuatroUltimas}");
                    break;
                }
            }

            File.Delete($@"{Environment.CurrentDirectory}\alumnos.txt");
            File.WriteAllLines(($@"{Environment.CurrentDirectory}\alumnos.txt"), archivotemporal);
            archivotemporal.Clear();

            















        }

        public string Nombre { get; }
        public string Apellido { get; }
        public long Registro { get; }
        public double Ranking { get; }
        public string Carrera { get; }
        public bool AproboCBC { get; }
        public bool NecesitaDJ { get; }
        public bool CuatroUltimas { get; set; }
       
        public double Promedio { get; }
        public List<short> ListaNotas { get; }
        public List<int> ListaCuatrimestres { get; }
        public List<string> MateriasCursadasCuatriAnterior { get; }
        public List<string> MateriasAprobadas {get; set;}
        public List<string> MateriasRegularizadas { get; set; }
        public List<string> MateriasAprobadasDJ { get; set; }
        public List<string> MateriasDisponibles { get; set; }

        public bool EsRegular { get; }
        public bool ConfirmoInscripcion { get; set; }
        public bool ConfirmoDJ { get; set; }


       
    }
}
