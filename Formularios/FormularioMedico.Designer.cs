namespace AgendamentoMedico.Formularios
{
    partial class FormularioMedico
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewMedicos;
        private GroupBox groupBoxInfoMedico;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEspecialidade;
        private TextBox txtEspecialidade;
        private Label lblCRM;
        private TextBox txtCRM;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
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
            this.dataGridViewMedicos = new DataGridView();
            this.groupBoxInfoMedico = new GroupBox();
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.lblEspecialidade = new Label();
            this.txtEspecialidade = new TextBox();
            this.lblCRM = new Label();
            this.txtCRM = new TextBox();
            this.lblTelefone = new Label();
            this.txtTelefone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnAdicionar = new Button();
            this.btnAtualizar = new Button();
            this.btnExcluir = new Button();
            this.btnLimpar = new Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).BeginInit();
            this.groupBoxInfoMedico.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // dataGridViewMedicos
            // 
            this.dataGridViewMedicos.AllowUserToAddRows = false;
            this.dataGridViewMedicos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicos.Location = new Point(20, 20);
            this.dataGridViewMedicos.MultiSelect = false;
            this.dataGridViewMedicos.Name = "dataGridViewMedicos";
            this.dataGridViewMedicos.ReadOnly = true;
            this.dataGridViewMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicos.Size = new Size(660, 300);
            this.dataGridViewMedicos.TabIndex = 0;
            this.dataGridViewMedicos.SelectionChanged += new EventHandler(this.dataGridViewMedicos_SelectionChanged);
            
            // 
            // groupBoxInfoMedico
            // 
            this.groupBoxInfoMedico.Controls.Add(this.lblNome);
            this.groupBoxInfoMedico.Controls.Add(this.txtNome);
            this.groupBoxInfoMedico.Controls.Add(this.lblEspecialidade);
            this.groupBoxInfoMedico.Controls.Add(this.txtEspecialidade);
            this.groupBoxInfoMedico.Controls.Add(this.lblCRM);
            this.groupBoxInfoMedico.Controls.Add(this.txtCRM);
            this.groupBoxInfoMedico.Controls.Add(this.lblTelefone);
            this.groupBoxInfoMedico.Controls.Add(this.txtTelefone);
            this.groupBoxInfoMedico.Controls.Add(this.lblEmail);
            this.groupBoxInfoMedico.Controls.Add(this.txtEmail);
            this.groupBoxInfoMedico.Controls.Add(this.btnAdicionar);
            this.groupBoxInfoMedico.Controls.Add(this.btnAtualizar);
            this.groupBoxInfoMedico.Controls.Add(this.btnExcluir);
            this.groupBoxInfoMedico.Controls.Add(this.btnLimpar);
            this.groupBoxInfoMedico.Location = new Point(20, 340);
            this.groupBoxInfoMedico.Name = "groupBoxInfoMedico";
            this.groupBoxInfoMedico.Size = new Size(660, 200);
            this.groupBoxInfoMedico.TabIndex = 1;
            this.groupBoxInfoMedico.TabStop = false;
            this.groupBoxInfoMedico.Text = "Informações do Médico";
            
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
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new Point(240, 30);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new Size(84, 15);
            this.lblEspecialidade.TabIndex = 2;
            this.lblEspecialidade.Text = "Especialidade:";
            
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new Point(240, 50);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new Size(200, 23);
            this.txtEspecialidade.TabIndex = 3;
            
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new Point(460, 30);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new Size(35, 15);
            this.lblCRM.TabIndex = 4;
            this.lblCRM.Text = "CRM:";
            
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new Point(460, 50);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new Size(180, 23);
            this.txtCRM.TabIndex = 5;
            
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new Point(20, 80);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new Size(54, 15);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new Point(20, 100);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(200, 23);
            this.txtTelefone.TabIndex = 7;
            
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(240, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(39, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(240, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 23);
            this.txtEmail.TabIndex = 9;
            
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new Point(20, 140);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new Size(80, 30);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new EventHandler(this.btnAdicionar_Click);
            
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new Point(110, 140);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new Size(80, 30);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new EventHandler(this.btnAtualizar_Click);
            
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new Point(200, 140);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new Size(80, 30);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
            
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new Point(290, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new Size(80, 30);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new EventHandler(this.btnLimpar_Click);
            
            // 
            // FormularioMedico
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(700, 570);
            this.Controls.Add(this.dataGridViewMedicos);
            this.Controls.Add(this.groupBoxInfoMedico);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioMedico";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gerenciar Médicos";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).EndInit();
            this.groupBoxInfoMedico.ResumeLayout(false);
            this.groupBoxInfoMedico.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}