namespace MedicalScheduler.Forms
{
    partial class DoctorForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewDoctors;
        private GroupBox groupBoxDoctorInfo;
        private Label lblName;
        private TextBox txtName;
        private Label lblSpecialty;
        private TextBox txtSpecialty;
        private Label lblLicenseNumber;
        private TextBox txtLicenseNumber;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
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
            this.dataGridViewDoctors = new DataGridView();
            this.groupBoxDoctorInfo = new GroupBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblSpecialty = new Label();
            this.txtSpecialty = new TextBox();
            this.lblLicenseNumber = new Label();
            this.txtLicenseNumber = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxDoctorInfo.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new Point(20, 20);
            this.dataGridViewDoctors.MultiSelect = false;
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new Size(660, 300);
            this.dataGridViewDoctors.TabIndex = 0;
            this.dataGridViewDoctors.SelectionChanged += new EventHandler(this.dataGridViewDoctors_SelectionChanged);
            
            // 
            // groupBoxDoctorInfo
            // 
            this.groupBoxDoctorInfo.Controls.Add(this.lblName);
            this.groupBoxDoctorInfo.Controls.Add(this.txtName);
            this.groupBoxDoctorInfo.Controls.Add(this.lblSpecialty);
            this.groupBoxDoctorInfo.Controls.Add(this.txtSpecialty);
            this.groupBoxDoctorInfo.Controls.Add(this.lblLicenseNumber);
            this.groupBoxDoctorInfo.Controls.Add(this.txtLicenseNumber);
            this.groupBoxDoctorInfo.Controls.Add(this.lblPhone);
            this.groupBoxDoctorInfo.Controls.Add(this.txtPhone);
            this.groupBoxDoctorInfo.Controls.Add(this.lblEmail);
            this.groupBoxDoctorInfo.Controls.Add(this.txtEmail);
            this.groupBoxDoctorInfo.Controls.Add(this.btnAdd);
            this.groupBoxDoctorInfo.Controls.Add(this.btnUpdate);
            this.groupBoxDoctorInfo.Controls.Add(this.btnDelete);
            this.groupBoxDoctorInfo.Controls.Add(this.btnClear);
            this.groupBoxDoctorInfo.Location = new Point(20, 340);
            this.groupBoxDoctorInfo.Name = "groupBoxDoctorInfo";
            this.groupBoxDoctorInfo.Size = new Size(660, 200);
            this.groupBoxDoctorInfo.TabIndex = 1;
            this.groupBoxDoctorInfo.TabStop = false;
            this.groupBoxDoctorInfo.Text = "Informações do Médico";
            
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
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new Point(240, 30);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new Size(84, 15);
            this.lblSpecialty.TabIndex = 2;
            this.lblSpecialty.Text = "Especialidade:";
            
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new Point(240, 50);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new Size(200, 23);
            this.txtSpecialty.TabIndex = 3;
            
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Location = new Point(460, 30);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new Size(35, 15);
            this.lblLicenseNumber.TabIndex = 4;
            this.lblLicenseNumber.Text = "CRM:";
            
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Location = new Point(460, 50);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new Size(180, 23);
            this.txtLicenseNumber.TabIndex = 5;
            
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new Point(20, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(54, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefone:";
            
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new Point(20, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(200, 23);
            this.txtPhone.TabIndex = 7;
            
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
            // btnAdd
            // 
            this.btnAdd.Location = new Point(20, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(80, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(110, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(200, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(290, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(80, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(700, 570);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.groupBoxDoctorInfo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DoctorForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gerenciar Médicos";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxDoctorInfo.ResumeLayout(false);
            this.groupBoxDoctorInfo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
