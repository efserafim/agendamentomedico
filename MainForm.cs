using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MedicalScheduler.Data;
using MedicalScheduler.Forms;
using MedicalScheduler.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalScheduler
{
    public partial class MainForm : Form
    {
        private ClinicContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new ClinicContext();
            LoadAppointments();
            SetupColors();
        }

        private void SetupColors()
        {
            // Green color scheme
            this.BackColor = Color.FromArgb(240, 248, 245); // Light green background
            
            // Panel colors
            panelTop.BackColor = Color.FromArgb(46, 125, 50); // Dark green
            panelSide.BackColor = Color.FromArgb(200, 230, 201); // Light green
            
            // Button colors
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80); // Medium green
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
            
            foreach (Control control in panelSide.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(76, 175, 80);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void LoadAppointments()
        {
            try
            {
                var appointments = _context.Appointments
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor)
                    .OrderBy(a => a.AppointmentDate)
                    .ToList();

                dataGridViewAppointments.DataSource = appointments.Select(a => new
                {
                    Id = a.Id,
                    Patient = a.Patient.FullName,
                    Doctor = a.Doctor.FullName,
                    Date = a.AppointmentDate.ToString("dd/MM/yyyy"),
                    Time = a.AppointmentDate.ToString("HH:mm"),
                    Status = a.Status,
                    Notes = a.Notes
                }).ToList();

                // Customize grid appearance
                dataGridViewAppointments.BackgroundColor = Color.White;
                dataGridViewAppointments.GridColor = Color.FromArgb(200, 230, 201);
                dataGridViewAppointments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(129, 199, 132);
                dataGridViewAppointments.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridViewAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
                dataGridViewAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewAppointments.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar agendamentos: {ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            var appointmentForm = new AppointmentForm(_context);
            if (appointmentForm.ShowDialog() == DialogResult.OK)
            {
                LoadAppointments();
            }
        }

        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            var patientForm = new PatientForm(_context);
            patientForm.ShowDialog();
        }

        private void btnManageDoctors_Click(object sender, EventArgs e)
        {
            var doctorForm = new DoctorForm(_context);
            doctorForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointments.SelectedRows[0];
                var appointmentId = (int)selectedRow.Cells["Id"].Value;
                
                var appointmentForm = new AppointmentForm(_context, appointmentId);
                if (appointmentForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAppointments();
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para editar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir este agendamento?", 
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var selectedRow = dataGridViewAppointments.SelectedRows[0];
                        var appointmentId = (int)selectedRow.Cells["Id"].Value;
                        
                        var appointment = _context.Appointments.Find(appointmentId);
                        if (appointment != null)
                        {
                            _context.Appointments.Remove(appointment);
                            _context.SaveChanges();
                            LoadAppointments();
                            MessageBox.Show("Agendamento excluído com sucesso!", "Sucesso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir agendamento: {ex.Message}", "Erro", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para excluir.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
