namespace MedicalScheduler.Forms
{
    partial class PatientForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewPatients;
        private GroupBox groupBoxPatientInfo;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

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
            this.dataGridViewPatients = new DataGridView();
            this.groupBoxPatientInfo = new GroupBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblDateOfBirth = new Label();
            this.dtpDateOfBirth = new DateTimePicker();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxPatientInfo.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new Point(20, 20);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new Size(560, 300);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.SelectionChanged += new EventHandler(this.dataGridViewPatients_SelectionChanged);
            
            // 
            // groupBoxPatientInfo
            // 
            this.groupBoxPatientInfo.Controls.Add(this.lblName);
            this.groupBoxPatientInfo.Controls.Add(this.txtName);
            this.groupBoxPatientInfo.Controls.Add(this.lblPhone);
            this.groupBoxPatientInfo.Controls.Add(this.txtPhone);
            this.groupBoxPatientInfo.Controls.Add(this.lblEmail);
            this.groupBoxPatientInfo.Controls.Add(this.txtEmail);
            this.groupBoxPatientInfo.Controls.Add(this.lblDateOfBirth);
            this.groupBoxPatientInfo.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxPatientInfo.Controls.Add(this.btnAdd);
            this.groupBoxPatientInfo.Controls.Add(this.btnUpdate);
            this.groupBoxPatientInfo.Controls.Add(this.btnDelete);
            this.groupBoxPatientInfo.Controls.Add(this.btnClear);
            this.groupBoxPatientInfo.Location = new Point(20, 340);
            this.groupBoxPatientInfo.Name = "groupBoxPatientInfo";
            this.groupBoxPatientInfo.Size = new Size(560, 200);
            this.groupBoxPatientInfo.TabIndex = 1;
            this.groupBoxPatientInfo.TabStop = false;
            this.groupBoxPatientInfo.Text = "Informações do Paciente";
            
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(40, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            
            // 
            // txtName
            // 
            this.txtName.Location = new Point(20, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(200, 23);
            this.txtName.TabIndex = 1;
            
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new Point(240, 30);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(54, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefone:";
            
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new Point(240, 50);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(150, 23);
            this.txtPhone.TabIndex = 3;
            
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
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new Point(240, 80);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new Size(107, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Data Nascimento:";
            
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new Point(240, 100);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new Size(150, 23);
            this.dtpDateOfBirth.TabIndex = 7;
            
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(20, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(80, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(110, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(200, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(80, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(290, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(80, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 570);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.groupBoxPatientInfo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatientForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gerenciar Pacientes";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxPatientInfo.ResumeLayout(false);
            this.groupBoxPatientInfo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
