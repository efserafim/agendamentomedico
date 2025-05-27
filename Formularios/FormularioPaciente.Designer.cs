namespace AgendamentoMedico.Formularios
{
    partial class FormularioPaciente
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewPacientes;
        private GroupBox groupBoxInfoPaciente;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;

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
            this.dataGridViewPacientes = new DataGridView();
            this.groupBoxInfoPaciente = new GroupBox();
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.lblTelefone = new Label();
            this.txtTelefone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblDataNascimento = new Label();
            this.dtpDataNascimento = new DateTimePicker();
            this.btnAdicionar = new Button();
            this.btnAtualizar = new Button();
            this.btnExcluir = new Button();
            this.btnLimpar = new Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.groupBoxInfoPaciente.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new Point(20, 20);
            this.dataGridViewPacientes.MultiSelect = false;
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacientes.Size = new Size(560, 300);
            this.dataGridViewPacientes.TabIndex = 0;
            this.dataGridViewPacientes.SelectionChanged += new EventHandler(this.dataGridViewPacientes_SelectionChanged);
            
            // 
            // groupBoxInfoPaciente
            // 
            this.groupBoxInfoPaciente.Controls.Add(this.lblNome);
            this.groupBoxInfoPaciente.Controls.Add(this.txtNome);
            this.groupBoxInfoPaciente.Controls.Add(this.lblTelefone);
            this.groupBoxInfoPaciente.Controls.Add(this.txtTelefone);
            this.groupBoxInfoPaciente.Controls.Add(this.lblEmail);
            this.groupBoxInfoPaciente.Controls.Add(this.txtEmail);
            this.groupBoxInfoPaciente.Controls.Add(this.lblDataNascimento);
            this.groupBoxInfoPaciente.Controls.Add(this.dtpDataNascimento);
            this.groupBoxInfoPaciente.Controls.Add(this.btnAdicionar);
            this.groupBoxInfoPaciente.Controls.Add(this.btnAtualizar);
            this.groupBoxInfoPaciente.Controls.Add(this.btnExcluir);
            this.groupBoxInfoPaciente.Controls.Add(this.btnLimpar);
            this.groupBoxInfoPaciente.Location = new Point(20, 340);
            this.groupBoxInfoPaciente.Name = "groupBoxInfoPaciente";
            this.groupBoxInfoPaciente.Size = new Size(560, 200);
            this.groupBoxInfoPaciente.TabIndex = 1;
            this.groupBoxInfoPaciente.TabStop = false;
            this.groupBoxInfoPaciente.Text = "Informações do Paciente";
            
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new Point(20, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            
            // 
            // txtNome
            // 
            this.txtNome.Location = new Point(20, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(200, 23);
            this.txtNome.TabIndex = 1;
            
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new Point(240, 30);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new Size(54, 15);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new Point(240, 50);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(150, 23);
            this.txtTelefone.TabIndex = 3;
            
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(20, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(39, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(20, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 23);
            this.txtEmail.TabIndex = 5;
            
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new Point(240, 80);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new Size(107, 15);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data Nascimento:";
            
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new Point(240, 100);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new Size(150, 23);
            this.dtpDataNascimento.TabIndex = 7;
            
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new Point(20, 140);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new Size(80, 30);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new EventHandler(this.btnAdicionar_Click);
            
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new Point(110, 140);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new Size(80, 30);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new EventHandler(this.btnAtualizar_Click);
            
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new Point(200, 140);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new Size(80, 30);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
            
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new Point(290, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new Size(80, 30);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new EventHandler(this.btnLimpar_Click);
            
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 570);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.groupBoxInfoPaciente);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioPaciente";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gerenciar Pacientes";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.groupBoxInfoPaciente.ResumeLayout(false);
            this.groupBoxInfoPaciente.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}