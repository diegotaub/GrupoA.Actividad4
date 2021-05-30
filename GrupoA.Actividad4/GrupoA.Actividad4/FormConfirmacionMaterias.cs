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
    public partial class FormConfirmacionMaterias : Form
    {
        public FormConfirmacionMaterias()
        {
            InitializeComponent();
            
            string confirmacionMaterias = "";


            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria1", "cbPrimera1", "cbAlternativa1");
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria2", "cbPrimera2", "cbAlternativa2");
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria3", "cbPrimera3", "cbAlternativa3");
            confirmacionMaterias += Curso.PedirConfirmacionDeCursos("cbMateria4", "cbPrimera4", "cbAlternativa4");





            txtConfirmacionMaterias.Text = (confirmacionMaterias);
            
        }

        private void btnAtrasConfirmacionMaterias_Click(object sender, EventArgs e)
        {
            txtConfirmacionMaterias.Clear();
            this.Hide();
            FormSeleccionMaterias Form = new FormSeleccionMaterias();
            Form.Show();
        }

        private void btnConfirmarConfirmacionMaterias_Click(object sender, EventArgs e)
        {


            int maxCodigo = 1000000;

            foreach (string curso in File.ReadAllLines($@"{Environment.CurrentDirectory}\inscripciones.txt").Skip(1))
            {

                if (int.Parse(curso.Split('|')[0]) > maxCodigo)
                {
                    maxCodigo = int.Parse(curso.Split('|')[0]);
                }

            }

            List<string> Lineas = new List<string>();
            Alumno A = new Alumno();

           
            int codigo = (maxCodigo + 1);

            ComboBox cbMateria = Application.OpenForms["FormSeleccionMaterias"].Controls["cbMateria1"] as ComboBox;

            if(cbMateria.SelectedIndex != -1)
            {
                ComboBox cbPrimera = Application.OpenForms["FormSeleccionMaterias"].Controls["cbPrimera1"] as ComboBox;
                Lineas.Add($"{codigo}|{cbPrimera.Text}|P|{A.Registro}");
                ComboBox cbAlternativa = Application.OpenForms["FormSeleccionMaterias"].Controls["cbAlternativa1"] as ComboBox;
                if(cbAlternativa.SelectedIndex != -1)
                {
                    Lineas.Add($"{codigo}|{cbAlternativa.Text}|A|{A.Registro}");
                }
            }

            ComboBox cbMateria2 = Application.OpenForms["FormSeleccionMaterias"].Controls["cbMateria2"] as ComboBox;

            if (cbMateria2.SelectedIndex != -1)
            {
                ComboBox cbPrimera = Application.OpenForms["FormSeleccionMaterias"].Controls["cbPrimera2"] as ComboBox;
                Lineas.Add($"{codigo}|{cbPrimera.Text}|P|{A.Registro}");
                ComboBox cbAlternativa = Application.OpenForms["FormSeleccionMaterias"].Controls["cbAlternativa2"] as ComboBox;
                if (cbAlternativa.SelectedIndex != -1)
                {
                    Lineas.Add($"{codigo}|{cbAlternativa.Text}|A|{A.Registro}");
                }
            }

            ComboBox cbMateria3 = Application.OpenForms["FormSeleccionMaterias"].Controls["cbMateria3"] as ComboBox;

            if (cbMateria3.SelectedIndex != -1)
            {
                ComboBox cbPrimera = Application.OpenForms["FormSeleccionMaterias"].Controls["cbPrimera3"] as ComboBox;
                Lineas.Add($"{codigo}|{cbPrimera.Text}|P|{A.Registro}");
                ComboBox cbAlternativa = Application.OpenForms["FormSeleccionMaterias"].Controls["cbAlternativa3"] as ComboBox;
                if (cbAlternativa.SelectedIndex != -1)
                {
                    Lineas.Add($"{codigo}|{cbAlternativa.Text}|A|{A.Registro}");
                }
            }

            ComboBox cbMateria4 = Application.OpenForms["FormSeleccionMaterias"].Controls["cbMateria4"] as ComboBox;

            if (cbMateria4.SelectedIndex != -1)
            {
                ComboBox cbPrimera = Application.OpenForms["FormSeleccionMaterias"].Controls["cbPrimera4"] as ComboBox;
                Lineas.Add($"{codigo}|{cbPrimera.Text}|P|{A.Registro}");
                ComboBox cbAlternativa = Application.OpenForms["FormSeleccionMaterias"].Controls["cbAlternativa4"] as ComboBox;
                if (cbAlternativa.SelectedIndex != -1)
                {
                    Lineas.Add($"{codigo}|{cbAlternativa.Text}|A|{A.Registro}");
                }
            }




            File.AppendAllText($@"{Environment.CurrentDirectory}\inscripciones.txt", Environment.NewLine);
            File.AppendAllLines($@"{Environment.CurrentDirectory}\inscripciones.txt", Lineas);
                
            

            A.ConfirmoInscripcion = true;

            List<string> archivotemporal = new List<string>();
            var lineas_alumno = File.ReadLines($@"{Environment.CurrentDirectory}\alumno.txt");
            foreach (var line in lineas_alumno)
            {
                archivotemporal.Add(line);
            }

            for (int i = 1; i < archivotemporal.Count; i++)
            {
                if (A.Registro == long.Parse(archivotemporal[i].Split('|')[2]))
                {
                    archivotemporal[i] = ($"{A.Nombre}|{A.Apellido}|{A.Registro}|{A.Ranking}|{A.Carrera}|{A.EsRegular}|{A.ConfirmoInscripcion}|{A.ConfirmoDJ}|{A.CuatroUltimas}");
                    break;
                }
            }

            File.Delete($@"{Environment.CurrentDirectory}\alumno.txt");
            File.WriteAllLines(($@"{Environment.CurrentDirectory}\alumno.txt"), archivotemporal);



            this.Hide();
            FormComprobanteInscripcion Form = new FormComprobanteInscripcion();
            Form.Show();
        }
    }
}
