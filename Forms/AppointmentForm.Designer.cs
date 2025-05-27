namespace MedicalScheduler.Forms
{
    partial class AppointmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxAppointment;
        private Label lblPatient;
        private ComboBox cmbPatient;
        private Label lblDoctor;
        private ComboBox cmbDoctor;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblTime;
        private DateTimePicker dtpTime;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;

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
            this.groupBoxAppointment = new GroupBox();
            this.lblPatient = new Label();
            this.cmbPatient = new ComboBox();
            this.lblDoctor = new Label();
            this.cmbDoctor = new ComboBox();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblTime = new Label();
            this.dtpTime = new DateTimePicker();
            this.lblStatus = new Label();
            this.cmbStatus = new ComboBox();
            this.lblNotes = new Label();
            this.txtNotes = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            
            this.groupBoxAppointment.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // groupBoxAppointment
            // 
            this.groupBoxAppointment.Controls.Add(this.lblPatient);
            this.groupBoxAppointment.Controls.Add(this.cmbPatient);
            this.groupBoxAppointment.Controls.Add(this.lblDoctor);
            this.groupBoxAppointment.Controls.Add(this.cmbDoctor);
            this.groupBoxAppointment.Controls.Add(this.lblDate);
            this.groupBoxAppointment.Controls.Add(this.dtpDate);
            this.groupBoxAppointment.Controls.Add(this.lblTime);
            this.groupBoxAppointment.Controls.Add(this.dtpTime);
            this.groupBoxAppointment.Controls.Add(this.lblStatus);
            this.groupBoxAppointment.Controls.Add(this.cmbStatus);
            this.groupBoxAppointment.Controls.Add(this.lblNotes);
            this.groupBoxAppointment.Controls.Add(this.txtNotes);
            this.groupBoxAppointment.Controls.Add(this.btnSave);
            this.groupBoxAppointment.Controls.Add(this.btnCancel);
            this.groupBoxAppointment.Location = new Point(20, 20);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Size = new Size(460, 380);
            this.groupBoxAppointment.TabIndex = 0;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "Dados do Agendamento";
            
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new Point(20, 30);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new Size(55, 15);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Paciente:";
            
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPatient.Location = new Point(20, 50);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new Size(200, 23);
            this.cmbPatient.TabIndex = 1;
            
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new Point(240, 30);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new Size(47, 15);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Médico:";
            
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDoctor.Location = new Point(240, 50);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new Size(200, 23);
            this.cmbDoctor.TabIndex = 3;
            
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new Point(20, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(34, 15);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Data:";
            
            // 
            // dtpDate
            // 
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(20, 110);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(120, 23);
            this.dtpDate.TabIndex = 5;
            
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new Point(160, 90);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new Size(42, 15);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Horário:";
            
            // 
            // dtpTime
            // 
            this.dtpTime.Format = DateTimePickerFormat.Time;
            this.dtpTime.Location = new Point(160, 110);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new Size(100, 23);
            this.dtpTime.TabIndex = 7;
            
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
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new Point(20, 150);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new Size(79, 15);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "Observações:";
            
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new Point(20, 170);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = ScrollBars.Vertical;
            this.txtNotes.Size = new Size(420, 100);
            this.txtNotes.TabIndex = 11;
            
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(280, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(80, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(370, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 420);
            this.Controls.Add(this.groupBoxAppointment);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Agendamento";
            
            this.groupBoxAppointment.ResumeLayout(false);
            this.groupBoxAppointment.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
