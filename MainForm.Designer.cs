namespace MedicalScheduler
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTop;
        private Panel panelSide;
        private DataGridView dataGridViewAppointments;
        private Button btnNewAppointment;
        private Button btnManagePatients;
        private Button btnManageDoctors;
        private Button btnRefresh;
        private Button btnEditAppointment;
        private Button btnDeleteAppointment;
        private Label lblTitle;

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
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.panelSide = new Panel();
            this.btnNewAppointment = new Button();
            this.btnManagePatients = new Button();
            this.btnManageDoctors = new Button();
            this.btnRefresh = new Button();
            this.btnEditAppointment = new Button();
            this.btnDeleteAppointment = new Button();
            this.dataGridViewAppointments = new DataGridView();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(1000, 60);
            this.panelTop.TabIndex = 0;
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(350, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema de Agendamento Médico";
            
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.btnNewAppointment);
            this.panelSide.Controls.Add(this.btnEditAppointment);
            this.panelSide.Controls.Add(this.btnDeleteAppointment);
            this.panelSide.Controls.Add(this.btnManagePatients);
            this.panelSide.Controls.Add(this.btnManageDoctors);
            this.panelSide.Controls.Add(this.btnRefresh);
            this.panelSide.Dock = DockStyle.Left;
            this.panelSide.Location = new Point(0, 60);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new Size(200, 540);
            this.panelSide.TabIndex = 1;
            
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new Point(20, 20);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new Size(160, 40);
            this.btnNewAppointment.TabIndex = 0;
            this.btnNewAppointment.Text = "Novo Agendamento";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            this.btnNewAppointment.Click += new EventHandler(this.btnNewAppointment_Click);
            
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Location = new Point(20, 70);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new Size(160, 40);
            this.btnEditAppointment.TabIndex = 1;
            this.btnEditAppointment.Text = "Editar Agendamento";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            this.btnEditAppointment.Click += new EventHandler(this.btnEditAppointment_Click);
            
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new Point(20, 120);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new Size(160, 40);
            this.btnDeleteAppointment.TabIndex = 2;
            this.btnDeleteAppointment.Text = "Excluir Agendamento";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new EventHandler(this.btnDeleteAppointment_Click);
            
            // 
            // btnManagePatients
            // 
            this.btnManagePatients.Location = new Point(20, 180);
            this.btnManagePatients.Name = "btnManagePatients";
            this.btnManagePatients.Size = new Size(160, 40);
            this.btnManagePatients.TabIndex = 3;
            this.btnManagePatients.Text = "Gerenciar Pacientes";
            this.btnManagePatients.UseVisualStyleBackColor = true;
            this.btnManagePatients.Click += new EventHandler(this.btnManagePatients_Click);
            
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.Location = new Point(20, 230);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Size = new Size(160, 40);
            this.btnManageDoctors.TabIndex = 4;
            this.btnManageDoctors.Text = "Gerenciar Médicos";
            this.btnManageDoctors.UseVisualStyleBackColor = true;
            this.btnManageDoctors.Click += new EventHandler(this.btnManageDoctors_Click);
            
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new Point(20, 290);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(160, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Dock = DockStyle.Fill;
            this.dataGridViewAppointments.Location = new Point(200, 60);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new Size(800, 540);
            this.dataGridViewAppointments.TabIndex = 2;
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agendamento Médico";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
