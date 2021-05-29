using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Actividad4
{
    public partial class FormSeleccionMaterias : Form
    {
        public FormSeleccionMaterias()
        {
            InitializeComponent();
        }

        private void btnAtrasSeleccionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeclaracionJuradaNotificacion Form = new FormDeclaracionJuradaNotificacion();
            Form.Show();
        }

        private void btnAceptarSeleccionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConfirmacionMaterias Form = new FormConfirmacionMaterias();
            Form.Show();
        }
    }
}
