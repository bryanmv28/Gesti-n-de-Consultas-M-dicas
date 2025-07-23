namespace ClinicaMedica.Views.Manager
{
    partial class FRMMenuPrincipal
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
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(100, 149, 237); // Azul suave
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(30, 30);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(340, 80);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "Gestión de Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(100, 149, 237);
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Location = new System.Drawing.Point(30, 130);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(340, 80);
            this.btnMedicos.TabIndex = 1;
            this.btnMedicos.Text = "Gestión de Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(100, 149, 237);
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Location = new System.Drawing.Point(30, 230);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(340, 80);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "Gestión de Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(220, 20, 60); // Rojo suave
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(30, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(340, 80);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.btnPacientes);
            this.panelCentral.Controls.Add(this.btnMedicos);
            this.panelCentral.Controls.Add(this.btnCitas);
            this.panelCentral.Controls.Add(this.btnSalir);
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(240, 248, 255); // Fondo claro
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(400, 450);
            this.panelCentral.TabIndex = 4;
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None; // Centrado
            // 
            // FRMMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 220); // Fondo beige claro
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Name = "FRMMenuPrincipal";
            this.Text = "Sistema de Gestión de Clínicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMenuPrincipal_Load);
            this.Resize += new System.EventHandler(this.FRM_Resize);
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelCentral;

        private void FRMMenuPrincipal_Load(object sender, System.EventArgs e)
        {
            // Centrar el panel al cargar
            CenterPanel();
        }

        private void FRM_Resize(object sender, System.EventArgs e)
        {
            // Centrar el panel al redimensionar
            CenterPanel();
        }

        private void CenterPanel()
        {
            // Centrar el panelCentral en la ventana
            this.panelCentral.Location = new System.Drawing.Point(
                (this.ClientSize.Width - this.panelCentral.Width) / 2,
                (this.ClientSize.Height - this.panelCentral.Height) / 2);
        }
    }
}