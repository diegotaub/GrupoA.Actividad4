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
    public partial class FormConfirmacionMaterias : Form
    {
        public FormConfirmacionMaterias()
        {
            InitializeComponent();
        }

        private void btnAtrasConfirmacionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeleccionMaterias Form = new FormSeleccionMaterias();
            Form.Show();
        }

        private void btnConfirmarConfirmacionMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormComprobanteInscripcion Form = new FormComprobanteInscripcion();
            Form.Show();
        }
    }
}
