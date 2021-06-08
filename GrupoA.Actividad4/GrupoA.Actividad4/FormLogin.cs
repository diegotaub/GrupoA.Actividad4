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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            string[] archivoTemporal = File.ReadAllLines($@"{Environment.CurrentDirectory}\alumnos.txt");

            File.WriteAllText($@"{Environment.CurrentDirectory}\alumno.txt", String.Empty);


            using (StreamWriter writer = new StreamWriter($@"{Environment.CurrentDirectory}\alumno.txt"))
            {

                writer.WriteLine(archivoTemporal[0]);

            }

            foreach (string alumno in File.ReadAllLines($@"{Environment.CurrentDirectory}\alumnos.txt").Skip(1))
            {

                lbUsuarios.Items.Add($"{alumno.Split('|')[0]} {alumno.Split('|')[1]} - {alumno.Split('|')[2]}");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registro = lbUsuarios.SelectedItem.ToString().Split(' ').LastOrDefault();

            foreach (string alumno in File.ReadAllLines($@"{Environment.CurrentDirectory}\alumnos.txt").Skip(1))
            {
                if(registro == alumno.Split('|')[2])
                {
                    File.AppendAllText($@"{Environment.CurrentDirectory}\alumno.txt", alumno);
                    break;
                }

            }

            this.Hide();
            Form1 Form = new Form1();
            Form.Show();
        }
    }
}
