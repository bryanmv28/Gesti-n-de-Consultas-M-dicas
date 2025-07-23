using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Controllers;

namespace ClinicaMedica.Views.Manager
{
    public partial class FRMPacientes : Form
    {
        private int pacienteSeleccionadoId = -1;

        public FRMPacientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximizar ventana
            dgvPacientes.CellClick += dgvPacientes_CellClick;
        }

        private void FRMPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CenterPanels();
        }

        private void CargarPacientes()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = "SELECT paciente_id, nombre_completo, edad, telefono, fecha_registro FROM Pacientes";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPacientes.DataSource = dt;
                    dgvPacientes.Columns["paciente_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new PacienteController();
                var paciente = new Models.PacienteModel
                {
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    Edad = Convert.ToInt32(txtEdad.Text.Trim()),
                    Telefono = txtTelefono.Text.Trim()
                };
                string resultado = controller.Insertar(paciente);
                if (resultado == "ok")
                {
                    MessageBox.Show("Paciente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al agregar paciente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un paciente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new PacienteController();
                var paciente = new Models.PacienteModel
                {
                    PacienteId = pacienteSeleccionadoId,
                    NombreCompleto = txtNombreCompleto.Text.Trim(),
                    Edad = Convert.ToInt32(txtEdad.Text.Trim()),
                    Telefono = txtTelefono.Text.Trim()
                };
                string resultado = controller.Actualizar(paciente);
                if (resultado == "ok")
                {
                    MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar paciente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pacienteSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un paciente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new PacienteController();
                string resultado = controller.Eliminar(pacienteSeleccionadoId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar paciente: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];
                pacienteSeleccionadoId = Convert.ToInt32(fila.Cells["paciente_id"].Value);
                txtNombreCompleto.Text = fila.Cells["nombre_completo"].Value.ToString();
                txtEdad.Text = fila.Cells["edad"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value?.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios (Nombre, Edad).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0 || edad > 150)
            {
                MessageBox.Show("Edad inválida. Debe ser un número entre 0 y 150.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            pacienteSeleccionadoId = -1;
        }

        private void CenterPanels()
        {
            // Centrar los paneles y ajustar el DataGridView
            this.panelIzquierdo.Location = new System.Drawing.Point(50, 50);
            this.panelBotones.Location = new System.Drawing.Point(50, this.panelIzquierdo.Bottom + 20);
            this.dgvPacientes.Location = new System.Drawing.Point(this.panelIzquierdo.Right + 50, 50);
            this.dgvPacientes.Size = new System.Drawing.Size(this.ClientSize.Width - this.panelIzquierdo.Width - 150, this.ClientSize.Height - 150);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreCompleto_Click(object sender, EventArgs e)
        {

        }
    }
}