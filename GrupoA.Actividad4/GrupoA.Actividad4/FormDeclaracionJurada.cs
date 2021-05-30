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



            

            switch (A.MateriasCursadasCuatriAnterior.Count())
            {
                case 0:
                    break;
                case 1:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[0]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    break;
                case 2:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[1]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    chMateriaDJ3.Visible = true;
                    chMateriaDJ4.Visible = true;

                    break;
                case 3:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[1]];
                    lblMateriaDJ3.Visible = true;
                    lblMateriaDJ3.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[2]];
                    chMateriaDJ1.Visible = true;
                    chMateriaDJ2.Visible = true;
                    chMateriaDJ3.Visible = true;
                    chMateriaDJ4.Visible = true;
                    chMateriaDJ5.Visible = true;
                    chMateriaDJ6.Visible = true;

                    break;
                case 4:
                    lblMateriaDJ1.Visible = true;
                    lblMateriaDJ1.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[0]];
                    lblMateriaDJ2.Visible = true;
                    lblMateriaDJ2.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[1]];
                    lblMateriaDJ3.Visible = true;
                    lblMateriaDJ3.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[2]];
                    lblMateriaDJ4.Visible = true;
                    lblMateriaDJ4.Text = C.DiccionarioDeMaterias[A.MateriasCursadasCuatriAnterior[3]];
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
            
            Alumno A = new Alumno();
            Carrera C = new Carrera(A.Carrera);
            if (ch4ultimasDJ.Checked)
            {
                A.CuatroUltimas = true;
            }
            A.ConfirmoDJ = true;


            if (chMateriaDJ2.Checked)
            {
                foreach (KeyValuePair<string, string> KeyValue in C.DiccionarioDeMaterias)
                {
                    if (KeyValue.Value == lblMateriaDJ1.Text)
                    {
                        A.MateriasAprobadasDJ.Add(KeyValue.Key);
                    }
                }

            }


            if (chMateriaDJ4.Checked)
            {
                foreach (KeyValuePair<string, string> KeyValue in C.DiccionarioDeMaterias)
                {
                    if (KeyValue.Value == lblMateriaDJ2.Text)
                    {
                        A.MateriasAprobadasDJ.Add(KeyValue.Key);
                    }
                }

            }

            if (chMateriaDJ6.Checked)
            {
                foreach (KeyValuePair<string, string> KeyValue in C.DiccionarioDeMaterias)
                {
                    if (KeyValue.Value == lblMateriaDJ3.Text)
                    {
                        A.MateriasAprobadasDJ.Add(KeyValue.Key);
                    }
                }

            }

            if (chMateriaDJ8.Checked)
            {
                foreach (KeyValuePair<string, string> KeyValue in C.DiccionarioDeMaterias)
                {
                    if (KeyValue.Value == lblMateriaDJ4.Text)
                    {
                        A.MateriasAprobadasDJ.Add(KeyValue.Key);
                    }
                }

            }




            A.GuardarAlumno();
            this.Hide();
            FormDeclaracionJuradaNotificacion Form = new FormDeclaracionJuradaNotificacion();
            Form.Show();
        }
    }
}
