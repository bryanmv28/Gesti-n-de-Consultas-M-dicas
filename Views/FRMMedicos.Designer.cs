namespace ClinicaMedica.Views.Manager
{
    partial class FRMMedicos
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
            dgvMedicos = new DataGridView();
            txtNombreCompleto = new TextBox();
            cbEspecialidad = new ComboBox();
            lblNombreCompleto = new Label();
            lblEspecialidad = new Label();
            panelIzquierdo = new Panel();
            panelBotones = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
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
            btnEliminar.Location = new Point(20, 86);
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
            btnSalir.Location = new Point(220, 86);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 60);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.GridColor = Color.FromArgb(245, 245, 220);
            dgvMedicos.Location = new Point(550, 50);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersWidth = 51;
            dgvMedicos.Size = new Size(700, 500);
            dgvMedicos.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 14F);
            txtNombreCompleto.Location = new Point(20, 101);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(400, 45);
            txtNombreCompleto.TabIndex = 5;
            // 
            // cbEspecialidad
            // 
            cbEspecialidad.Font = new Font("Segoe UI", 14F);
            cbEspecialidad.FormattingEnabled = true;
            cbEspecialidad.Location = new Point(20, 191);
            cbEspecialidad.Name = "cbEspecialidad";
            cbEspecialidad.Size = new Size(400, 46);
            cbEspecialidad.TabIndex = 6;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 14F);
            lblNombreCompleto.Location = new Point(20, 60);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(247, 38);
            lblNombreCompleto.TabIndex = 7;
            lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 14F);
            lblEspecialidad.Location = new Point(20, 150);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(168, 38);
            lblEspecialidad.TabIndex = 8;
            lblEspecialidad.Text = "Especialidad";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(240, 248, 255);
            panelIzquierdo.Controls.Add(txtNombreCompleto);
            panelIzquierdo.Controls.Add(cbEspecialidad);
            panelIzquierdo.Controls.Add(lblNombreCompleto);
            panelIzquierdo.Controls.Add(lblEspecialidad);
            panelIzquierdo.Location = new Point(50, 50);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(450, 300);
            panelIzquierdo.TabIndex = 9;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(240, 248, 255);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Location = new Point(50, 370);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 180);
            panelBotones.TabIndex = 10;
            // 
            // FRMMedicos
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 220);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelBotones);
            Controls.Add(dgvMedicos);
            Font = new Font("Segoe UI", 14F);
            Name = "FRMMedicos";
            Text = "Gestión de Médicos";
            Load += FRMMedicos_Load;
            Resize += FRM_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelBotones;

        private void FRM_Resize(object sender, System.EventArgs e)
        {
            // Centrar los paneles y ajustar el DataGridView
            this.panelIzquierdo.Location = new System.Drawing.Point(50, 50);
            this.panelBotones.Location = new System.Drawing.Point(50, this.panelIzquierdo.Bottom + 20);
            this.dgvMedicos.Location = new System.Drawing.Point(this.panelIzquierdo.Right + 50, 50);
            this.dgvMedicos.Size = new System.Drawing.Size(this.ClientSize.Width - this.panelIzquierdo.Width - 150, this.ClientSize.Height - 150);
        }
    }
}