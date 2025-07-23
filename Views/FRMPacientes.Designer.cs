namespace ClinicaMedica.Views.Manager
{
    partial class FRMPacientes
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
            dgvPacientes = new DataGridView();
            txtNombreCompleto = new TextBox();
            txtEdad = new TextBox();
            txtTelefono = new TextBox();
            lblNombreCompleto = new Label();
            lblEdad = new Label();
            lblTelefono = new Label();
            panelIzquierdo = new Panel();
            panelBotones = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
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
            btnEditar.Location = new Point(220, 20);
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
            btnEliminar.Location = new Point(20, 102);
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
            btnSalir.Location = new Point(220, 99);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 60);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.GridColor = Color.FromArgb(245, 245, 220);
            dgvPacientes.Location = new Point(550, 50);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(700, 532);
            dgvPacientes.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 14F);
            txtNombreCompleto.Location = new Point(20, 90);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(400, 45);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 14F);
            txtEdad.Location = new Point(20, 180);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(400, 45);
            txtEdad.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(20, 281);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(400, 45);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 14F);
            lblNombreCompleto.Location = new Point(20, 49);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(247, 38);
            lblNombreCompleto.TabIndex = 8;
            lblNombreCompleto.Text = "Nombre Completo";
            lblNombreCompleto.Click += lblNombreCompleto_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14F);
            lblEdad.Location = new Point(20, 139);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(77, 38);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14F);
            lblTelefono.Location = new Point(20, 240);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(123, 38);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(240, 248, 255);
            panelIzquierdo.Controls.Add(txtNombreCompleto);
            panelIzquierdo.Controls.Add(txtEdad);
            panelIzquierdo.Controls.Add(txtTelefono);
            panelIzquierdo.Controls.Add(lblNombreCompleto);
            panelIzquierdo.Controls.Add(lblEdad);
            panelIzquierdo.Controls.Add(lblTelefono);
            panelIzquierdo.Location = new Point(50, 50);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(450, 350);
            panelIzquierdo.TabIndex = 11;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(240, 248, 255);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Location = new Point(50, 420);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 179);
            panelBotones.TabIndex = 12;
            // 
            // FRMPacientes
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 220);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelBotones);
            Controls.Add(dgvPacientes);
            Font = new Font("Segoe UI", 14F);
            Name = "FRMPacientes";
            Text = "Gestión de Pacientes";
            Load += FRMPacientes_Load;
            Resize += FRM_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelBotones;

        private void FRM_Resize(object sender, System.EventArgs e)
        {
            // Centrar los paneles y ajustar el DataGridView
            this.panelIzquierdo.Location = new System.Drawing.Point(50, 50);
            this.panelBotones.Location = new System.Drawing.Point(50, this.panelIzquierdo.Bottom + 20);
            this.dgvPacientes.Location = new System.Drawing.Point(this.panelIzquierdo.Right + 50, 50);
            this.dgvPacientes.Size = new System.Drawing.Size(this.ClientSize.Width - this.panelIzquierdo.Width - 150, this.ClientSize.Height - 150);
        }
    }
}