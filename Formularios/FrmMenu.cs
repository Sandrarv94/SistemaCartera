using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCartera.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnDetallePago_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FrmDetallePago());
        }


        private Form formularioActivo = null;
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioActivo.Show();
        }

        private void btnTitular_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FrmTitular());
        }


        private void btnPagoCuota_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FrmPagos());
        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FrmPoliza());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FrmDeudores());
        }
    }
}
