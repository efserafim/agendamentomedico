namespace AgendamentoMedico.Formularios
{
    partial class FormularioAgendamento
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxAgendamento;
        private Label lblPaciente;
        private ComboBox cmbPaciente;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private Label lblData;
        private DateTimePicker dtpData;
        private Label lblHorario;
        private DateTimePicker dtpHorario;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblObservacoes;
        private TextBox txtObservacoes;
        private Button btnSalvar;
        private Button btnCancelar;

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
            this.groupBoxAgendamento = new GroupBox();
            this.lblPaciente = new Label();
            this.cmbPaciente = new ComboBox();
            this.lblMedico = new Label();
            this.cmbMedico = new ComboBox();
            this.lblData = new Label();
            this.dtpData = new DateTimePicker();
            this.lblHorario = new Label();
            this.dtpHorario = new DateTimePicker();
            this.lblStatus = new Label();
            this.cmbStatus = new ComboBox();
            this.lblObservacoes = new Label();
            this.txtObservacoes = new TextBox();
            this.btnSalvar = new Button();
            this.btnCancelar = new Button();
            
            this.groupBoxAgendamento.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // groupBoxAgendamento
            // 
            this.groupBoxAgendamento.Controls.Add(this.lblPaciente);
            this.groupBoxAgendamento.Controls.Add(this.cmbPaciente);
            this.groupBoxAgendamento.Controls.Add(this.lblMedico);
            this.groupBoxAgendamento.Controls.Add(this.cmbMedico);
            this.groupBoxAgendamento.Controls.Add(this.lblData);
            this.groupBoxAgendamento.Controls.Add(this.dtpData);
            this.groupBoxAgendamento.Controls.Add(this.lblHorario);
            this.groupBoxAgendamento.Controls.Add(this.dtpHorario);
            this.groupBoxAgendamento.Controls.Add(this.lblStatus);
            this.groupBoxAgendamento.Controls.Add(this.cmbStatus);
            this.groupBoxAgendamento.Controls.Add(this.lblObservacoes);
            this.groupBoxAgendamento.Controls.Add(this.txtObservacoes);
            this.groupBoxAgendamento.Controls.Add(this.btnSalvar);
            this.groupBoxAgendamento.Controls.Add(this.btnCancelar);
            this.groupBoxAgendamento.Location = new Point(20, 20);
            this.groupBoxAgendamento.Name = "groupBoxAgendamento";
            this.groupBoxAgendamento.Size = new Size(460, 380);
            this.groupBoxAgendamento.TabIndex = 0;
            this.groupBoxAgendamento.TabStop = false;
            this.groupBoxAgendamento.Text = "Dados do Agendamento";
            
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new Point(20, 30);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new Size(55, 15);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciente:";
            
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPaciente.Location = new Point(20, 50);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new Size(200, 23);
            this.cmbPaciente.TabIndex = 1;
            
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new Point(240, 30);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new Size(47, 15);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Médico:";
            
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMedico.Location = new Point(240, 50);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new Size(200, 23);
            this.cmbMedico.TabIndex = 3;
            
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new Point(20, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new Size(34, 15);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            
            // 
            // dtpData
            // 
            this.dtpData.Format = DateTimePickerFormat.Short;
            this.dtpData.Location = new Point(20, 110);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new Size(120, 23);
            this.dtpData.TabIndex = 5;
            
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new Point(160, 90);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new Size(50, 15);
            this.lblHorario.TabIndex = 6;
            this.lblHorario.Text = "Horário:";
            
            // 
            // dtpHorario
            // 
            this.dtpHorario.Format = DateTimePickerFormat.Time;
            this.dtpHorario.Location = new Point(160, 110);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new Size(100, 23);
            this.dtpHorario.TabIndex = 7;
            
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(280, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(42, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new Point(280, 110);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new Size(160, 23);
            this.cmbStatus.TabIndex = 9;
            
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new Point(20, 150);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new Size(79, 15);
            this.lblObservacoes.TabIndex = 10;
            this.lblObservacoes.Text = "Observações:";
            
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new Point(20, 170);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ScrollBars = ScrollBars.Vertical;
            this.txtObservacoes.Size = new Size(420, 100);
            this.txtObservacoes.TabIndex = 11;
            
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new Point(280, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new Size(80, 30);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new EventHandler(this.btnSalvar_Click);
            
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new Point(370, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(80, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            
            // 
            // FormularioAgendamento
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 420);
            this.Controls.Add(this.groupBoxAgendamento);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioAgendamento";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Agendamento";
            
            this.groupBoxAgendamento.ResumeLayout(false);
            this.groupBoxAgendamento.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}