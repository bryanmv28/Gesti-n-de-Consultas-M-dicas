using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Controllers;

namespace ClinicaMedica.Views.Manager
{
    public partial class FRMCitas : Form
    {
        private int citaSeleccionadaId = -1;

        public FRMCitas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximizar ventana
            ConfigurarDateTimePicker();
            dgvCitas.CellClick += dgvCitas_CellClick;
        }

        private void ConfigurarDateTimePicker()
        {
            dtpFechaCita.Format = DateTimePickerFormat.Custom;
            dtpFechaCita.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaCita.ShowUpDown = false;
            dtpFechaCita.MinDate = DateTime.Now;
            dtpFechaCita.MaxDate = DateTime.Now.AddMonths(6); // Máximo 6 meses en el futuro
        }

        private void FRMCitas_Load(object sender, EventArgs e)
        {
            CargarCitas();
            CargarComboPacientes();
            CargarComboMedicos();
            CargarComboEstado();
            CenterPanels();
        }

        private void CargarCitas()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (var cn = conexion.AbrirConexion())
                {
                    string query = @"SELECT c.cita_id, p.nombre_completo AS paciente, m.nombre_completo AS medico, 
                                    c.fecha_cita, c.diagnostico, c.estado 
                                    FROM Citas c
                                    JOIN Pacientes p ON c.paciente_id = p.paciente_id
                                    JOIN Medicos m ON c.medico_id = m.medico_id";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, (MySqlConnection)cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCitas.DataSource = dt;
                    dgvCitas.Columns["cita_id"].Visible = false;
                    dgvCitas.Columns["fecha_cita"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; // Formato de fecha y hora
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboPacientes()
        {
            try
            {
                var controller = new PacienteController();
                var pacientes = controller.Listar();
                cbPaciente.Items.Clear();
                foreach (var paciente in pacientes)
                {
                    cbPaciente.Items.Add(new { Id = paciente.PacienteId, Nombre = paciente.NombreCompleto });
                }
                cbPaciente.DisplayMember = "Nombre";
                cbPaciente.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboMedicos()
        {
            try
            {
                var controller = new MedicoController();
                var medicos = controller.Listar();
                cbMedico.Items.Clear();
                foreach (var medico in medicos)
                {
                    cbMedico.Items.Add(new { Id = medico.MedicoId, Nombre = medico.NombreCompleto });
                }
                cbMedico.DisplayMember = "Nombre";
                cbMedico.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboEstado()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.AddRange(new[] { "pendiente", "completada", "cancelada" });
            cbEstado.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                var controller = new CitaController();
                var cita = new Models.CitaModel
                {
                    PacienteId = (int)cbPaciente.SelectedItem.GetType().GetProperty("Id").GetValue(cbPaciente.SelectedItem),
                    MedicoId = (int)cbMedico.SelectedItem.GetType().GetProperty("Id").GetValue(cbMedico.SelectedItem),
                    FechaCita = dtpFechaCita.Value,
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Estado = cbEstado.SelectedItem.ToString()
                };
                string resultado = controller.Insertar(cita);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cita agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Error al agregar cita: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionadaId == -1)
            {
                MessageBox.Show("Selecciona una cita para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                var controller = new CitaController();
                var cita = new Models.CitaModel
                {
                    CitaId = citaSeleccionadaId,
                    PacienteId = (int)cbPaciente.SelectedItem.GetType().GetProperty("Id").GetValue(cbPaciente.SelectedItem),
                    MedicoId = (int)cbMedico.SelectedItem.GetType().GetProperty("Id").GetValue(cbMedico.SelectedItem),
                    FechaCita = dtpFechaCita.Value,
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Estado = cbEstado.SelectedItem.ToString()
                };
                string resultado = controller.Actualizar(cita);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Error al actualizar cita: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionadaId == -1)
            {
                MessageBox.Show("Selecciona una cita para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var controller = new CitaController();
                string resultado = controller.Eliminar(citaSeleccionadaId);
                if (resultado == "ok")
                {
                    MessageBox.Show("Cita eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cita: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
                citaSeleccionadaId = Convert.ToInt32(fila.Cells["cita_id"].Value);
                cbPaciente.Text = fila.Cells["paciente"].Value.ToString();
                cbMedico.Text = fila.Cells["medico"].Value.ToString();
                dtpFechaCita.Value = Convert.ToDateTime(fila.Cells["fecha_cita"].Value);
                txtDiagnostico.Text = fila.Cells["diagnostico"].Value?.ToString();
                cbEstado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (cbPaciente.SelectedIndex == -1 || cbMedico.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbEstado.Text))
            {
                MessageBox.Show("Por favor, selecciona paciente, médico y estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime fechaCita = dtpFechaCita.Value;
            TimeSpan horaCita = fechaCita.TimeOfDay;
            TimeSpan horaInicio = new TimeSpan(8, 0, 0); // 08:00
            TimeSpan horaFin = new TimeSpan(18, 0, 0);  // 18:00

            if (fechaCita < DateTime.Now)
            {
                MessageBox.Show("La fecha de la cita no puede ser anterior al momento actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (fechaCita > DateTime.Now.AddMonths(6))
            {
                MessageBox.Show("La fecha de la cita no puede ser posterior a 6 meses.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (horaCita < horaInicio || horaCita > horaFin)
            {
                MessageBox.Show("La hora de la cita debe estar entre las 08:00 y las 18:00.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            cbPaciente.SelectedIndex = -1;
            cbMedico.SelectedIndex = -1;
            dtpFechaCita.Value = DateTime.Now;
            txtDiagnostico.Clear();
            cbEstado.SelectedIndex = 0;
            citaSeleccionadaId = -1;
        }

        private void CenterPanels()
        {
            // Centrar los paneles y ajustar el DataGridView
            this.panelIzquierdo.Location = new System.Drawing.Point(50, 50);
            this.panelBotones.Location = new System.Drawing.Point(50, this.panelIzquierdo.Bottom + 20);
            this.dgvCitas.Location = new System.Drawing.Point(this.panelIzquierdo.Right + 50, 50);
            this.dgvCitas.Size = new System.Drawing.Size(this.ClientSize.Width - this.panelIzquierdo.Width - 150, this.ClientSize.Height - 150);
        }
    }
}