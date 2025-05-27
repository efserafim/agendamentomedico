namespace AgendamentoMedico
{
    partial class FormularioPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private Panel painelTopo;
        private Panel painelLateral;
        private DataGridView dataGridViewAgendamentos;
        private Button btnNovoAgendamento;
        private Button btnGerenciarPacientes;
        private Button btnGerenciarMedicos;
        private Button btnAtualizar;
        private Button btnEditarAgendamento;
        private Button btnExcluirAgendamento;
        private Label lblTitulo;

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
            this.painelTopo = new Panel();
            this.lblTitulo = new Label();
            this.painelLateral = new Panel();
            this.btnNovoAgendamento = new Button();
            this.btnGerenciarPacientes = new Button();
            this.btnGerenciarMedicos = new Button();
            this.btnAtualizar = new Button();
            this.btnEditarAgendamento = new Button();
            this.btnExcluirAgendamento = new Button();
            this.dataGridViewAgendamentos = new DataGridView();
            this.painelTopo.SuspendLayout();
            this.painelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).BeginInit();
            this.SuspendLayout();
            
            // 
            // painelTopo
            // 
            this.painelTopo.Controls.Add(this.lblTitulo);
            this.painelTopo.Dock = DockStyle.Top;
            this.painelTopo.Location = new Point(0, 0);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new Size(1000, 60);
            this.painelTopo.TabIndex = 0;
            
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Location = new Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(350, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Agendamento Médico";
            
            // 
            // painelLateral
            // 
            this.painelLateral.Controls.Add(this.btnNovoAgendamento);
            this.painelLateral.Controls.Add(this.btnEditarAgendamento);
            this.painelLateral.Controls.Add(this.btnExcluirAgendamento);
            this.painelLateral.Controls.Add(this.btnGerenciarPacientes);
            this.painelLateral.Controls.Add(this.btnGerenciarMedicos);
            this.painelLateral.Controls.Add(this.btnAtualizar);
            this.painelLateral.Dock = DockStyle.Left;
            this.painelLateral.Location = new Point(0, 60);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new Size(200, 540);
            this.painelLateral.TabIndex = 1;
            
            // 
            // btnNovoAgendamento
            // 
            this.btnNovoAgendamento.Location = new Point(20, 20);
            this.btnNovoAgendamento.Name = "btnNovoAgendamento";
            this.btnNovoAgendamento.Size = new Size(160, 40);
            this.btnNovoAgendamento.TabIndex = 0;
            this.btnNovoAgendamento.Text = "Novo Agendamento";
            this.btnNovoAgendamento.UseVisualStyleBackColor = true;
            this.btnNovoAgendamento.Click += new EventHandler(this.btnNovoAgendamento_Click);
            
            // 
            // btnEditarAgendamento
            // 
            this.btnEditarAgendamento.Location = new Point(20, 70);
            this.btnEditarAgendamento.Name = "btnEditarAgendamento";
            this.btnEditarAgendamento.Size = new Size(160, 40);
            this.btnEditarAgendamento.TabIndex = 1;
            this.btnEditarAgendamento.Text = "Editar Agendamento";
            this.btnEditarAgendamento.UseVisualStyleBackColor = true;
            this.btnEditarAgendamento.Click += new EventHandler(this.btnEditarAgendamento_Click);
            
            // 
            // btnExcluirAgendamento
            // 
            this.btnExcluirAgendamento.Location = new Point(20, 120);
            this.btnExcluirAgendamento.Name = "btnExcluirAgendamento";
            this.btnExcluirAgendamento.Size = new Size(160, 40);
            this.btnExcluirAgendamento.TabIndex = 2;
            this.btnExcluirAgendamento.Text = "Excluir Agendamento";
            this.btnExcluirAgendamento.UseVisualStyleBackColor = true;
            this.btnExcluirAgendamento.Click += new EventHandler(this.btnExcluirAgendamento_Click);
            
            // 
            // btnGerenciarPacientes
            // 
            this.btnGerenciarPacientes.Location = new Point(20, 180);
            this.btnGerenciarPacientes.Name = "btnGerenciarPacientes";
            this.btnGerenciarPacientes.Size = new Size(160, 40);
            this.btnGerenciarPacientes.TabIndex = 3;
            this.btnGerenciarPacientes.Text = "Gerenciar Pacientes";
            this.btnGerenciarPacientes.UseVisualStyleBackColor = true;
            this.btnGerenciarPacientes.Click += new EventHandler(this.btnGerenciarPacientes_Click);
            
            // 
            // btnGerenciarMedicos
            // 
            this.btnGerenciarMedicos.Location = new Point(20, 230);
            this.btnGerenciarMedicos.Name = "btnGerenciarMedicos";
            this.btnGerenciarMedicos.Size = new Size(160, 40);
            this.btnGerenciarMedicos.TabIndex = 4;
            this.btnGerenciarMedicos.Text = "Gerenciar Médicos";
            this.btnGerenciarMedicos.UseVisualStyleBackColor = true;
            this.btnGerenciarMedicos.Click += new EventHandler(this.btnGerenciarMedicos_Click);
            
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new Point(20, 290);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new Size(160, 40);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new EventHandler(this.btnAtualizar_Click);
            
            // 
            // dataGridViewAgendamentos
            // 
            this.dataGridViewAgendamentos.AllowUserToAddRows = false;
            this.dataGridViewAgendamentos.AllowUserToDeleteRows = false;
            this.dataGridViewAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendamentos.Dock = DockStyle.Fill;
            this.dataGridViewAgendamentos.Location = new Point(200, 60);
            this.dataGridViewAgendamentos.MultiSelect = false;
            this.dataGridViewAgendamentos.Name = "dataGridViewAgendamentos";
            this.dataGridViewAgendamentos.ReadOnly = true;
            this.dataGridViewAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAgendamentos.Size = new Size(800, 540);
            this.dataGridViewAgendamentos.TabIndex = 2;
            
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.dataGridViewAgendamentos);
            this.Controls.Add(this.painelLateral);
            this.Controls.Add(this.painelTopo);
            this.Name = "FormularioPrincipal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agendamento Médico";
            this.painelTopo.ResumeLayout(false);
            this.painelTopo.PerformLayout();
            this.painelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendamentos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}