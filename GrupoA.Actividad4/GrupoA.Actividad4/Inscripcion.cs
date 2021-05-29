using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupoA.Actividad4
{
    class Inscripcion
    {
        public Inscripcion()
        {
            foreach (string fecha in File.ReadAllLines($@"{Environment.CurrentDirectory}\calendario_de_inscripcion.txt").Skip(1))
            {

                FechaInicio = DateTime.Parse(fecha.Split('|')[0]);
                FechaFin = DateTime.Parse(fecha.Split('|')[1]);
                Cuatrimestre = int.Parse(fecha.Split('|')[2]);


            }
        }

        public bool VerificarInscripcion()
        {
            

            if(DateTime.Today >= FechaInicio && DateTime.Today <= FechaFin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Cuatrimestre { get; set; }


    }
}
