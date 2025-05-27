using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MedicalScheduler.Data;
using MedicalScheduler.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalScheduler.Forms
{
    public partial class AppointmentForm : Form
    {
        private ClinicContext _context;
        private int? _appointmentId;

        public AppointmentForm(ClinicContext context, int? appointmentId = null)
        {
            InitializeComponent();
            _context = context;
            _appointmentId = appointmentId;
            LoadComboBoxes();
            SetupColors();
            
            if (_appointmentId.HasValue)
            {
                LoadAppointment();
                this.Text = "Editar Agendamento";
            }
            else
            {
                this.Text = "Novo Agendamento";
            }
        }

        private void SetupColors()
        {
            this.BackColor = Color.FromArgb(240, 248, 245);
            
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is Button groupBtn)
                        {
                            groupBtn.BackColor = Color.FromArgb(76, 175, 80);
                            groupBtn.ForeColor = Color.White;
                            groupBtn.FlatStyle = FlatStyle.Flat;
                            groupBtn.FlatAppearance.BorderSize = 0;
                        }
                    }
                }
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load patients
                var patients = _context.Patients.OrderBy(p => p.FullName).ToList();
                cmbPatient.DataSource = patients;
                cmbPatient.DisplayMember = "FullName";
                cmbPatient.ValueMember = "Id";

                // Load doctors
                var doctors = _context.Doctors.OrderBy(d => d.FullName).ToList();
                cmbDoctor.DataSource = doctors;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "Id";

                // Load status options
                cmbStatus.Items.AddRange(new string[] { "Agendado", "Confirmado", "Concluído", "Cancelado" });
                cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointment()
        {
            if (_appointmentId.HasValue)
            {
                try
                {
                    var appointment = _context.Appointments
                        .Include(a => a.Patient)
                        .Include(a => a.Doctor)
                        .FirstOrDefault(a => a.Id == _appointmentId.Value);

                    if (appointment != null)
                    {
                        cmbPatient.SelectedValue = appointment.PatientId;
                        cmbDoctor.SelectedValue = appointment.DoctorId;
                        dtpDate.Value = appointment.AppointmentDate.Date;
                        dtpTime.Value = appointment.AppointmentDate;
                        cmbStatus.SelectedItem = appointment.Status;
                        txtNotes.Text = appointment.Notes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar agendamento: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    var appointmentDate = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay);

                    if (_appointmentId.HasValue)
                    {
                        // Update existing appointment
                        var appointment = _context.Appointments.Find(_appointmentId.Value);
                        if (appointment != null)
                        {
                            appointment.PatientId = (int)cmbPatient.SelectedValue;
                            appointment.DoctorId = (int)cmbDoctor.SelectedValue;
                            appointment.AppointmentDate = appointmentDate;
                            appointment.Status = cmbStatus.SelectedItem.ToString();
                            appointment.Notes = txtNotes.Text.Trim();

                            _context.SaveChanges();
                            MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Create new appointment
                        var appointment = new Appointment
                        {
                            PatientId = (int)cmbPatient.SelectedValue,
                            DoctorId = (int)cmbDoctor.SelectedValue,
                            AppointmentDate = appointmentDate,
                            Status = cmbStatus.SelectedItem.ToString(),
                            Notes = txtNotes.Text.Trim()
                        };

                        _context.Appointments.Add(appointment);
                        _context.SaveChanges();
                        MessageBox.Show("Agendamento criado com sucesso!", "Sucesso", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar agendamento: {ex.Message}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("Selecione um paciente.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPatient.Focus();
                return false;
            }

            if (cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("Selecione um médico.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDoctor.Focus();
                return false;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            var appointmentDate = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay);
            if (appointmentDate <= DateTime.Now)
            {
                MessageBox.Show("A data e hora do agendamento deve ser futura.", "Validação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDate.Focus();
                return false;
            }

            return true;
        }
    }
}
