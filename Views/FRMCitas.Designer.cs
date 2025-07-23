namespace ClinicaMedica.Views.Manager
{
    partial class FRMCitas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dgvCitas = new DataGridView();
            cbPaciente = new ComboBox();
            cbMedico = new ComboBox();
            dtpFechaCita = new DateTimePicker();
            txtDiagnostico = new TextBox();
            cbEstado = new ComboBox();
            lblPaciente = new Label();
            lblMedico = new Label();
            lblFechaCita = new Label();
            lblDiagnostico = new Label();
            lblEstado = new Label();
            panelIzquierdo = new Panel();
            panelBotones = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            panelIzquierdo.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(60, 179, 113);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 60);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(100, 149, 237);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(20, 84);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(180, 60);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 20, 60);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(240, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 60);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(169, 169, 169);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(240, 86);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 60);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.GridColor = Color.FromArgb(245, 245, 220);
            dgvCitas.Location = new Point(547, 29);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(700, 520);
            dgvCitas.TabIndex = 4;
            // 
            // cbPaciente
            // 
            cbPaciente.Font = new Font("Segoe UI", 14F);
            cbPaciente.FormattingEnabled = true;
            cbPaciente.Location = new Point(20, 90);
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(400, 46);
            cbPaciente.TabIndex = 5;
            // 
            // cbMedico
            // 
            cbMedico.Font = new Font("Segoe UI", 14F);
            cbMedico.FormattingEnabled = true;
            cbMedico.Location = new Point(20, 180);
            cbMedico.Name = "cbMedico";
            cbMedico.Size = new Size(400, 46);
            cbMedico.TabIndex = 6;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Font = new Font("Segoe UI", 14F);
            dtpFechaCita.Location = new Point(20, 270);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(400, 45);
            dtpFechaCita.TabIndex = 7;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Font = new Font("Segoe UI", 14F);
            txtDiagnostico.Location = new Point(20, 360);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(400, 45);
            txtDiagnostico.TabIndex = 8;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 14F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(20, 450);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(400, 46);
            cbEstado.TabIndex = 9;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 14F);
            lblPaciente.Location = new Point(20, 49);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(121, 38);
            lblPaciente.TabIndex = 10;
            lblPaciente.Text = "Paciente";
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 14F);
            lblMedico.Location = new Point(20, 139);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(109, 38);
            lblMedico.TabIndex = 11;
            lblMedico.Text = "Médico";
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Font = new Font("Segoe UI", 14F);
            lblFechaCita.Location = new Point(20, 229);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(179, 38);
            lblFechaCita.TabIndex = 12;
            lblFechaCita.Text = "Fecha y Hora";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 14F);
            lblDiagnostico.Location = new Point(20, 319);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(163, 38);
            lblDiagnostico.TabIndex = 13;
            lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 14F);
            lblEstado.Location = new Point(20, 409);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(98, 38);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(240, 248, 255);
            panelIzquierdo.Controls.Add(cbPaciente);
            panelIzquierdo.Controls.Add(cbMedico);
            panelIzquierdo.Controls.Add(dtpFechaCita);
            panelIzquierdo.Controls.Add(txtDiagnostico);
            panelIzquierdo.Controls.Add(cbEstado);
            panelIzquierdo.Controls.Add(lblPaciente);
            panelIzquierdo.Controls.Add(lblMedico);
            panelIzquierdo.Controls.Add(lblFechaCita);
            panelIzquierdo.Controls.Add(lblDiagnostico);
            panelIzquierdo.Controls.Add(lblEstado);
            panelIzquierdo.Location = new Point(70, 29);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(450, 520);
            panelIzquierdo.TabIndex = 15;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(240, 248, 255);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Location = new Point(70, 564);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 160);
            panelBotones.TabIndex = 16;
            // 
            // FRMCitas
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 220);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelBotones);
            Controls.Add(dgvCitas);
            Font = new Font("Segoe UI", 14F);
            Name = "FRMCitas";
            Text = "Gestión de Citas";
            Load += FRMCitas_Load;
            Resize += FRM_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelBotones;

        private void FRM_Resize(object sender, System.EventArgs e)
        {
            CenterPanels();
        }
    }
}