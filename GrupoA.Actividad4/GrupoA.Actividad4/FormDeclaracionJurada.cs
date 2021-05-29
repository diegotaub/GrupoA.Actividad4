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
    public partial class FormDeclaracionJurada : Form
    {
        public FormDeclaracionJurada()
        {
            InitializeComponent();
            Alumno A = new Alumno();
            Inscripcion I = new Inscripcion();
            Carrera C = new Carrera(A.Carrera);



            List<string> MateriasAprobadasCuatriAnterior = new List<string>();
            foreach (string materia in File.ReadAllLines($@"{Environment.CurrentDirectory}\materias_aprobadas.txt").Skip(1))
            {
                

                if (A.Registro == long.Parse(materia.Split('|')[0]))
                {
                    string cuatrimestre = materia.Split('|')[3];
                    if((cuatrimestre.EndsWith("1") && int.Parse(cuatrimestre) == I.Cuatrimestre - 1) || 
                        (cuatrimestre.EndsWith("2")) && I.Cuatrimestre.ToString().EndsWith("1") && (int.Parse(cuatrimestre.Substring(0, 4)) 
                        == int.Parse(I.Cuatrimestre.ToString().Substring(0, 4)) - 1))
                    {
                        MateriasAprobadasCuatriAnterior.Add(materia.Split('|')[1]);
                    }
                }
            }

            switch (MateriasAprobadasCuatriAnterior.Count())
            {
                case 0:
                    break;
                case 1:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[0]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    break;
                case 2:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[1]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    chMateriaDJ3.Visible = true;
                    chMateriaDJ4.Visible = true;

                    break;
                case 3:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[1]];
                    lblMateriaDJ3.Visible = true;
                    lblMateriaDJ3.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[2]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    chMateriaDJ3.Visible = true;
                    chMateriaDJ4.Visible = true;
                    chMateriaDJ5.Visible = true;
                    chMateriaDJ6.Visible = true;

                    break;
                case 4:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[1]];
                    lblMateriaDJ3.Visible = true;
                    lblMateriaDJ3.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[2]];
                    lblMateriaDJ4.Visible = true;
                    lblMateriaDJ4.Text = C.DiccionarioDeMaterias[MateriasAprobadasCuatriAnterior[3]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    chMateriaDJ3.Visible = true;
                    chMateriaDJ4.Visible = true;
                    chMateriaDJ5.Visible = true;
                    chMateriaDJ6.Visible = true;
                    chMateriaDJ7.Visible = true;
                    chMateriaDJ8.Visible = true;

                    break;

            }
        }

        private void btnAtrasDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void btnConfirmarDJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeclaracionJuradaNotificacion Form = new FormDeclaracionJuradaNotificacion();
            Form.Show();
        }
    }
}
