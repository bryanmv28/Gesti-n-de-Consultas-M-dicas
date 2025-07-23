using System;
using System.Windows.Forms;

namespace ClinicaMedica.Views.Manager
{
    public partial class FRMMenuPrincipal : Form
    {
        public FRMMenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximizar ventana
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FRMPacientes frmPacientes = new FRMPacientes();
            frmPacientes.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FRMMedicos frmMedicos = new FRMMedicos();
            frmMedicos.ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FRMCitas frmCitas = new FRMCitas();
            frmCitas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}