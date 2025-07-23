using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Controllers;

namespace ClinicaMedica.Views.Manager
{
    public partial class FRMMedicos : Form
    {
        private int medicoSeleccionadoId = -1;

        public FRMMedicos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximizar ventana
            dgvMedicos.CellClick += dgvMedicos_CellClick;
        }

        private void FRMMedicos_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarComboEspecialidades();
            CenterPanels();
        }

        private void CargarMedicos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT medico_id, nombre_completo, especialidad FROM Medicos";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMedicos.DataSource = dt;
                    dgvMedicos.Columns["medico_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboEspecialidades()
        {
            cbEspecialidad.Items.Clear();
            cbEspecialidad.Items.AddRange(new[]
            {
                "Cardiología",
                "Pediatría",
                "Ginecología",
                "Neurología",
                "Dermatología",
                "General",
                "Ortopedia"
            });
            cbEspecialidad.SelectedIndex = -1; // Sin selección inicial
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new MedicoController();
                var medico = new Models.MedicoModel
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    Especialidad = cbEspecialidad.SelectedItem.ToString()
                };
                string resultado = controller.Insertar(medico);
                if (resultado == "ok")
                {
                    MessageBox.Show("Médico agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMedicos();
                }
                else
                {
                    MessageBox.Show("Error al agregar médico: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (medicoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un médico para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new MedicoController();
                var medico = new Models.MedicoModel
                {
                    MedicoId = medicoSeleccionadoId,
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    Especialidad = cbEspecialidad.SelectedItem.ToString()
                };
                string resultado = controller.Actualizar(medico);
                if (resultado == "ok")
                {
                    MessageBox.Show("Médico actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMedicos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar médico: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (medicoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un médico para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este médico?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new MedicoController();
                string resultado = controller.Eliminar(medicoSeleccionadoId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Médico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMedicos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar médico: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMedicos.Rows[e.RowIndex];
                medicoSeleccionadoId = Convert.ToInt32(fila.Cells["medico_id"].Value);
                txtNombreCompleto.Text = fila.Cells["nombre_completo"].Value.ToString();
                cbEspecialidad.SelectedItem = fila.Cells["especialidad"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || cbEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa los campos obligatorios (Nombre, Especialidad).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();
            cbEspecialidad.SelectedIndex = -1;
            medicoSeleccionadoId = -1;
        }

        private void CenterPanels()
        {
            // Centrar los paneles y ajustar el DataGridView
            this.panelIzquierdo.Location = new System.Drawing.Point(50, 50);
            this.panelBotones.Location = new System.Drawing.Point(50, this.panelIzquierdo.Bottom + 20);
            this.dgvMedicos.Location = new System.Drawing.Point(this.panelIzquierdo.Right + 50, 50);
            this.dgvMedicos.Size = new System.Drawing.Size(this.ClientSize.Width - this.panelIzquierdo.Width - 150, this.ClientSize.Height - 150);
        }
    }
}